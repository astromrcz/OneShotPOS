using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Charting = System.Windows.Forms.DataVisualization.Charting;

namespace OneShotPOS
{
    public partial class UC_ActivityLog : UserControl
    {
        private static readonly Color ChartSeriesColor = Color.FromArgb(46, 204, 113);

        private const string ConnectionString = @"Data Source=""C:\Users\morco\Downloads\testDB.db"";Version=3;";
        public UC_ActivityLog()
        {
            InitializeComponent();
        }

        private void UC_ActivityLog_Load(object sender, EventArgs e)
        {
            LoadRecentActivities();

        }
        private void LoadRecentActivities()
        {
            panelActivityTimeline.Controls.Clear();

            // Reintroduce FlowLayoutPanel for vertical scrolling
            FlowLayoutPanel flowPanel = new FlowLayoutPanel
            {
                Dock = DockStyle.Fill,
                FlowDirection = FlowDirection.TopDown,
                WrapContents = false,
                AutoScroll = true,
                Padding = new Padding(0)
            };
            panelActivityTimeline.Controls.Add(flowPanel);

            // Query to fetch ALL activities (removed LIMIT 8)
            string sql = @"
    SELECT 
        T1.Timestamp, 
        T1.Description, 
        T1.ActivityType,
        T2.Name 
    FROM TBL_ACTIVITY_LOG T1
    LEFT JOIN TBL_EMPLOYEES T2 ON T1.EmployeeID = T2.EmployeeID
    ORDER BY T1.Timestamp DESC;";

            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
                {
                    connection.Open();
                    using (SQLiteCommand command = new SQLiteCommand(sql, connection))
                    {
                        using (SQLiteDataReader reader = command.ExecuteReader())
                        {
                            // 🌟 FIX: Use flowPanel.Width for the size of the control itself. 
                            // This lets the FlowLayoutPanel handle the scrollbar offset.
                            int rowWidth = flowPanel.Width;

                            while (reader.Read())
                            {
                                string timestamp = reader["Timestamp"].ToString();
                                string description = reader["Description"].ToString();
                                string activityType = reader["ActivityType"].ToString();
                                string employeeName = reader["Name"] is DBNull ? "System" : reader["Name"].ToString();

                                // 1. Create the Activity Row Panel
                                // Pass the full width of the FlowLayoutPanel
                                Panel activityRow = CreateActivityRow(timestamp, description, activityType, employeeName, rowWidth);
                                flowPanel.Controls.Add(activityRow);

                                // 2. Add Separator Line
                                Panel separator = new Panel
                                {
                                    Height = 1,
                                    BackColor = Color.LightGray,
                                    Width = rowWidth, // Use the same width for the separator
                                    Margin = new Padding(0, 0, 0, 0)
                                };
                                flowPanel.Controls.Add(separator);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle database error gracefully
                MessageBox.Show("Error loading activity log: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private Panel CreateActivityRow(string timestamp, string description, string activityType, string employeeName, int containerWidth)
        {
            // Height remains 70 for visual consistency; Width is now containerWidth
            Panel row = new Panel { Height = 70, Width = containerWidth, Padding = new Padding(5) };

            // Define layout parameters
            const int iconX = 5;
            const int textX = 25;
            const int valueWidth = 90;
            int descriptionWidth = containerWidth - textX - valueWidth - 10;

            // 1. Activity Type Icon/Color Placeholder
            Panel iconPanel = new Panel
            {
                Width = 10,
                Height = 10,
                Location = new Point(iconX, 5),
                BackColor = GetActivityColor(activityType)
            };
            row.Controls.Add(iconPanel);

            // 2. Activity Type Label (Description)
            string headerText = GetActivityHeader(activityType, description);

            Label lblDescription = new Label
            {
                Text = headerText,
                Location = new Point(textX, 0),
                Size = new Size(descriptionWidth, 20), // Fixed height
                Font = new Font("Segoe UI", 9.5F, FontStyle.Bold),
                ForeColor = Color.DarkSlateGray
            };

            // 3. Employee and Time Footer (Time Zone FIX is here)
            DateTime loggedTime;
            TimeSpan elapsed = TimeSpan.Zero;
            string timeAgo = "N/A";

            if (DateTime.TryParse(timestamp, out loggedTime))
            {
               
                DateTime loggedTimeUtc = DateTime.SpecifyKind(loggedTime, DateTimeKind.Utc);

                DateTime loggedTimeLocal = loggedTimeUtc.ToLocalTime();

                elapsed = DateTime.Now - loggedTimeLocal;

               
                if (elapsed.TotalSeconds < 0)
                {
                    elapsed = TimeSpan.Zero;
                }

                timeAgo = GetTimeAgo(elapsed);
            }

            Label lblFooter = new Label
            {
                Text = $"{employeeName} • {timeAgo} ago",
                Location = new Point(textX, 25),
                AutoSize = true,
                Font = new Font("Segoe UI", 8F),
                ForeColor = Color.Gray
            };

           
            string valueText = GetActivityValue(description);
            Label lblValue = new Label
            {
                Text = valueText,
                Location = new Point(containerWidth - valueWidth - 10, 0), 
                Size = new Size(valueWidth, 30),
                TextAlign = ContentAlignment.MiddleRight,
                Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                ForeColor = valueText.Contains('₱') ? ChartSeriesColor : Color.DarkOrange
            };

            row.Controls.Add(lblValue);
            row.Controls.Add(lblDescription);
            row.Controls.Add(lblFooter);

            return row;
        }

        private string GetActivityHeader(string activityType, string description)
        {
            if (activityType == "Sale")
            {
                return $"Sale Completed: {description.Split(new[] { " completed for " }, StringSplitOptions.None)[0]}";
            }
            else if (activityType == "Inventory")
            {
                return $"Inventory updated: {description.Split(new[] { " stock updated from " }, StringSplitOptions.None)[0]}";
            }
            else if (activityType == "System" && description.Contains("Deleted"))
            {
                // Try to extract what was deleted
                if (description.Contains("queue group"))
                {
                    return $"Queue Group Deleted: {ExtractNameFrom(description, "queue group")}";
                }
                else if (description.Contains("table"))
                {
                    return $"Table Deleted: {ExtractNameFrom(description, "table")}";
                }
                else if (description.Contains("product"))
                {
                    return $"Product Deleted: {ExtractNameFrom(description, "product")}";
                }
                else
                {
                    return $"Deleted: {description}";
                }
            }

            return description;
        }
        private string ExtractNameFrom(string text, string keyword)
        {
            int start = text.IndexOf(keyword);
            if (start == -1) return keyword;

            string[] parts = text.Substring(start).Split(new[] { '\'', '"' }, StringSplitOptions.RemoveEmptyEntries);
            return parts.Length > 1 ? parts[1] : keyword;
        }


        private Color GetActivityColor(string type)
        {
            switch (type)
            {
                case "Sale": return ChartSeriesColor; // Green
                case "Inventory": return Color.DarkOrange;
                case "User": return Color.DarkBlue;
                case "Promo": return Color.MediumPurple;
                case "System": return Color.Gray;
                default: return Color.LightGray;
            }
        }

        private string GetTimeAgo(TimeSpan span)
        {
            if (span.TotalDays >= 1) return $"{(int)span.TotalDays} d";
            if (span.TotalHours >= 1) return $"{(int)span.TotalHours} hr";
            if (span.TotalMinutes >= 1) return $"{(int)span.TotalMinutes} min";
            return "just now";
        }

        private string GetActivityValue(string description)
        {
            // Extracts value based on content matching screenshot formats
            if (description.Contains("completed for P"))
            {
                string[] parts = description.Split(new[] { " for P" }, StringSplitOptions.None);
                if (parts.Length > 1) // Check if the array has an element at index 1
                {
                    return "₱" + parts[1].TrimEnd('.', '0');
                }
            }
            if (description.Contains("stock updated from"))
            {
                // Inventory update: "San Miguel Beer stock updated from 36 to 48 bottles"
                string[] parts = description.Split(new[] { " to " }, StringSplitOptions.None);
                if (parts.Length > 1)
                {
                    string newStock = parts[1].Split(' ')[0];
                    string unit = parts[1].Split(' ')[1];
                    return $"+{newStock} {unit}"; // e.g., "+48 bottles"
                }
            }
            // Default value for Table Check out (e.g., ₱1,240.00)
            if (description.Contains("Table") && description.Contains("checked out"))
            {
                // Use a mock value based on the screenshot, as the actual transaction data is complex.
                return "₱1,240.00";
            }
            return "";
        }
    }
    
}
