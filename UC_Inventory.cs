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
    public partial class UC_Inventory : UserControl
    {
        public UC_Inventory()
        {
            InitializeComponent();
        }

        private void UC_Inventory_Load(object sender, EventArgs e)
        {
            SiticoneDataGridView dgvInventory = new SiticoneDataGridView();
            dgvInventory.Dock = DockStyle.Fill;
            dgvInventory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvInventory.RowTemplate.Height = 40;
            dgvInventory.AllowUserToAddRows = false;
            dgvInventory.AllowUserToResizeRows = false;
            dgvInventory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgvInventory.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;

            dgvInventory.Columns.Add("ItemName", "Item Name");
            dgvInventory.Columns.Add("Category", "Category");
            dgvInventory.Columns.Add("Quantity", "Quantity");
            dgvInventory.Columns.Add("MinStock", "Min Stock");
            dgvInventory.Columns.Add("CostPrice", "Cost Price");
            dgvInventory.Columns.Add("Status", "Status");
            dgvInventory.Columns.Add("Supplier", "Supplier");

            // Action column with buttons
            DataGridViewButtonColumn editBtn = new DataGridViewButtonColumn();
            editBtn.Name = "Edit";
            editBtn.Text = "✎";
            editBtn.UseColumnTextForButtonValue = true;

            DataGridViewButtonColumn deleteBtn = new DataGridViewButtonColumn();
            deleteBtn.Name = "Delete";
            deleteBtn.Text = "🗑";
            deleteBtn.UseColumnTextForButtonValue = true;

            dgvInventory.Columns.Add(editBtn);
            dgvInventory.Columns.Add(deleteBtn);

            dgvInventory.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(0, 120, 215);
            dgvInventory.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgvInventory.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvInventory.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgvInventory.ThemeStyle.RowsStyle.ForeColor = Color.Black;
            dgvInventory.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9);

            // 🔑 Add to your panel instead of the UserControl
            InventoryPanel.Controls.Clear(); // optional: clears old controls
            InventoryPanel.Controls.Add(dgvInventory);

            

        }
       




    }
}
