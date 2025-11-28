using Siticone.Desktop.UI.WinForms;
using SiticoneNetCoreUI;
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
    public partial class ReceptionistDashboard : Form
    {
        private readonly string _connectionString;
        private readonly string _loggedInEmployeeId;
        public ReceptionistDashboard(string userEmail, string userRole, string employeeId, string connectionString)
        {
            InitializeComponent();
            panelMain.BringToFront();
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            _connectionString = connectionString;
            _loggedInEmployeeId = employeeId;

            // 🌟 SET LABELS HERE 🌟
            lblLoggedInUser.Text = userEmail;
            lblUserRole.Text = userRole;
        }

        private void MainDashboard_Load(object sender, EventArgs e)
        {
            panelMain.Dock = DockStyle.Fill;
            panelMain.Padding = new Padding(0);
            panelMain.Margin = new Padding(0);
            UC_Receptionist recep = new UC_Receptionist(_connectionString);
            recep.Dock = DockStyle.Fill;
            recep.Margin = new Padding(0);
            recep.Padding = new Padding(0);

            panelMain.Controls.Add(recep);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to log out?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // 1. Dispose of the current dashboard form
                this.Close();
                LoginPage loginPage = new LoginPage();
                loginPage.Show();

                
            }
        }

        private void siticoneCloseButton1_Click(object sender, EventArgs e) //logout Button
        {
            LoginPage login = new LoginPage();
            login.Show();
            this.Close();
        }

        private void btnTables_Click(object sender, EventArgs e)
        {
            panelMain.Padding = new Padding(0); // Remove container padding
            panelMain.Controls.Clear();
            UC_Receptionist recep = new UC_Receptionist(_connectionString);
            recep.Dock = DockStyle.Fill;
            recep.Margin = new Padding(0);
            recep.Padding = new Padding(0);

            panelMain.Controls.Add(recep);
        }

        private void btnQueue_Click(object sender, EventArgs e)
        {
            panelMain.Padding = new Padding(0); // Remove container padding
            panelMain.Controls.Clear();

            UC_Queue queue = new UC_Queue();
            queue.Dock = DockStyle.Fill;
            queue.Margin = new Padding(0);
            queue.Padding = new Padding(0);

            panelMain.Controls.Add(queue);
        }

        private void btnQuickSale_Click(object sender, EventArgs e)
        {

        }
    }
}
