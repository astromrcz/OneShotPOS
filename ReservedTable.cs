using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace OneShotPOS
{
    // NOTE: This form assumes design controls: btnStartNow, btnCancel, 
    // and labels to display reservation details (e.g., lblCustomer, lblResTime).
    public partial class ReservedTable : Form
    {
        private const string EMPLOYEE_ID = "1001"; // Placeholder
        private readonly string _tableName;
        private readonly string _connectionString;

        public ReservedTable(string tableName, string connectionString)
        {
            InitializeComponent();
            _tableName = tableName;
            _connectionString = connectionString;
            this.Text = $"Manage Reservation: {tableName}";
            this.Load += ReservedTable_Load;
        }

        private void ReservedTable_Load(object sender, EventArgs e)
        {
            // 1. Fetch Reservation Details
            string query = @"
                SELECT CustomerName, PhoneNumber, ReservationDate, DurationHours
                FROM TBL_RESERVATIONS 
                WHERE TableNumber = @name AND Status = 'Active' 
                ORDER BY ReservationDate DESC 
                LIMIT 1;";

            using (var connection = new SQLiteConnection(_connectionString))
            {
                try
                {
                    connection.Open();
                    using (var cmd = new SQLiteCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@name", _tableName);
                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string customerName = reader.GetString(0);
                                string phone = reader.IsDBNull(1) ? "N/A" : reader.GetString(1);
                                string resDateStr = reader.GetString(2);
                                int duration = reader.GetInt32(3);

                                // Convert UTC time from DB to Local Time for display
                                if (DateTime.TryParse(resDateStr, out DateTime resTimeUtc))
                                {
                                    DateTime localTime = DateTime.SpecifyKind(resTimeUtc, DateTimeKind.Utc).ToLocalTime();

                                    // Simplified display as placeholder for designer controls:
                                    MessageBox.Show(
                                        $"Reservation Details:\nTable: {_tableName}\nCustomer: {customerName}\nPhone: {phone}\nTime: {localTime.ToString("MM/dd hh:mm tt")}\nDuration: {duration} hr(s)",
                                        "Reservation Details Loaded", MessageBoxButtons.OK, MessageBoxIcon.Information
                                    );
                                }
                            }
                            else
                            {
                                MessageBox.Show($"No active reservation found for {_tableName}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                this.Close();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading reservation data: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
            }
        }

        private void btnStartNow_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Confirm starting the table now for reservation on {_tableName}?", "Start Table", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    using (var connection = new SQLiteConnection(_connectionString))
                    {
                        connection.Open();

                        // 1. Get reservation details to preserve CustomerName and DurationHours
                        string selectQuery = @"
                            SELECT CustomerName, DurationHours, ReservationID
                            FROM TBL_RESERVATIONS 
                            WHERE TableNumber = @name AND Status = 'Active' 
                            ORDER BY ReservationDate DESC 
                            LIMIT 1;";

                        string customerName = "";
                        int durationHours = 0;
                        int reservationId = 0;

                        using (var cmd = new SQLiteCommand(selectQuery, connection))
                        {
                            cmd.Parameters.AddWithValue("@name", _tableName);
                            using (var reader = cmd.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    customerName = reader.GetString(0);
                                    durationHours = reader.GetInt32(1);
                                    reservationId = reader.GetInt32(2);
                                }
                            }
                        }

                        if (durationHours > 0)
                        {
                            // 2. Update TBL_TABLES status to 'Occupied' and set start time
                            string updateTableQuery = @"
                                UPDATE TBL_TABLES
                                SET Status = 'Occupied',
                                    CustomerName = @customer,
                                    StartTime = datetime('now', 'utc'), 
                                    DurationHours = @duration,
                                    IsOpenTime = 1
                                WHERE TableName = @table AND Status = 'Reserved';";

                            using (var cmd = new SQLiteCommand(updateTableQuery, connection))
                            {
                                cmd.Parameters.AddWithValue("@customer", customerName);
                                cmd.Parameters.AddWithValue("@duration", durationHours);
                                cmd.Parameters.AddWithValue("@table", _tableName);
                                cmd.ExecuteNonQuery();
                            }

                            // 3. Update TBL_RESERVATIONS status to 'Fulfilled'
                            string updateReservationQuery = @"
                                UPDATE TBL_RESERVATIONS
                                SET Status = 'Fulfilled'
                                WHERE ReservationID = @id;";

                            using (var cmd = new SQLiteCommand(updateReservationQuery, connection))
                            {
                                cmd.Parameters.AddWithValue("@id", reservationId);
                                cmd.ExecuteNonQuery();
                            }

                            LogActivity("Table Start", $"Started {_tableName} for fulfilled reservation (Customer: {customerName}).");
                            MessageBox.Show($"{_tableName} has been successfully started.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Could not start table: Invalid reservation details found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Database error during start: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Are you sure you want to cancel the reservation for {_tableName}? The table will become Available.", "Confirm Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    using (var connection = new SQLiteConnection(_connectionString))
                    {
                        connection.Open();

                        // 1. Update TBL_TABLES status to 'Available'
                        string updateTableQuery = @"
                            UPDATE TBL_TABLES
                            SET Status = 'Available',
                                CustomerName = NULL,
                                DurationHours = 0
                            WHERE TableName = @table AND Status = 'Reserved';";

                        using (var cmd = new SQLiteCommand(updateTableQuery, connection))
                        {
                            cmd.Parameters.AddWithValue("@table", _tableName);
                            cmd.ExecuteNonQuery();
                        }

                        // 2. Update TBL_RESERVATIONS status to 'Cancelled'
                        string updateReservationQuery = @"
                            UPDATE TBL_RESERVATIONS
                            SET Status = 'Cancelled'
                            WHERE TableNumber = @table AND Status = 'Active';";

                        using (var cmd = new SQLiteCommand(updateReservationQuery, connection))
                        {
                            cmd.Parameters.AddWithValue("@table", _tableName);
                            cmd.ExecuteNonQuery();
                        }
                    }

                    LogActivity("Reservation", $"Cancelled reservation for {_tableName}.");
                    MessageBox.Show($"Reservation for {_tableName} has been cancelled. Table is now Available.", "Cancellation Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Database error during cancellation: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

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
                Console.WriteLine($"Error logging activity: {ex.Message}");
            }
        }
    }
}
