using SiticoneNetCoreUI;
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

namespace OneShotPOS
{
    public partial class UC_Receptionist : UserControl
    {
        //private const string ConnectionString = @"Data Source=""C:\Users\morco\Downloads\testDB.db"";Version=3;";
        //private const string EMPLOYEE_ID = "1001"; // Placeholder for logging consistency
        private readonly string _connectionString;
        public UC_Receptionist(string connectionString)
        {
            InitializeComponent();
            _connectionString = connectionString;

        }

        private void UC_Receptionist_Load(object sender, EventArgs e)
        {
            pnlTables.Padding = new Padding(10);
            pnlTables.Controls.Clear();

            LoadTableCards();
        }

        private void LoadTableCards()
        {
            using (var connection = new SQLiteConnection(_connectionString))
            {
                connection.Open();

                // Query to join TBL_TABLES with TBL_RESERVATIONS to get the latest active reservation details.
                string query = @"
                    SELECT 
                        T.TableID, T.TableName, T.Status, T.CustomerName, T.IsOpenTime, T.DurationHours,
                        R.ReservationDate, R.CustomerName AS ResCustomer
                    FROM TBL_TABLES T
                    LEFT JOIN TBL_RESERVATIONS R ON T.TableName = R.TableNumber AND R.Status = 'Active'
                    ORDER BY T.TableID;";

                using (var cmd = new SQLiteCommand(query, connection))
                using (var reader = cmd.ExecuteReader())
                {
                    pnlTables.Controls.Clear();

                    while (reader.Read())
                    {
                        // Table Data
                        string tableName = reader.GetString(1);
                        string status = reader.GetString(2);
                        string customer = reader.IsDBNull(3) ? string.Empty : reader.GetString(3);
                        bool isOpenTime = reader.GetInt32(4) == 1;
                        int durationHours = reader.IsDBNull(5) ? 0 : reader.GetInt32(5);

                        // Reservation Data
                        string resDateStr = reader.IsDBNull(6) ? string.Empty : reader.GetString(6);
                        string resCustomer = reader.IsDBNull(7) ? string.Empty : reader.GetString(7);

                        // 1. Determine Card Color
                        Color cardColor = Color.White;
                        string displayStatus = status;

                        // Handle status and glow logic
                        if (status == "Available" || status == "Reserved")
                        {
                            // Check for UPCOMING reservation glow (within 2 hours)
                            if (!string.IsNullOrEmpty(resDateStr) && DateTime.TryParse(resDateStr, out DateTime resTimeUtc))
                            {
                                // Convert UTC time from DB to Local Time for accurate comparison
                                DateTime resTimeLocal = DateTime.SpecifyKind(resTimeUtc, DateTimeKind.Utc).ToLocalTime();
                                TimeSpan timeUntilRes = resTimeLocal - DateTime.Now;

                                // Glowing condition: within 2 hours of reservation time
                                if (timeUntilRes.TotalHours <= 2 && timeUntilRes.TotalHours > 0)
                                {
                                    cardColor = Color.Yellow; // Yellow glow
                                    displayStatus = $"Reserved (Soon)";
                                }
                                else if (status == "Reserved")
                                {
                                    cardColor = Color.Khaki; // Default reserved color
                                    displayStatus = "Reserved";
                                }
                                else
                                {
                                    cardColor = Color.LightGreen; // Default available color
                                    displayStatus = "Available";
                                }

                                // Handle overdue reservation (within a 2-hour grace period)
                                if (status == "Reserved" && timeUntilRes.TotalHours < 0 && timeUntilRes.TotalHours >= -2)
                                {
                                    cardColor = Color.OrangeRed; // Warning: reservation is overdue
                                    displayStatus = $"RESERVATION DUE";
                                }
                            }
                            else if (status == "Available")
                            {
                                cardColor = Color.LightGreen; // Default available color
                            }
                        }
                        else if (status == "Occupied")
                        {
                            cardColor = Color.Salmon; // Confirmed occupied status
                        }


                        Panel card = new Panel
                        {
                            Width = 250,
                            Height = 120,
                            Margin = new Padding(10),
                            BackColor = cardColor,
                            BorderStyle = BorderStyle.FixedSingle,
                            // Pass the actual status for the click handler to determine the form to open
                            Tag = new TableData(tableName, status, resCustomer)
                        };

                        // 2. Attach Click Event Handlers
                        card.Click += TableCard_Click;
                        foreach (Control control in card.Controls)
                        {
                            control.Click += TableCard_Click;
                        }

                        // 3. Create Labels
                        Label lblTitle = new Label
                        {
                            Text = tableName,
                            Font = new Font("Segoe UI", 10F, FontStyle.Bold),
                            Location = new Point(10, 10),
                            AutoSize = true
                        };

                        Label lblStatus = new Label
                        {
                            Text = $"Status: {displayStatus}",
                            Location = new Point(10, 35),
                            AutoSize = true,
                            ForeColor = status == "Occupied" ? Color.DarkRed : Color.DarkSlateBlue
                        };

                        // Show occupied customer OR reserved customer
                        string currentCustomer = (status == "Reserved" && !string.IsNullOrEmpty(resCustomer)) ? resCustomer : customer;
                        Label lblCustomer = new Label
                        {
                            Text = string.IsNullOrEmpty(currentCustomer) ? "" : $"Customer: {currentCustomer}",
                            Location = new Point(10, 55),
                            AutoSize = true
                        };

                        // Time Info
                        string timeText = "";
                        if (isOpenTime)
                        {
                            timeText = "Open Time";
                        }
                        if (status == "Occupied" && durationHours > 0)
                        {
                            timeText += $" | Duration: {durationHours} hr(s)";
                        }
                        else if (status == "Reserved" && !string.IsNullOrEmpty(resDateStr) && DateTime.TryParse(resDateStr, out DateTime resTimeUtc))
                        {
                            // Convert UTC time from DB to Local Time for display
                            DateTime localTime = DateTime.SpecifyKind(resTimeUtc, DateTimeKind.Utc).ToLocalTime();
                            timeText = $"Res. Time: {localTime.ToShortTimeString()}";
                        }


                        Label lblTimeInfo = new Label
                        {
                            Text = timeText,
                            Location = new Point(10, 75),
                            AutoSize = true,
                            ForeColor = (status == "Occupied" || status == "Reserved") ? Color.DarkRed : Color.DarkSlateBlue
                        };

                        // 4. Add Controls to Card and Card to Panel
                        card.Controls.Add(lblTitle);
                        card.Controls.Add(lblStatus);
                        card.Controls.Add(lblCustomer);
                        card.Controls.Add(lblTimeInfo);

                        pnlTables.Controls.Add(card);
                    }
                }
            }
        }

