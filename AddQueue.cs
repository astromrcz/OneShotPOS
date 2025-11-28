using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;

namespace OneShotPOS
{
    public partial class AddQueue : Form
    {
        // Define the path to your database
        // ensuring it points to the correct Resources folder we fixed earlier
        private string _connectionString;

        public AddQueue()
        {
            InitializeComponent();

            // Set up connection string
            string dbPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", "OSDB.db");
            _connectionString = $"Data Source={dbPath};Version=3;";
        }

        private void BtnAddQueue_Click(object sender, EventArgs e)
        {
            // 1. Validation
            // We only need to check the Name. NumericUpDowns always have a valid number value.
            if (string.IsNullOrWhiteSpace(txtCustomerName.Text))
            {
                MessageBox.Show("Please enter the Customer Name.", "Missing Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Get Values
            string name = txtCustomerName.Text.Trim();
            string phone = txtPhoneNo.Text.Trim();

            // NumericUpDown.Value returns a decimal, so we cast to int
            int groupSize = (int)numGrpSize.Value;
            int estWaitMinutes = (int)numEstWait.Value;

            // Optional: Prevent 0 group size if the UI doesn't already enforce it
            if (groupSize < 1) groupSize = 1;

            try
            {
                using (var conn = new SQLiteConnection(_connectionString))
                {
                    conn.Open();

                    string query = @"
                        INSERT INTO TBL_QUEUE 
                        (CustomerName, GroupSize, ContactNumber, Status, Timestamp, EstimatedWait) 
                        VALUES 
                        (@name, @size, @contact, 'Waiting', datetime('now', 'localtime'), @wait)";

                    using (var cmd = new SQLiteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@name", name);
                        cmd.Parameters.AddWithValue("@size", groupSize);
                        cmd.Parameters.AddWithValue("@contact", phone);
                        // Store wait time as plain integer (minutes)
                        cmd.Parameters.AddWithValue("@wait", estWaitMinutes);

                        cmd.ExecuteNonQuery();
                    }
                }

                // 3. Success & Close
                MessageBox.Show("Customer added to queue successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Set DialogResult so the parent form knows to refresh the list
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding to queue: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    

private void AddQueue_Load(object sender, EventArgs e)
        {

        }
    }
}
