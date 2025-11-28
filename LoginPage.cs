using System.Data.SQLite;
namespace OneShotPOS
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }
        public static class Session
        {
            public static string EmployeeID;
            public static string Email;
            public static string Role;
            public static string ConnectionString;
        }

        private void LoginPage_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;

        }

        private void siticoneTextBoxAdvanced1_TextContentChanged(object sender, EventArgs e)
        {

        }

        private void siticoneLabel1_Click(object sender, EventArgs e)
        {

        }
       
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userEmail = txtUsername.Text.Trim();
            string userPassword = txtPassword.Text;
            string dbPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", "OSDB.db");

            string connectionString = $"Data Source={dbPath}";

            string sql = "SELECT EmployeeID, Email, Role FROM TBL_EMPLOYEES WHERE Email = @email AND PasswordHash = @password;";

            string loggedInEmployeeId = string.Empty;
            string loggedInEmail = string.Empty;
            string userRole = string.Empty;

            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    using (SQLiteCommand command = new SQLiteCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@email", userEmail);
                        command.Parameters.AddWithValue("@password", userPassword);

                        using (SQLiteDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                loggedInEmployeeId = reader["EmployeeID"].ToString();
                                loggedInEmail = reader["Email"].ToString();
                                userRole = reader["Role"].ToString();
                            }
                        }
                    }

                    if (!string.IsNullOrEmpty(userRole))
                    {
                        // ✅ Store session
                        Session.EmployeeID = loggedInEmployeeId;
                        Session.Email = loggedInEmail;
                        Session.Role = userRole;
                        Session.ConnectionString = connectionString;

                        // ✅ Log login activity
                        string logQuery = @"INSERT INTO TBL_ACTIVITY_LOG 
                    (Timestamp, ActivityType, Description, EmployeeID) 
                    VALUES (@time, 'Login', @desc, @empId)";

                        using (var cmdLog = new SQLiteCommand(logQuery, connection))
                        {
                            cmdLog.Parameters.AddWithValue("@time", DateTime.UtcNow.ToString("yyyy-MM-dd HH:mm:ss"));
                            cmdLog.Parameters.AddWithValue("@desc", $"User '{loggedInEmail}' logged in as '{userRole}'");
                            cmdLog.Parameters.AddWithValue("@empId", loggedInEmployeeId);
                            cmdLog.ExecuteNonQuery();
                        }

                        // ✅ Redirect
                        if (userRole.Equals("Admin", StringComparison.OrdinalIgnoreCase))
                        {
                            MainDashboard adminDashboard = new MainDashboard(loggedInEmail, userRole, loggedInEmployeeId, connectionString);
                            adminDashboard.Show();
                            this.Hide();
                        }
                        else if (userRole.Equals("Receptionist", StringComparison.OrdinalIgnoreCase))
                        {
                            ReceptionistDashboard receptionistDashboard = new ReceptionistDashboard(loggedInEmail, userRole, loggedInEmployeeId, connectionString);
                            receptionistDashboard.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Unknown user role encountered.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid email or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtUsername.Clear();
                        txtPassword.Clear();
                        txtUsername.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred during login: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void siticoneCloseButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