        public struct TableData
        {
            public string Name;
            public string Status;
            public string ResCustomer;

            public TableData(string name, string status, string resCustomer = "")
            {
                Name = name;
                Status = status;
                ResCustomer = resCustomer;
            }
        }

        private void TableCard_Click(object sender, EventArgs e)
        {
            Control clickedControl = sender as Control;
            Panel card = clickedControl as Panel ?? clickedControl.Parent as Panel;

            if (card != null && card.Tag is TableData tableInfo)
            {
                string tableName = tableInfo.Name;
                string status = tableInfo.Status;

                if (status == "Available")
                {
                    StartTable startForm = new StartTable(tableName, status, _connectionString);
                    if (startForm.ShowDialog() == DialogResult.OK)
                    {
                        LoadTableCards();
                    }
                }
                else if (status == "Reserved")
                {
                    // Open the ReservedTable form
                    ReservedTable reservedForm = new ReservedTable(tableName, _connectionString);
                    if (reservedForm.ShowDialog() == DialogResult.OK)
                    {
                        LoadTableCards();
                    }
                }
                else if (status == "Occupied")
                {
                    OccupiedTable occupiedForm = new OccupiedTable(tableName, _connectionString);
                    if (occupiedForm.ShowDialog() == DialogResult.OK)
                    {
                        LoadTableCards();
                    }
                }
                else
                {
                    MessageBox.Show($"Table {tableName} is currently {status}.", "Table Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnReserve_Click(object sender, EventArgs e)
        {
            // Assuming UC_Receptionist.Designer.cs has a button named 'btnReserve' that calls this method.
            Reservation reservationForm = new Reservation(_connectionString);
            if (reservationForm.ShowDialog() == DialogResult.OK)
            {
                LoadTableCards();
            }
        }
    }
}