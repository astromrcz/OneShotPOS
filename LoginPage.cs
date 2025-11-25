using System.Data.SQLite;
namespace OneShotPOS
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
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
        //ReceptionistDashboard dash = new ReceptionistDashboard();
        //dash.Show();
        //this.Hide();

        //MainDashboard dashboard = new MainDashboard();
        //dashboard.Show();
        //this.Hide();
        private void btnLogin_Click(object sender, EventArgs e)
        {
            // 1. Get user input
            string userEmail = txtUsername.Text.Trim();
            string userPassword = txtPassword.Text;

            // 2. Define database connection string
            string connectionString = "Data Source=\"C:\\Users\\morco\\Downloads\\testDB.db\"";

            // 3. Define the SQL query to find the user by email and password, retrieving key details
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
                        // Add parameters to prevent SQL Injection
                        command.Parameters.AddWithValue("@email", userEmail);
                        command.Parameters.AddWithValue("@password", userPassword);

                        // 🌟 ExecuteReader since we need multiple columns 🌟
                        using (SQLiteDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Retrieve the data using the column index or name
                                loggedInEmployeeId = reader["EmployeeID"].ToString();
                                loggedInEmail = reader["Email"].ToString();
                                userRole = reader["Role"].ToString();
                            }
                        }
                    }
                } // Connection closes here

                if (!string.IsNullOrEmpty(userRole))
                {
                    // 4. Redirect based on role, passing the necessary data
                    if (userRole.Equals("Admin", StringComparison.OrdinalIgnoreCase))
                    {
                        // Admin Dashboard
                        // ⚠️ Ensure MainDashboard has the constructor: MainDashboard(string email, string role, string empId, string connStr)
                        MainDashboard adminDashboard = new MainDashboard(loggedInEmail, userRole, loggedInEmployeeId, connectionString);
                        adminDashboard.Show();
                        this.Hide();
                    }
                    else if (userRole.Equals("Receptionist", StringComparison.OrdinalIgnoreCase))
                    {
                        // Receptionist Dashboard (Front Desk Operations)
                        // ⚠️ Ensure ReceptionistDashboard has the constructor: ReceptionistDashboard(string email, string role, string empId, string connStr)
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
                    // 5. Invalid Credentials
                    MessageBox.Show("Invalid email or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUsername.Clear();
                    txtPassword.Clear();
                    txtUsername.Focus();
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
