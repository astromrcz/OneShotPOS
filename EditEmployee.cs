using Siticone.Desktop.UI.WinForms;
using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace OneShotPOS
{
    public partial class EditEmployee : Form
    {
        private int employeeId;
        private const string ConnectionString = @"Data Source=C:\Users\morco\Downloads\testDB.db;Version=3;";

        public EditEmployee(int id)
        {
            InitializeComponent();
            employeeId = id;
        }

        private void EditEmployee_Load(object sender, EventArgs e)
        {
            RoleDropDown.Items.AddRange(new[] { "Admin", "Receptionist" });
            dropStatus.Items.AddRange(new[] { "Active", "Inactive" });

            using (var conn = new SQLiteConnection(ConnectionString))
            {
                conn.Open();
                string query = "SELECT * FROM TBL_EMPLOYEES WHERE EmployeeID = @id";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", employeeId);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            txtFullName.Text = reader["Name"].ToString();
                            txtEmail.Text = reader["Email"].ToString();
                            txtContactNo.Text = reader["Phone"].ToString();
                            txtPassword.Text = reader["PasswordHash"].ToString();
                            RoleDropDown.SelectedItem = reader["Role"].ToString();
                            dropStatus.SelectedItem = Convert.ToInt32(reader["IsActive"]) == 1 ? "Active" : "Inactive";
                        }
                    }
                }
            }
        }


        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            using (var conn = new SQLiteConnection(ConnectionString))
            {
                conn.Open();

                // ✅ Update employee
                string query = @"UPDATE TBL_EMPLOYEES SET 
            Name = @name, 
            Email = @email, 
            Phone = @phone, 
            Role = @role, 
            PasswordHash = @pass, 
            IsActive = @active 
            WHERE EmployeeID = @id";

                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@name", txtFullName.Text);
                    cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@phone", txtContactNo.Text);
                    cmd.Parameters.AddWithValue("@role", RoleDropDown.SelectedItem?.ToString());
                    cmd.Parameters.AddWithValue("@pass", txtPassword.Text);
                    cmd.Parameters.AddWithValue("@active", dropStatus.SelectedItem?.ToString() == "Active" ? 1 : 0);
                    cmd.Parameters.AddWithValue("@id", employeeId);
                    cmd.ExecuteNonQuery();
                }

                // ✅ Log activity
                string logQuery = @"INSERT INTO TBL_ACTIVITY_LOG 
            (Timestamp, ActivityType, Description, EmployeeID) 
            VALUES (@time, 'Account', @desc, @actorId)";

                using (var cmdLog = new SQLiteCommand(logQuery, conn))
                {
                    cmdLog.Parameters.AddWithValue("@time", DateTime.UtcNow.ToString("yyyy-MM-dd HH:mm:ss"));
                    cmdLog.Parameters.AddWithValue("@desc", $"Updated employee account: {txtFullName.Text} ({RoleDropDown.SelectedItem})");
                    cmdLog.Parameters.AddWithValue("@actorId", LoginPage.Session.EmployeeID);
                    cmdLog.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Changes saved successfully.", "Success");
            this.DialogResult = DialogResult.OK;
            this.Close();
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
