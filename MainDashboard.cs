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
      
        private void MainDashboard_Load(object sender, EventArgs e)
        {
            panelMain.Dock = DockStyle.Fill;
            panelMain.Padding = new Padding(0);
            panelMain.Margin = new Padding(0);

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
            panelMain.Padding = new Padding(0); // Remove container padding
            panelMain.Controls.Clear();

            UC_Products products = new UC_Products();
            products.Dock = DockStyle.Fill;
            products.Margin = new Padding(0);
            products.Padding = new Padding(0);

            panelMain.Controls.Add(products);
        }

        private void btnPromotions_Click(object sender, EventArgs e)
        {
            panelMain.Padding = new Padding(0); // Remove container padding
            panelMain.Controls.Clear();

            UC_Promotions promo = new UC_Promotions();
            promo.Dock = DockStyle.Fill;
            promo.Margin = new Padding(0);
            promo.Padding = new Padding(0);

            panelMain.Controls.Add(promo);
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
            panelMain.Padding = new Padding(0); // Remove container padding
            panelMain.Controls.Clear();

            UC_Reports reports = new UC_Reports();
            reports.Dock = DockStyle.Fill;
            reports.Margin = new Padding(0);
            reports.Padding = new Padding(0);

            panelMain.Controls.Add(reports);
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
