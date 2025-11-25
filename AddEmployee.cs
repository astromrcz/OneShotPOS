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
    public partial class AddEmployee : Form
    {
        public AddEmployee()
        {
            InitializeComponent();
        }
        private const string ConnectionString = @"Data Source=""C:\Users\morco\Downloads\testDB.db"";Version=3;";

        private void AddEmployee_Load(object sender, EventArgs e)
        {
            cbRoles.Items.Clear();

            using (var conn = new SQLiteConnection(ConnectionString))
            {
                conn.Open();
                string query = "SELECT DISTINCT Role FROM TBL_EMPLOYEES WHERE Role IS NOT NULL";

                using (var cmd = new SQLiteCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        cbRoles.Items.Add(reader["Role"].ToString());
                    }
                }
            }
        }

        private void siticoneCloseButton1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            string name = txtFullName.Text.Trim();
            string email = txtEmail.Text.Trim();
            string phone = txtContactNo.Text.Trim();
            string role = cbRoles.SelectedItem?.ToString();
            string password = txtPassword.Text;

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(phone) || string.IsNullOrWhiteSpace(role) ||
                string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please fill out all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var conn = new SQLiteConnection(ConnectionString))
            {
                conn.Open();

                // Insert into TBL_EMPLOYEES
                string insertQuery = @"
        INSERT INTO TBL_EMPLOYEES (Name, Email, Phone, Role, PasswordHash, IsActive, HiredDate)
        VALUES (@name, @email, @phone, @role, @pass, 1, @date)";

                using (var cmd = new SQLiteCommand(insertQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@phone", phone);
                    cmd.Parameters.AddWithValue("@role", role);
                    cmd.Parameters.AddWithValue("@pass", password);
                    cmd.Parameters.AddWithValue("@date", DateTime.UtcNow.ToString("yyyy-MM-dd"));
                    cmd.ExecuteNonQuery();
                }

                // Log to TBL_ACTIVITY_LOG
                string logQuery = @"
        INSERT INTO TBL_ACTIVITY_LOG (Timestamp, ActivityType, Description, EmployeeID)
        VALUES (@time, 'Account', @desc, @empId)";

                using (var cmdLog = new SQLiteCommand(logQuery, conn))
                {
                    cmdLog.Parameters.AddWithValue("@time", DateTime.UtcNow.ToString("yyyy-MM-dd HH:mm:ss"));
                    cmdLog.Parameters.AddWithValue("@desc", $"Created new employee account: {name} ({role})");
                    cmdLog.Parameters.AddWithValue("@empId", LoginPage.Session.EmployeeID); // Logged-in user
                    cmdLog.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Account created successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
