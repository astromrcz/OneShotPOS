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
        private const string ConnectionString = @"Data Source=""C:\Users\morco\Downloads\testDB.db"";Version=3;";
        private const string EMPLOYEE_ID = "1001";

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

        public UC_Queue()
        {
            InitializeComponent();
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
            // AddQueue logic here
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
            var entries = new List<QueueEntry>
            {
                new QueueEntry { QueueID = 4, CustomerName = "Diana Lopez", GroupSize = 3, PhoneNumber = "+63 917 444 5555", TimeEntered = DateTime.Now.AddMinutes(-2), Status = "Ready", EstWaitTimeMin = 0 },
                new QueueEntry { QueueID = 1, CustomerName = "Roberto Santos", GroupSize = 4, PhoneNumber = "+63 917 111 2222", TimeEntered = DateTime.Now.AddMinutes(-15), Status = "Waiting", EstWaitTimeMin = 15 },
                new QueueEntry { QueueID = 2, CustomerName = "Michelle Tan", GroupSize = 2, PhoneNumber = "+63 917 222 3333", TimeEntered = DateTime.Now.AddMinutes(-10), Status = "Waiting", EstWaitTimeMin = 10 },
                new QueueEntry { QueueID = 3, CustomerName = "Carlos Rivera", GroupSize = 6, PhoneNumber = "+63 917 333 4444", TimeEntered = DateTime.Now.AddMinutes(-5), Status = "Waiting", EstWaitTimeMin = 20 }
            };
            return entries.OrderBy(e => e.QueueID).ToList();
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
                Width = containerWidth - 40, // Allow space for scrollbar
                BackColor = (entry.Status == "Ready") ? Color.FromArgb(220, 255, 220) : Color.White,
                // BorderStyle = BorderStyle.FixedSingle // Optional: Uncomment if you want borders
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

            // Buttons (Right Aligned)
            int rightEdge = card.Width;
            int btnY = 12;

            // Delete Button
            SiticoneNetCoreUI.SiticoneButton btnDelete = CreateButton("Delete", Color.Red, Color.Transparent, 40);
            btnDelete.Location = new Point(rightEdge - 50, btnY);
            btnDelete.Click += (s, e) => { LogActivity("Queue", "Deleted"); LoadQueueData(); };

            // Action Button
            string actionText = (entry.Status == "Ready") ? "Seat Now" : "Mark Ready";
            Color btnColor = (entry.Status == "Ready") ? Color.Black : Color.White;
            Color txtColor = (entry.Status == "Ready") ? Color.White : Color.Black;

            SiticoneNetCoreUI.SiticoneButton btnAction = CreateButton(actionText, txtColor, btnColor, 100);
            btnAction.Location = new Point(rightEdge - 160, btnY);
            btnAction.Click += (s, e) => {
                LogActivity("Queue", $"Action: {actionText}");
                LoadQueueData();
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
                CornerRadiusBottomLeft = 5,
                CornerRadiusBottomRight = 5,
                CornerRadiusTopLeft = 5,
                CornerRadiusTopRight = 5,
                Cursor = Cursors.Hand
            };
        }

        private void LogActivity(string type, string desc)
        {
            try
            {
                using (var conn = new SQLiteConnection(ConnectionString))
                {
                    conn.Open();
                    using (var cmd = new SQLiteCommand("INSERT INTO TBL_ACTIVITY_LOG (Timestamp, ActivityType, Description, EmployeeID) VALUES (datetime('now'), @t, @d, @e)", conn))
                    {
                        cmd.Parameters.AddWithValue("@t", type);
                        cmd.Parameters.AddWithValue("@d", desc);
                        cmd.Parameters.AddWithValue("@e", EMPLOYEE_ID);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch { }
        }
    }
}