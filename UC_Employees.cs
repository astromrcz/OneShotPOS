using Siticone.Desktop.UI.WinForms;
using System;
using System.Data.SQLite;
using System.Drawing;
using System.Windows.Forms;

namespace OneShotPOS
{
    public partial class UC_Employees : UserControl
    {
        private const string ConnectionString = @"Data Source=C:\Users\morco\Downloads\testDB.db;Version=3;";

        public UC_Employees()
        {
            InitializeComponent();
        }

        private void UC_Employees_Load(object sender, EventArgs e)
        {
            LoadEmployees();
            PopulateEmployeeStats();
        }

        private void LoadEmployees()
        {
            pnlEmployees.Controls.Clear();

            using (var conn = new SQLiteConnection(ConnectionString))
            {
                conn.Open();
                string query = "SELECT EmployeeID, Name, Email, Phone, Role, IsActive FROM TBL_EMPLOYEES";

                using (var cmd = new SQLiteCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        bool isActive = Convert.ToInt32(reader["IsActive"]) == 1;
                        int employeeId = Convert.ToInt32(reader["EmployeeID"]);

                        var card = new Panel
                        {
                            Width = 300,
                            Height = 140,
                            Margin = new Padding(5),
                            BackColor = isActive ? Color.White : Color.LightGray,
                            BorderStyle = BorderStyle.FixedSingle
                        };

                        var lblName = new Label { Text = reader["Name"].ToString(), Font = new Font("Segoe UI", 10, FontStyle.Bold), Dock = DockStyle.Top };
                        var lblRole = new Label { Text = $"Role: {reader["Role"]}", Dock = DockStyle.Top };
                        var lblEmail = new Label { Text = $"Email: {reader["Email"]}", Dock = DockStyle.Top };
                        var lblPhone = new Label { Text = $"Phone: {reader["Phone"]}", Dock = DockStyle.Top };
                        var lblStatus = new Label
                        {
                            Text = $"Status: {(isActive ? "Active" : "Inactive")}",
                            ForeColor = isActive ? Color.Green : Color.Red,
                            Dock = DockStyle.Top
                        };

                        var btnEdit = new SiticoneButton
                        {
                            Text = "Edit",
                            Size = new Size(60, 25),
                            Location = new Point(10, 110),
                            Tag = employeeId
                        };
                        btnEdit.Click += (s, e) => OpenEditForm(employeeId);

                        var btnDelete = new SiticoneButton
                        {
                            Text = "Delete",
                            Size = new Size(60, 25),
                            Location = new Point(80, 110),
                            Tag = employeeId
                        };
                        btnDelete.Click += (s, e) => DeleteEmployee(employeeId);

                        card.Controls.Add(lblStatus);
                        card.Controls.Add(lblPhone);
                        card.Controls.Add(lblEmail);
                        card.Controls.Add(lblRole);
                        card.Controls.Add(lblName);
                        card.Controls.Add(btnEdit);
                        card.Controls.Add(btnDelete);

                        pnlEmployees.Controls.Add(card);
                    }
                }
            }
        }


        private void OpenEditForm(int employeeId)
        {
            EditEmployee editForm = new EditEmployee(employeeId);
            if (editForm.ShowDialog() == DialogResult.OK)
            {
                LoadEmployees();
            }
        }

        private void DeleteEmployee(int employeeId)
        {
            var confirm = MessageBox.Show("Are you sure you want to delete this employee?", "Confirm", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                using (var conn = new SQLiteConnection(ConnectionString))
                {
                    conn.Open();
                    string query = "UPDATE TBL_EMPLOYEES SET IsActive = 0 WHERE EmployeeID = @id";
                    using (var cmd = new SQLiteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", employeeId);
                        cmd.ExecuteNonQuery();
                    }
                }
                LoadEmployees();
            }
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            AddEmployee add = new AddEmployee();
            add.Show();
        }
        private void PopulateEmployeeStats()
        {
            int totalActive = 0;
            int activeAdmins = 0;
            int activeReceptionists = 0;

            using (var conn = new SQLiteConnection(ConnectionString))
            {
                conn.Open();
                string query = "SELECT Role, IsActive FROM TBL_EMPLOYEES";

                using (var cmd = new SQLiteCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        bool isActive = Convert.ToInt32(reader["IsActive"]) == 1;
                        string role = reader["Role"].ToString();

                        if (isActive)
                        {
                            totalActive++;
                            if (role == "Admin") activeAdmins++;
                            else if (role == "Receptionist") activeReceptionists++;
                        }
                    }
                }
            }

            lblActiveEmployees.Text = totalActive.ToString();
            lblActiveAdmins.Text = activeAdmins.ToString();
            lblActiveReceptionist.Text = activeReceptionists.ToString();
        }

    }
}
