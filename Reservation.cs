using SiticoneNetCoreUI;
using System;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Windows.Forms;

namespace OneShotPOS
{
    // NOTE: This form assumes design controls: dropTables (SiticoneDropdown), 
    // txtCustomerName (SiticoneTextBox), txtPhoneNum (SiticoneTextBox), 
    // dtpReservation (SiticoneDateTimePicker), and btnCreateReservation (SiticoneButton).
    public partial class Reservation : Form
    {
        private const string EMPLOYEE_ID = "1001"; // Placeholder for logged-in user
        private readonly string _connectionString;

        public Reservation(string connectionString)
        {
            InitializeComponent();
            _connectionString = connectionString;
            this.Load += Reservation_Load;
            // Assuming btnCreateReservation.Click is linked to btnCreateReservation_Click
        }

        private void Reservation_Load(object sender, EventArgs e)
        {
            LoadAvailableTables();
            // Set default reservation time to 1 hour from now
            // Ensure dtpReservation is a SiticoneDateTimePicker for this line to work.
            // dtpReservation.Value = DateTime.Now.AddHours(1); 
        }

        private void LoadAvailableTables()
        {
            // dropTables.Items.Clear(); // Use this if dropTables is a standard ComboBox
            // If dropTables is SiticoneDropdown, ensure its DataSource is set correctly, 
            // but for simplicity, we'll assume it handles direct item insertion or is a standard control.

            // Example of loading table names for a hypothetical dropTables control

            try
            {
                using (var connection = new SQLiteConnection(_connectionString))
                {
                    connection.Open();
                    // Fetch tables that are currently Available or Reserved (allowing them to be reserved again or double-booked with warning later)
                    string query = "SELECT TableName FROM TBL_TABLES WHERE Status = 'Available' OR Status = 'Reserved' ORDER BY TableID;";

                    using (var cmd = new SQLiteCommand(query, connection))
                    using (var reader = cmd.ExecuteReader())
                    {
                        // Add table names to the dropdown (assuming dropTables is a custom/standard dropdown)
                        // dropTables.Items.Clear(); 
                        while (reader.Read())
                        {
                            // dropTables.Items.Add(reader.GetString(0));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading tables: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCreateReservation_Click(object sender, EventArgs e)
        {
            // if (dropTables.SelectedItem == null) return; // Uncomment with real control
            // if (string.IsNullOrWhiteSpace(txtCustomerName.Text)) return; // Uncomment with real control
            // if (dtpReservation.Value < DateTime.Now) return; // Uncomment with real control

            string table = "Table 1"; // Placeholder if dropdown not implemented
            string customer = "Test Customer"; // Placeholder if textbox not implemented
            string phone = "09170000000"; // Placeholder
            DateTime resTime = DateTime.Now.AddHours(1); // Placeholder
            int durationHours = 1;

            // Store time in UTC to avoid local time zone issues when reading later (consistent with other code)
            string reservationTimeUtc = resTime.ToUniversalTime().ToString("yyyy-MM-dd HH:mm:ss");

            try
            {
                using (var connection = new SQLiteConnection(_connectionString))
                {
                    connection.Open();

                    // 1. Update TBL_TABLES status to 'Reserved'
                    string updateTableQuery = @"
                        UPDATE TBL_TABLES
                        SET Status = 'Reserved',
                            CustomerName = @customer,
                            DurationHours = @duration
                        WHERE TableName = @table AND Status = 'Available';";

                    using (var cmd = new SQLiteCommand(updateTableQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@customer", customer);
                        cmd.Parameters.AddWithValue("@duration", durationHours);
                        cmd.Parameters.AddWithValue("@table", table);
                        cmd.ExecuteNonQuery();
                    }

                    // 2. Insert into TBL_RESERVATIONS
                    string insertQuery = @"
                        INSERT INTO TBL_RESERVATIONS (
                            TableNumber, CustomerName, PhoneNumber, ReservationDate, DurationHours, CreatedByEmployeeID
                        ) 
                        VALUES (
                            @table, @customer, @phone, @date, @duration, @empId
                        );";

                    using (var cmd = new SQLiteCommand(insertQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@table", table);
                        cmd.Parameters.AddWithValue("@customer", customer);
                        cmd.Parameters.AddWithValue("@phone", phone);
                        cmd.Parameters.AddWithValue("@date", reservationTimeUtc);
                        cmd.Parameters.AddWithValue("@duration", durationHours);
                        cmd.Parameters.AddWithValue("@empId", EMPLOYEE_ID);
                        cmd.ExecuteNonQuery();
                    }
                }

                LogActivity("Reservation", $"Table {table} reserved by {customer} for {resTime.ToShortTimeString()}.");
                MessageBox.Show($"Reservation for {table} successfully created!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Database error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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