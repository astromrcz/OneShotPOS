using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OneShotPOS
{
    public partial class UC_Inventory : UserControl
    {
        private const string ConnectionString = @"Data Source=""C:\Users\morco\Downloads\testDB.db"";Version=3;";
        public UC_Inventory()
        {
            InitializeComponent();
        }


        private void UC_Inventory_Load(object sender, EventArgs e)
        {
            LoadInventoryAlerts();
            LoadProductsGrid();
            LoadInventoryGrid();
         

        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            AddProduct product = new AddProduct();
            product.Show();
        }
        private void LoadInventoryAlerts()
        {
            try
            {
                using (var connection = new SQLiteConnection(ConnectionString))
                {
                    connection.Open();

                    int lowStockThreshold = 5;

                    // Inventory-only alerts
                    string inventoryQuery = @"
                SELECT
                    SUM(CASE WHEN Quantity < @LowStockThreshold THEN 1 ELSE 0 END) AS LowStockItems,
                    SUM(CASE WHEN Quantity < MinStock THEN 1 ELSE 0 END) AS RequireReorderItems
                FROM TBL_INVENTORY;";

                    using (var inventoryCmd = new SQLiteCommand(inventoryQuery, connection))
                    {
                        inventoryCmd.Parameters.AddWithValue("@LowStockThreshold", lowStockThreshold);

                        using (var reader = inventoryCmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                int lowStockItem = reader["LowStockItems"] is DBNull ? 0 : Convert.ToInt32(reader["LowStockItems"]);
                                int requireReorderItem = reader["RequireReorderItems"] is DBNull ? 0 : Convert.ToInt32(reader["RequireReorderItems"]);

                                lblLowStockItem.Text = $"{lowStockItem} inventory items low in stock";
                                lblRqItm.Text = $"{requireReorderItem} inventory items require reorder";

                                lblLowStockItem.ForeColor = lowStockItem > 0 ? Color.Red : Color.Green;
                                lblRqItm.ForeColor = requireReorderItem > 0 ? Color.Orange : Color.Green;
                            }
                        }
                    }

                    // Product-level alerts (excluding services)
                    string productQuery = @"
                SELECT
                    SUM(CASE WHEN TBL_INVENTORY.Quantity < @LowStockThreshold THEN 1 ELSE 0 END) AS LowStockProducts,
                    SUM(CASE WHEN TBL_INVENTORY.Quantity < TBL_INVENTORY.MinStock THEN 1 ELSE 0 END) AS RequireReorderProducts
                FROM TBL_PRODUCTS
                JOIN TBL_INVENTORY ON TBL_PRODUCTS.ProductID = TBL_INVENTORY.ProductID
                WHERE TBL_PRODUCTS.IsService = 0;";

                    using (var productCmd = new SQLiteCommand(productQuery, connection))
                    {
                        productCmd.Parameters.AddWithValue("@LowStockThreshold", lowStockThreshold);

                        using (var reader = productCmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                int lowStockProd = reader["LowStockProducts"] is DBNull ? 0 : Convert.ToInt32(reader["LowStockProducts"]);
                                int requireReorderProd = reader["RequireReorderProducts"] is DBNull ? 0 : Convert.ToInt32(reader["RequireReorderProducts"]);

                                lblLowStkPrd.Text = $"{lowStockProd} products low in stock";
                                lblPrdRq.Text = $"{requireReorderProd} products require reorder";

                                lblLowStkPrd.ForeColor = lowStockProd > 0 ? Color.Red : Color.Green;
                                lblPrdRq.ForeColor = requireReorderProd > 0 ? Color.Orange : Color.Green;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading inventory alerts: " + ex.Message);
            }
        }


        private void LoadInventoryGrid()
        {
            dgvInv.Rows.Clear();
            dgvInv.Columns.Clear();

            dgvInv.Columns.Add("ProductName", "Item Name");
            dgvInv.Columns.Add("CategoryID", "Category");
            dgvInv.Columns.Add("Quantity", "Quantity");
            dgvInv.Columns.Add("MinStock", "Min Stock");
            dgvInv.Columns.Add("CostPrice", "Cost Price");
            dgvInv.Columns.Add("Supplier", "Supplier");
            dgvInv.Columns.Add("Status", "Status");

            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();
                string query = @"
            SELECT 
                TBL_PRODUCTS.ProductName,
                TBL_PRODUCTS.CategoryID,
                TBL_INVENTORY.Quantity,
                TBL_INVENTORY.MinStock,
                TBL_INVENTORY.CostPrice,
                TBL_INVENTORY.Supplier
            FROM TBL_INVENTORY
            JOIN TBL_PRODUCTS ON TBL_INVENTORY.ProductID = TBL_PRODUCTS.ProductID
            WHERE TBL_PRODUCTS.IsService = 0;";

                using (var cmd = new SQLiteCommand(query, connection))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string name = reader["ProductName"].ToString();
                        string category = reader["CategoryID"].ToString();
                        int quantity = Convert.ToInt32(reader["Quantity"]);
                        int minStock = Convert.ToInt32(reader["MinStock"]);
                        double cost = Convert.ToDouble(reader["CostPrice"]);
                        string supplier = reader["Supplier"].ToString();
                        string status = quantity < minStock ? "Low Stock" : "OK";

                        dgvInv.Rows.Add(name, category, quantity, minStock, $"₱{cost:N2}", supplier, status);
                    }
                }
            }
        }
        private void LoadProductsGrid()
        {
            dgvProd.Rows.Clear();
            dgvProd.Columns.Clear();

            dgvProd.Columns.Add("ProductName", "Product Name");
            dgvProd.Columns.Add("CategoryID", "Category");
            dgvProd.Columns.Add("Price", "Price");
            dgvProd.Columns.Add("IsService", "Active");

            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();
                string query = @"
            SELECT 
                ProductName,
                CategoryID,
                Price,
                IsService
            FROM TBL_PRODUCTS;";

                using (var cmd = new SQLiteCommand(query, connection))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string name = reader["ProductName"].ToString();
                        string category = reader["CategoryID"].ToString();
                        double price = Convert.ToDouble(reader["Price"]);
                        string isService = Convert.ToInt32(reader["IsService"]) == 1 ? "Yes" : "No";

                        dgvProd.Rows.Add(name, category, $"₱{price:N2}", isService);
                    }
                }
            }
        }

        


        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadInventoryAlerts();
            LoadProductsGrid();
            LoadInventoryGrid();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pnlInventory_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
