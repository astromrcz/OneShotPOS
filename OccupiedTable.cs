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
    public partial class OccupiedTable : Form
    {
        private const decimal HOURLY_RATE = 250.00m; // P45.00 per hour
        private const string EMPLOYEE_ID = "1001"; // ⚠️ PLACEHOLDER: Replace with actual logged-in user ID

        private readonly string _tableName;
        private readonly string _connectionString;
        private readonly System.Windows.Forms.Timer _billRefreshTimer;

        // Variables to store current data for use in transactions
        private decimal _currentTotalBill = 0.00m;
        private string _currentStartTimeText = string.Empty;


        public OccupiedTable(string tableName, string connectionString)
        {
            InitializeComponent();
            _tableName = tableName;
            _connectionString = connectionString;

            this.Text = $"Manage Table: {tableName}";

            this.Load += OccupiedTable_Load;

            _billRefreshTimer = new System.Windows.Forms.Timer();
            _billRefreshTimer.Interval = 60000; // 60 seconds (1 minute)
            _billRefreshTimer.Tick += BillRefreshTimer_Tick;
            _billRefreshTimer.Start();
        }

        private void OccupiedTable_Load(object sender, EventArgs e)
        {
            LoadCurrentTableData();
        }

        private void BillRefreshTimer_Tick(object sender, EventArgs e)
        {
            LoadCurrentTableData();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            _billRefreshTimer.Stop();
            _billRefreshTimer.Dispose();
            base.OnClosing(e);
        }

        // --------------------------------------------------------------------
        // 1. DATA LOAD AND CALCULATION
        // --------------------------------------------------------------------

        private void LoadCurrentTableData()
        {
            lblTblNumber.Text = _tableName;

            using (var connection = new SQLiteConnection(_connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT StartTime, CustomerName, DurationHours, Status FROM TBL_TABLES WHERE TableName = @name;";

                    using (var cmd = new SQLiteCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@name", _tableName);
                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Safe data extraction using ordinal index 
                                _currentStartTimeText = reader.IsDBNull(0) ? string.Empty : reader.GetString(0);
                                string customerName = reader.IsDBNull(1) ? "No Customer Name" : reader.GetString(1);
                                int duration = reader.IsDBNull(2) ? 0 : reader.GetInt32(2);
                                string status = reader.IsDBNull(3) ? "N/A" : reader.GetString(3);

                                lblAvailability.Text = $"{status} | Customer: {customerName}";

                                CalculateAndDisplayBill(_currentStartTimeText, duration);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading table data: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void CalculateAndDisplayBill(string startTimeText, int durationHours)
        {
            // Clear previous bill summary controls
            pnlCurrentBill.Controls.Clear();

            // 1. Robustly Parse and Convert Start Time
            if (string.IsNullOrEmpty(startTimeText) || !DateTime.TryParse(startTimeText, out DateTime startTimeUtc))
            {
                lblElapsedTime.Text = "Elapsed Time: N/A";
                pnlCurrentBill.Controls.Add(new Label { Text = "Cannot calculate bill: Start Time missing.", Location = new Point(10, 10), AutoSize = true, ForeColor = Color.Red });
                _currentTotalBill = 0.00m; // Reset bill if data is bad
                return;
            }

            // 2. FIX: Convert the read database time (which we assume is UTC) to Local Time.
            // This synchronizes it with DateTime.Now, correcting the 8-hour offset.
            DateTime startTimeLocal = DateTime.SpecifyKind(startTimeUtc, DateTimeKind.Utc).ToLocalTime();

            // 3. Calculate Elapsed Time based on Local Times
            TimeSpan elapsed = DateTime.Now - startTimeLocal; // DateTime.Now is always Local

            // Safety check: Ensure elapsed time is not negative (can happen if clock is slightly off or a second passes)
            if (elapsed.TotalSeconds < 0) elapsed = TimeSpan.Zero;

            // 4. Update Elapsed Time Display
            lblElapsedTime.Text = $"Elapsed Time: {elapsed.Hours}h {elapsed.Minutes}m {elapsed.Seconds}s";

            // 5. Calculate Billing
            double hoursCharged = Math.Ceiling(elapsed.TotalHours);
            _currentTotalBill = (decimal)hoursCharged * HOURLY_RATE; // Store the calculated bill

            // Update the form title with the total bill
            this.Text = $"Manage Table: {_tableName} | Bill: {_currentTotalBill:C}";

            // 6. Create Bill Summary Display
            Label lblBillSummaryContent = new Label
            {
                Name = "lblBillSummaryContent",
                Text = $"Bill Summary for {_tableName}\n" +
                        $"-----------------------------------\n" +
                        // Use the converted Local Time for display
                        $"Start Time: {startTimeLocal.ToShortTimeString()}\n" +
                        $"Duration Reserved: {durationHours} hour(s)\n" +
                        $"Rate: {HOURLY_RATE:C} per hour\n" +
                        $"Time Charged: {hoursCharged} full hour(s)\n" +
                        $"Total Due: {_currentTotalBill:C}",

                Font = new Font("Segoe UI", 10F, FontStyle.Regular),
                Location = new Point(10, 10),
                AutoSize = true
            };

            pnlCurrentBill.Controls.Add(lblBillSummaryContent);
        }

        // --------------------------------------------------------------------
        // 2. ACTIVITY LOG HELPER
        // --------------------------------------------------------------------

        private void LogActivity(string activityType, string description)
        {
            try
            {
                using (var connection = new SQLiteConnection(_connectionString))
                {
                    connection.Open();
                    string insertQuery = @"
                        INSERT INTO TBL_ACTIVITY_LOG (Timestamp, ActivityType, Description, EmployeeID)
                        VALUES (datetime('now'), @type, @desc, @empId);";

                    using (var cmd = new SQLiteCommand(insertQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@type", activityType);
                        cmd.Parameters.AddWithValue("@desc", description);
                        cmd.Parameters.AddWithValue("@empId", EMPLOYEE_ID);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                // Log activity errors should not crash the main operation
                Console.WriteLine($"Error logging activity: {ex.Message}");
            }
        }


        // --------------------------------------------------------------------
        // 3. BUTTON LOGIC
        // --------------------------------------------------------------------

        private void btnExtend_Click(object sender, EventArgs e)
        {
            int extensionMinutes = (int)numMin.Value;

            if (extensionMinutes <= 0)
            {
                MessageBox.Show("Please enter a valid number of minutes to extend.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show($"Are you sure you want to extend {_tableName} by {extensionMinutes} minutes?",
                                "Confirm Extension", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    using (var connection = new SQLiteConnection(_connectionString))
                    {
                        connection.Open();
                        // This logic extends the total time *paid* for by moving the StartTime backward.
                        string updateQuery = @"
                            UPDATE TBL_TABLES
                            SET StartTime = datetime(StartTime, '-' || @minutes || ' minutes')
                            WHERE TableName = @name;";

                        using (var cmd = new SQLiteCommand(updateQuery, connection))
                        {
                            cmd.Parameters.AddWithValue("@minutes", extensionMinutes);
                            cmd.Parameters.AddWithValue("@name", _tableName);
                            cmd.ExecuteNonQuery();
                        }
                    }

                    // 🎯 LOG THE EXTENSION ACTIVITY
                    LogActivity("Time Extension", $"Table {_tableName} time extended by {extensionMinutes} minutes.");

                    MessageBox.Show($"{_tableName} successfully extended by {extensionMinutes} minutes. Queue will be notified.", "Extension Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadCurrentTableData();
                    numMin.Value = 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error extending table time: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnEndTable_Click(object sender, EventArgs e)
        {
            // The final bill is calculated and stored in _currentTotalBill
            if (_currentTotalBill <= 0)
            {
                MessageBox.Show("Cannot close table: Bill amount is zero or invalid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // ⚠️ PLACEHOLDER: In a real app, this step would be a payment screen
            string paymentMethod = "Cash";
            string transactionId = $"TRX_{DateTime.Now.Ticks}";

            // Get confirmation with the FINAL calculated bill
            if (MessageBox.Show($"Confirm closing {_tableName}? Final Bill: {_currentTotalBill:C}\n(Payment Method: {paymentMethod})",
                                "Confirm End & Pay", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    // Use a single connection for the transaction and table reset
                    using (var connection = new SQLiteConnection(_connectionString))
                    {
                        connection.Open();

                        // 1. 🎯 INSERT INTO TBL_TRANSACTIONS
                        string insertTransQuery = @"
                            INSERT INTO TBL_TRANSACTIONS (TransactionID, TransactionDate, TotalAmount, TotalDiscount, PaymentMethod, ServedByEmployeeID, TableNumber)
                            VALUES (@id, datetime('now'), @amount, @discount, @method, @empId, @tableNum);";

                        using (var cmd = new SQLiteCommand(insertTransQuery, connection))
                        {
                            cmd.Parameters.AddWithValue("@id", transactionId);
                            cmd.Parameters.AddWithValue("@amount", _currentTotalBill);
                            cmd.Parameters.AddWithValue("@discount", 0.00m);
                            cmd.Parameters.AddWithValue("@method", paymentMethod);
                            cmd.Parameters.AddWithValue("@empId", EMPLOYEE_ID);
                            cmd.Parameters.AddWithValue("@tableNum", _tableName); // Assuming TableNumber stores the TableName string
                            cmd.ExecuteNonQuery();
                        }

                        // 2. 🎯 RESET TBL_TABLES STATUS
                        // OccupiedTable.cs -> btnEndTable_Click -> updateTableQuery
                        string updateTableQuery = @"
    UPDATE TBL_TABLES
    SET Status = 'Available',
        CustomerName = NULL,
        StartTime = NULL,    
        IsOpenTime = 0,
        DurationHours = 0,
        Notes = NULL
    WHERE TableName = @name;";

                        using (var cmd = new SQLiteCommand(updateTableQuery, connection))
                        {
                            cmd.Parameters.AddWithValue("@name", _tableName);
                            cmd.ExecuteNonQuery();
                        }
                    } // Connection closes here

                    // 3. 🎯 LOG THE TRANSACTION AND TABLE RESET ACTIVITY
                    string logDesc = $"Table {_tableName} closed and transaction {transactionId} processed for {_currentTotalBill:C}.";
                    LogActivity("Table Checkout", logDesc);

                    MessageBox.Show($"Checkout complete! {_tableName} is now Available. Total Paid: {_currentTotalBill:C}", "Checkout Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Signal success to UC_Receptionist to refresh the table cards
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Fatal error during checkout: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}