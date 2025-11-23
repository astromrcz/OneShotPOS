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

        private void btnLogin_Click(object sender, EventArgs e)
        {

            MainDashboard dashboard = new MainDashboard();
            dashboard.Show();
            this.Hide();
            /* 1. Get user input
            string userEmail = txtUsername.Text;
            string userPassword = txtPassword.Text; // NOTE: Password is currently plain text '123' in the DB

            // 2. Define database connection string
            // IMPORTANT: Replace "Data Source=testDB.db;" with the actual path to your SQLite file.
            string connectionString = "Data Source=\"C:\\Users\\morco\\Downloads\\testDB.db\"";

            // 3. Define the SQL query to find the user by email and password
            string sql = "SELECT Role FROM TBL_EMPLOYEES WHERE Email = @email AND PasswordHash = @password;";

            // Use try-catch for error handling
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

                        // Execute the query and retrieve a single value (the role)
                        object result = command.ExecuteScalar();

                        if (result != null)
                        {
                            string userRole = result.ToString();

                            // 4. Redirect based on role
                            if (userRole.Equals("Admin", StringComparison.OrdinalIgnoreCase))
                            {
                                // Admin Dashboard
                                MainDashboard adminDashboard = new MainDashboard();
                                adminDashboard.Show();
                                this.Hide();
                            }
                            else if (userRole.Equals("Receptionist", StringComparison.OrdinalIgnoreCase))
                            {
                                // Receptionist Dashboard (Front Desk Operations)
                                ReceptionistDashboard receptionistDashboard = new ReceptionistDashboard();
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
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred during login: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/
        }
    }
}
