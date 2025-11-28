using SiticoneNetCoreUI;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace OneShotPOS
{
    public partial class UC_Queue : UserControl
    {
        
        private readonly string _connectionString;
        private readonly string _loggedInEmployeeID;

        // Constants for layout
        private const int ROW_HEIGHT = 60;
        private const int CARD_SPACING = 5;

        public class QueueEntry
        {
            public int QueueID { get; set; }
            public string CustomerName { get; set; }
            public int GroupSize { get; set; }
            public string PhoneNumber { get; set; }
            public DateTime TimeEntered { get; set; }
            public string Status { get; set; }
            public int EstWaitTimeMin { get; set; }
        }

        public UC_Queue(string connectionString, string employeeID)
        {
            InitializeComponent();
            _connectionString = connectionString;
            _loggedInEmployeeID = employeeID;
        }

        private void UC_Queue_Load(object sender, EventArgs e)
        {
            // Ensure scrolling works
            pnlReadySeat.AutoScroll = true;
            pnlWaitingQueue.AutoScroll = true;
            LoadQueueData();
        }

        private void btnAddQueue_Click(object sender, EventArgs e)
        {
            AddQueue add = new AddQueue();
            add.Show();
        }

        private void LoadQueueData()
        {
            if (pnlReadySeat == null || pnlWaitingQueue == null) return;

            // Clear existing controls
            pnlReadySeat.Controls.Clear();
            pnlWaitingQueue.Controls.Clear();

            List<QueueEntry> allEntries = GetQueueEntriesFromDB();

            DisplaySummaryMetrics(allEntries);
            RenderQueueLists(allEntries);
        }

        // --- 1. Mock Data ---
        private List<QueueEntry> GetQueueEntriesFromDB()
        {
            var entries = new List<QueueEntry>();

            try
            {
                using (var conn = new SQLiteConnection(_connectionString))
                {
                    conn.Open();
                    // Order by Status (so 'Ready' might separate from 'Waiting') then by Time
                    string query = "SELECT * FROM TBL_QUEUE ORDER BY Status DESC, Timestamp ASC";

                    using (var cmd = new SQLiteCommand(query, conn))
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var entry = new QueueEntry();

                            // 1. Direct Matches
                            entry.QueueID = Convert.ToInt32(reader["QueueID"]);
                            entry.CustomerName = reader["CustomerName"].ToString();
                            entry.GroupSize = Convert.ToInt32(reader["GroupSize"]);
                            entry.Status = reader["Status"].ToString();

                            // 2. Mapped Columns (DB Name -> Class Property)
                            entry.PhoneNumber = reader["ContactNumber"].ToString(); // DB is ContactNumber
                            entry.TimeEntered = Convert.ToDateTime(reader["Timestamp"]); // DB is Timestamp

                            // 3. Null Safety Check for Integer
                            // If EstimatedWait is null in DB, use 0
                            if (reader["EstimatedWait"] != DBNull.Value)
                            {
                                entry.EstWaitTimeMin = Convert.ToInt32(reader["EstimatedWait"]);
                            }
                            else
                            {
                                entry.EstWaitTimeMin = 0;
                            }

                            entries.Add(entry);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading TBL_QUEUE: " + ex.Message);
            }

            return entries;
        }

        // --- 2. Update Labels ---
        private void DisplaySummaryMetrics(List<QueueEntry> entries)
        {
            var waiting = entries.Where(e => e.Status == "Waiting").ToList();
            var ready = entries.Where(e => e.Status == "Ready").ToList();

            if (lblGroups != null) lblGroups.Text = $"{waiting.Count} groups";
            if (lblTotalCustomers != null) lblTotalCustomers.Text = $"{waiting.Sum(e => e.GroupSize)} total customers";
            if (lblWaitTime != null) lblWaitTime.Text = "13 min";
            if (lblGrpReady != null) lblGrpReady.Text = $"{ready.Count} groups";
        }

        // --- 3. Render Lists (Manually Stacked) ---
        private void RenderQueueLists(List<QueueEntry> entries)
        {
            // Track Y positions for manual stacking since SiticoneAdvancedPanel isn't a FlowLayoutPanel
            int readyY = 10;
            int waitingY = 10;

            foreach (var entry in entries)
            {
                bool isReady = (entry.Status == "Ready");

                // Cast to generic Panel base class to avoid type errors
                Panel targetPanel = isReady ? (Panel)pnlReadySeat : (Panel)pnlWaitingQueue;

                int currentY = isReady ? readyY : waitingY;

                // Create the card
                Panel card = CreateQueueCard(entry, targetPanel.Width);

                // ⚠️ MANUAL POSITIONING
                card.Location = new Point(10, currentY);

                targetPanel.Controls.Add(card);

                // Increment Y position for the next card
                if (isReady) readyY += ROW_HEIGHT + CARD_SPACING;
                else waitingY += ROW_HEIGHT + CARD_SPACING;
            }
        }

        // --- 4. Card Generator ---
        private Panel CreateQueueCard(QueueEntry entry, int containerWidth)
        {
            Panel card = new Panel
            {
                Height = ROW_HEIGHT,
                Width = containerWidth - 40,
                BackColor = (entry.Status == "Ready") ? Color.FromArgb(220, 255, 220) : Color.White,
            };

            // Left Text (Name & ID)
            Label lblMain = new Label
            {
                Text = $"#{entry.QueueID}   {entry.CustomerName}",
                Font = new Font("Segoe UI", 11F, FontStyle.Bold),
                Location = new Point(10, 8),
                AutoSize = true
            };

            // Sub Text (Details)
            TimeSpan waited = DateTime.Now - entry.TimeEntered;
            Label lblSub = new Label
            {
                Text = $"{entry.GroupSize} people  |  {entry.PhoneNumber}  |  Waiting {waited.Minutes} min",
                Font = new Font("Segoe UI", 9F),
                ForeColor = Color.Gray,
                Location = new Point(10, 32),
                AutoSize = true
            };

            // --- BUTTONS LOGIC ---
            int rightEdge = card.Width;
            int btnY = 12;

            // 1. DELETE BUTTON
            SiticoneNetCoreUI.SiticoneButton btnDelete = CreateButton("Delete", Color.Red, Color.White, 80);
            btnDelete.Location = new Point(rightEdge - 95, btnY);

            // EVENT: Delete Logic
            btnDelete.Click += (s, e) => {
                if (MessageBox.Show("Are you sure you want to remove this customer?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    DeleteQueueEntry(entry.QueueID); // Delete from DB
                    LogActivity("Queue", $"Deleted ID #{entry.QueueID}");
                    LoadQueueData(); // Refresh UI (Row will disappear)
                }
            };

            // 2. ACTION BUTTON (Mark Ready / Seat Now)
            string actionText = (entry.Status == "Ready") ? "Seat Now" : "Mark Ready";

            // VISUALS: 
            // If Waiting: Light Gray Button, Black Text.
            // If Ready: SeaGreen Button, White Text (Fixes visibility issue).
            Color btnColor = (entry.Status == "Ready") ? Color.SeaGreen : Color.FromArgb(230, 230, 230);
            Color txtColor = (entry.Status == "Ready") ? Color.White : Color.Black;

            SiticoneNetCoreUI.SiticoneButton btnAction = CreateButton(actionText, txtColor, btnColor, 110);
            btnAction.Location = new Point(rightEdge - 215, btnY);

            // EVENT: Action Logic
            btnAction.Click += (s, e) => {
                if (entry.Status == "Waiting")
                {
                    // Logic: Move to Ready Panel
                    UpdateQueueStatus(entry.QueueID, "Ready");
                    LogActivity("Queue", $"Marked Ready: {entry.CustomerName}");
                }
                else if (entry.Status == "Ready")
                {
                    // Logic: Seat Now (Remove from Queue completely)
                    if (MessageBox.Show("Seat this customer now? This will remove them from the queue.", "Seat Customer", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        DeleteQueueEntry(entry.QueueID);
                        LogActivity("Queue", $"Seated: {entry.CustomerName}");
                    }
                }

                LoadQueueData(); // Refresh UI (Card will move or disappear)
            };

            card.Controls.Add(lblMain);
            card.Controls.Add(lblSub);
            card.Controls.Add(btnAction);
            card.Controls.Add(btnDelete);

            return card;
        }

        private SiticoneNetCoreUI.SiticoneButton CreateButton(string text, Color fore, Color back, int width)
        {
            return new SiticoneNetCoreUI.SiticoneButton
            {
                Text = text,
                Size = new Size(width, 35),
                ButtonBackColor = back,
                ForeColor = fore,
                Font = new Font("Segoe UI", 9F, FontStyle.Bold),

                // Standard Rounded Corners
                CornerRadiusBottomLeft = 5,
                CornerRadiusBottomRight = 5,
                CornerRadiusTopLeft = 5,
                CornerRadiusTopRight = 5,

                // Removed BorderThickness and BorderColor to avoid errors

                Cursor = Cursors.Hand
            };
        }

        private void LogActivity(string type, string desc)
        {
            try
            {
                using (var conn = new SQLiteConnection(_connectionString))
                {
                    conn.Open();
                    using (var cmd = new SQLiteCommand("INSERT INTO TBL_ACTIVITY_LOG (Timestamp, ActivityType, Description, EmployeeID) VALUES (datetime('now'), @t, @d, @e)", conn))
                    {
                        cmd.Parameters.AddWithValue("@t", type);
                        cmd.Parameters.AddWithValue("@d", desc);
                        cmd.Parameters.AddWithValue("@e", _loggedInEmployeeID);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch { }
        }

        // 1. Method to DELETE a row (Used for 'Delete' and 'Seat Now')
        private void DeleteQueueEntry(int queueID)
        {
            try
            {
                using (var conn = new SQLiteConnection(_connectionString))
                {
                    conn.Open();
                    string query = "DELETE FROM TBL_QUEUE WHERE QueueID = @id";
                    using (var cmd = new SQLiteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", queueID);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting entry: " + ex.Message);
            }
        }

        // 2. Method to UPDATE status (Used for 'Mark Ready')
        private void UpdateQueueStatus(int queueID, string newStatus)
        {
            try
            {
                using (var conn = new SQLiteConnection(_connectionString))
                {
                    conn.Open();
                    string query = "UPDATE TBL_QUEUE SET Status = @status WHERE QueueID = @id";
                    using (var cmd = new SQLiteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@status", newStatus);
                        cmd.Parameters.AddWithValue("@id", queueID);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating status: " + ex.Message);
            }
        }


    }
}