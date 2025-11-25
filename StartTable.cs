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
    public partial class StartTable : Form
    {
        private const string EMPLOYEE_ID = "1001"; // ⚠️ PLACEHOLDER: Replace with actual logged-in user ID

        private readonly string _tableName;
        private readonly string _connectionString;

        // Assuming controls: lblTblNumber, lblAvailability, txtCustomerName, numHours, btnStartTable

        public StartTable(string tableName, string status, string connectionString)
        {
            InitializeComponent();
            _tableName = tableName;
            _connectionString = connectionString;

            // Set the labels on the StartTable form
            lblTblNumber.Text = tableName;
            lblAvailability.Text = status;

            // Connect the Save button's click event
           
        }

        // --------------------------------------------------------------------
        // ACTIVITY LOG HELPER METHOD
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
                // Display error but allow the main operation to proceed
                MessageBox.Show($"Error logging activity: {ex.Message}", "Logging Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void BtnStartTable_Click(object sender, EventArgs e)
        {
            string customerName = txtCustomerName.Text.Trim();
            int durationHours = (int)numHours.Value;

            // 1. Validation Check: Ensure duration is greater than zero
            if (durationHours <= 0)
            {
                MessageBox.Show("Please set a valid duration (must be greater than 0 hours) for the table.", "Duration Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                numHours.Focus();
                return;
            }

            // 2. Update TBL_TABLES
            try
            {
                using (var connection = new SQLiteConnection(_connectionString))
                {
                    connection.Open();
                    string updateQuery = @"
    UPDATE TBL_TABLES 
    SET Status = 'Occupied', 
        CustomerName = @customer,
        StartTime = datetime('now', 'utc'), 
        DurationHours = @duration,
        IsOpenTime = 1
    WHERE TableName = @name;";

                    using (var cmd = new SQLiteCommand(updateQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@customer", customerName);
                        cmd.Parameters.AddWithValue("@name", _tableName);
                        cmd.Parameters.AddWithValue("@duration", durationHours);
                        cmd.ExecuteNonQuery();
                    }

                    // 3. 🎯 LOG THE ACTIVITY
                    string logDescription = string.IsNullOrEmpty(customerName)
                        ? $"Started {_tableName} (No Customer) for {durationHours}h."
                        : $"Started {_tableName} for Customer '{customerName}' for {durationHours}h.";

                    LogActivity("Table Start", logDescription);


                    // 4. Success Feedback and Close
                    string successMessage = string.IsNullOrEmpty(customerName)
                        ? $"{_tableName} has been opened for {durationHours} hour(s)."
                        : $"{_tableName} has been opened for {customerName} for {durationHours} hour(s).";

                    MessageBox.Show(successMessage, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Database error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}