using Siticone.Desktop.UI.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OneShotPOS
{
    public partial class MainDashboard : Form
    {
        private readonly string _connectionString;
        private readonly string _loggedInEmployeeId;
        public MainDashboard(string userEmail, string userRole, string employeeId, string connectionString)
        {
            InitializeComponent();
            panelMain.BringToFront();
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            _connectionString = connectionString;
            _loggedInEmployeeId = employeeId;
            lblLoggedInUser.Text = userEmail;
            lblUserRole.Text = userRole;
        }
      
        private void MainDashboard_Load(object sender, EventArgs e)
        {
            panelMain.Dock = DockStyle.Fill;
            panelMain.Padding = new Padding(0);
            panelMain.Margin = new Padding(0);

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to log out?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // 1. Dispose of the current dashboard form
                this.Close();

                // 2. Open the login page back up
                LoginPage loginPage = new LoginPage();
                loginPage.Show();

                // Note: The main application loop (Application.Run) continues, 
                // allowing background database processes to finish cleanly.
            }
        }

        private void siticoneCloseButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        private void btnOverview_Click_1(object sender, EventArgs e)
        {
            panelMain.Padding = new Padding(0); // Remove container padding
            panelMain.Controls.Clear();

            UC_Overview overview = new UC_Overview();
            overview.Dock = DockStyle.Fill;
            overview.Margin = new Padding(0);
            overview.Padding = new Padding(0);

            panelMain.Controls.Add(overview);
        }

        

        private void btnProducts_Click(object sender, EventArgs e)
        {
            panelMain.Padding = new Padding(0); // Remove container padding
            panelMain.Controls.Clear();

            UC_Inventory inventory = new UC_Inventory();
            inventory.Dock = DockStyle.Fill;
            inventory.Margin = new Padding(0);
            inventory.Padding = new Padding(0);

            panelMain.Controls.Add(inventory);
        }

        private void btnPromotions_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSalesHistory_Click(object sender, EventArgs e)
        {
            panelMain.Padding = new Padding(0); // Remove container padding
            panelMain.Controls.Clear();

            UC_SalesHistory sales = new UC_SalesHistory();
            sales.Dock = DockStyle.Fill;
            sales.Margin = new Padding(0);
            sales.Padding = new Padding(0);

            panelMain.Controls.Add(sales);
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            
        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            panelMain.Padding = new Padding(0); // Remove container padding
            panelMain.Controls.Clear();

            UC_Employees employee = new UC_Employees();
            employee.Dock = DockStyle.Fill;
            employee.Margin = new Padding(0);
            employee.Padding = new Padding(0);

            panelMain.Controls.Add(employee);
        }

        private void btnActivityLog_Click(object sender, EventArgs e)
        {
            panelMain.Padding = new Padding(0); // Remove container padding
            panelMain.Controls.Clear();

            UC_ActivityLog activity = new UC_ActivityLog();
            activity.Dock = DockStyle.Fill;
            activity.Margin = new Padding(0);
            activity.Padding = new Padding(0);

            panelMain.Controls.Add(activity);
        }
    }
}
