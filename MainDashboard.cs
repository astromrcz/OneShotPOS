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
        public MainDashboard()
        {
            InitializeComponent();
            panelMain.BringToFront();
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;

        }
        private void ResetSidebarButtonStyles()
        {
            foreach (Control c in panelSidebar.Controls)
            {
                if (c is SiticoneButton b)
                {
                    b.FillColor = Color.Transparent;
                    b.ForeColor = Color.White;
                }
            }
        }
        private void ActivateSidebarButton(SiticoneButton active)
        {
            ResetSidebarButtonStyles();
            active.FillColor = Color.FromArgb(255, 30, 30, 30); // dark gray
            active.ForeColor = Color.White;
        }

        private void MainDashboard_Load(object sender, EventArgs e)
        {
            panelMain.Dock = DockStyle.Fill;
            panelMain.Padding = new Padding(0);
            panelMain.Margin = new Padding(0);

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Application.Exit();

            /* LoginPage login = new LoginPage();
             login.Show();
             this.Close();*/
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

        private void btnInventory_Click(object sender, EventArgs e)
        {
            panelMain.Padding = new Padding(0); // Remove container padding
            panelMain.Controls.Clear();

            UC_Inventory inventory = new UC_Inventory();
            inventory.Dock = DockStyle.Fill;
            inventory.Margin = new Padding(0);
            inventory.Padding = new Padding(0);

            panelMain.Controls.Add(inventory);
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {

        }
    }
}
