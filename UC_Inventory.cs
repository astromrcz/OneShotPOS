using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Siticone.Desktop.UI.WinForms;


namespace OneShotPOS
{
    public partial class UC_Inventory : UserControl
    {
        private System.Timers.Timer debounceTimer;
        private bool isLow;
        //private const string ConnectionString = @"Data Source=""C:\Users\morco\Downloads\testDB.db"";Version=3;";
        private readonly string _connectionString;
        public UC_Inventory(string connectionString)
        {
           _connectionString = connectionString;
            InitializeComponent();
        }


        private void UC_Inventory_Load(object sender, EventArgs e)
        {
            LoadInventoryAlerts();
            LoadInventoryCards();
            LoadProductCards();
        
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            AddProduct product = new AddProduct(LoginPage.Session.EmployeeID);
            product.Show();
        }

        private void LoadInventoryAlerts()
        {
            try
            {
                using (var connection = new SQLiteConnection(_connectionString))
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

                                // Softer label colors
                                lblLowStockItem.ForeColor = lowStockItem > 0 ? Color.FromArgb(192, 64, 0) : Color.FromArgb(40, 120, 40); // soft red or green
                                lblRqItm.ForeColor = requireReorderItem > 0 ? Color.FromArgb(255, 140, 0) : Color.FromArgb(40, 120, 40); // orange or green

                                // Panel recoloring logic
                                if (lowStockItem == 0 && requireReorderItem == 0)
                                {
                                    pnlLowInventoryStockAlert.BackColor = Color.FromArgb(220, 255, 220); // soft green
                                    pnlLowProductsStockAlert.BackColor = Color.FromArgb(220, 255, 220);
                                }
                                else if (lowStockItem > 0)
                                {
                                    pnlLowInventoryStockAlert.BackColor = Color.FromArgb(255, 230, 230); // soft red tint
                                    pnlLowProductsStockAlert.BackColor = Color.FromArgb(255, 230, 230);
                                }
                                else if (requireReorderItem > 0)
                                {
                                    pnlLowInventoryStockAlert.BackColor = Color.FromArgb(255, 250, 200); // soft yellow tint
                                    pnlLowProductsStockAlert.BackColor = Color.FromArgb(255, 250, 200);
                                }

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

                                // Panel color logic for products
                                if (lowStockProd == 0 && requireReorderProd == 0)
                                    pnlLowProductsStockAlert.BackColor = Color.Green;   // all good
                                else if (lowStockProd > 0)
                                    pnlLowProductsStockAlert.BackColor = Color.Red;     // low stock
                                else if (requireReorderProd > 0)
                                    pnlLowProductsStockAlert.BackColor = Color.Yellow;  // reorder needed
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

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadInventoryAlerts();
            LoadProductCards();
            LoadInventoryCards();
        }


        private void LoadProductCards(string searchTerm = "")
        {
            flowPanelProducts.Controls.Clear();
           
            flowPanelProducts.AutoScroll = true;
            flowPanelProducts.WrapContents = true;
            flowPanelProducts.FlowDirection = FlowDirection.TopDown;

            using (var connection = new SQLiteConnection(_connectionString))
            {
                connection.Open();

                string query = @"
        SELECT 
            P.ProductID, 
            P.ProductName, 
            P.Description, 
            P.Price, 
            I.Quantity
        FROM TBL_PRODUCTS P
        LEFT JOIN TBL_INVENTORY I ON P.ProductID = I.ProductID
        WHERE 
            P.ProductName LIKE @Search 
            OR P.Description LIKE @Search
        ORDER BY P.ProductName;";

                using (var cmd = new SQLiteCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@Search", $"%{searchTerm}%");

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int productId = Convert.ToInt32(reader["ProductID"]);
                            string name = reader["ProductName"].ToString();
                            string desc = reader["Description"].ToString();
                            decimal price = Convert.ToDecimal(reader["Price"]);
                            int qty = reader["Quantity"] is DBNull ? 0 : Convert.ToInt32(reader["Quantity"]);
                            bool isLow = qty < 5;

                            Panel card = new Panel
                            {
                                Width = 250,
                                Height = 100,
                                Margin = new Padding(10),
                                BackColor = isLow ? Color.FromArgb(255, 230, 230) : Color.White,
                                BorderStyle = BorderStyle.FixedSingle
                            };

                            var btnEdit = new SiticoneButton
                            {
                                Text = "Edit",
                                Size = new Size(60, 25),
                                Location = new Point(card.Width - 130, card.Height - 35),
                                FillColor = Color.FromArgb(0, 120, 215),
                                ForeColor = Color.White,
                                Font = new Font("Segoe UI", 8, FontStyle.Bold),
                                BorderRadius = 5,
                                Cursor = Cursors.Hand,
                                Tag = productId
                            };
                            btnEdit.Click += (s, e) =>
                            {
                                EditProduct editForm = new EditProduct(productId);
                                editForm.ShowDialog();
                                LoadProductCards(); // Refresh after edit
                            };

                            var btnDelete = new SiticoneButton
                            {
                                Text = "Delete",
                                Size = new Size(60, 25),
                                Location = new Point(card.Width - 65, card.Height - 35),
                                FillColor = Color.FromArgb(220, 20, 60),
                                ForeColor = Color.White,
                                Font = new Font("Segoe UI", 8, FontStyle.Bold),
                                BorderRadius = 5,
                                Cursor = Cursors.Hand,
                                Tag = productId
                            };
                            btnDelete.Click += (s, e) =>
                            {
                                var confirm = MessageBox.Show($"Delete product '{name}'?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                                if (confirm == DialogResult.Yes)
                                {
                                    using (var conn = new SQLiteConnection(_connectionString))
                                    {
                                        conn.Open();
                                        string deleteQuery = "DELETE FROM TBL_PRODUCTS WHERE ProductID = @id";
                                        using (var cmd = new SQLiteCommand(deleteQuery, conn))
                                        {
                                            cmd.Parameters.AddWithValue("@id", productId);
                                            cmd.ExecuteNonQuery();
                                        }
                                    }
                                    LoadProductCards(); // Refresh after delete
                                }
                            };

                            card.Controls.Add(btnEdit);
                            card.Controls.Add(btnDelete);
                            card.Controls.Add(new Label { Text = name, Font = new Font("Segoe UI", 10, FontStyle.Bold), Location = new Point(10, 10), AutoSize = true });
                            card.Controls.Add(new Label { Text = $"Desc: {desc}", Font = new Font("Segoe UI", 8), Location = new Point(10, 30), AutoSize = true });
                            card.Controls.Add(new Label { Text = $"₱{price:N2}", Font = new Font("Segoe UI", 9, FontStyle.Bold), ForeColor = Color.DarkGreen, Location = new Point(10, 50), AutoSize = true });
                            card.Controls.Add(new Label { Text = $"Qty: {qty}", Font = new Font("Segoe UI", 8), ForeColor = isLow ? Color.FromArgb(192, 64, 0) : Color.Black, Location = new Point(150, 50), AutoSize = true });

                            flowPanelProducts.Controls.Add(card);
                            int count = flowPanelProducts.Controls.Count;
                            lblProducts.Text = $"Products: {count}";
                            

                        }

                    }
                }
            }
        }

        private void LoadInventoryCards(string searchTerm = "")
        {
            flowPanelInventory.Controls.Clear();
            flowPanelInventory.AutoScroll = true;
            flowPanelInventory.WrapContents = true;
            flowPanelInventory.FlowDirection = FlowDirection.TopDown;

            flowPanelProducts.AutoScroll = true;
            flowPanelProducts.WrapContents = true;
            flowPanelProducts.FlowDirection = FlowDirection.TopDown;

            using (var connection = new SQLiteConnection(_connectionString))
            {
                connection.Open();

                string query = @"
        SELECT 
            I.InventoryID,
            I.ProductID,
            P.ProductName,
            I.Quantity,
            I.MinStock,
            I.CostPrice,
            I.Supplier,
            I.Unit
        FROM TBL_INVENTORY I
        JOIN TBL_PRODUCTS P ON I.ProductID = P.ProductID
        WHERE P.ProductName LIKE @Search
        ORDER BY P.ProductName;";

                using (var cmd = new SQLiteCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@Search", $"%{searchTerm}%");

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int inventoryId = Convert.ToInt32(reader["InventoryID"]);
                            string name = reader["ProductName"].ToString();
                            int qty = Convert.ToInt32(reader["Quantity"]);
                            int min = Convert.ToInt32(reader["MinStock"]);
                            decimal cost = Convert.ToDecimal(reader["CostPrice"]);
                            string supplier = reader["Supplier"].ToString();
                            string unit = reader["Unit"].ToString();
                            bool isLow = qty < min;

                            Panel card = new Panel
                            {
                                Width = 250,
                                Height = 110,
                                Margin = new Padding(10),
                                BackColor = isLow ? Color.FromArgb(255, 230, 230) : Color.White,
                                BorderStyle = BorderStyle.FixedSingle
                            };

                            var btnEdit = new SiticoneButton
                            {
                                Text = "Edit",
                                Size = new Size(60, 25),
                                Location = new Point(card.Width - 130, card.Height - 35),
                                FillColor = Color.FromArgb(0, 120, 215),
                                ForeColor = Color.White,
                                Font = new Font("Segoe UI", 8, FontStyle.Bold),
                                BorderRadius = 5,
                                Cursor = Cursors.Hand,
                                Tag = inventoryId
                            };
                            btnEdit.Click += (s, e) =>
                            {
                                EditProduct editForm = new EditProduct(inventoryId);
                                editForm.ShowDialog();
                                LoadInventoryCards(); // Refresh after edit
                            };

                            var btnDelete = new SiticoneButton
                            {
                                Text = "Delete",
                                Size = new Size(60, 25),
                                Location = new Point(card.Width - 65, card.Height - 35),
                                FillColor = Color.FromArgb(220, 20, 60),
                                ForeColor = Color.White,
                                Font = new Font("Segoe UI", 8, FontStyle.Bold),
                                BorderRadius = 5,
                                Cursor = Cursors.Hand,
                                Tag = inventoryId
                            };
                            btnDelete.Click += (s, e) =>
                            {
                                var confirm = MessageBox.Show($"Delete inventory for '{name}'?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                                if (confirm == DialogResult.Yes)
                                {
                                    using (var connDel = new SQLiteConnection(_connectionString))
                                    {
                                        connDel.Open();
                                        string deleteQuery = "DELETE FROM TBL_INVENTORY WHERE InventoryID = @id";
                                        using (var cmdDel = new SQLiteCommand(deleteQuery, connDel))
                                        {
                                            cmdDel.Parameters.AddWithValue("@id", inventoryId);
                                            cmdDel.ExecuteNonQuery();
                                        }
                                    }
                                    LoadInventoryCards(); // Refresh after delete
                                }
                            };

                            card.Controls.Add(btnEdit);
                            card.Controls.Add(btnDelete);
                            card.Controls.Add(new Label
                            {
                                Text = name,
                                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                                Location = new Point(10, 10),
                                AutoSize = true
                            });
                            card.Controls.Add(new Label
                            {
                                Text = $"Qty: {qty} {unit}",
                                Font = new Font("Segoe UI", 9),
                                ForeColor = isLow ? Color.OrangeRed : Color.Black,
                                Location = new Point(10, 30),
                                AutoSize = true
                            });
                            card.Controls.Add(new Label
                            {
                                Text = $"Min: {min}",
                                Font = new Font("Segoe UI", 9),
                                ForeColor = isLow ? Color.OrangeRed : Color.DarkGreen,
                                Location = new Point(100, 30),
                                AutoSize = true
                            });
                            card.Controls.Add(new Label
                            {
                                Text = $"₱{cost:N2}",
                                Font = new Font("Segoe UI", 9, FontStyle.Bold),
                                ForeColor = Color.DarkSlateGray,
                                Location = new Point(10, 50),
                                AutoSize = true
                            });
                            card.Controls.Add(new Label
                            {
                                Text = $"Supplier: {supplier}",
                                Font = new Font("Segoe UI", 8),
                                ForeColor = Color.Gray,
                                Location = new Point(10, 70),
                                AutoSize = true
                            });

                            flowPanelInventory.Controls.Add(card);
                            int count = flowPanelInventory.Controls.Count;
                            lblInventory.Text = $"Inventory Items: {count}";
                        }
                    }
                }
            }
        }




        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pnlInventory_Paint(object sender, PaintEventArgs e)
        {

        }

        
        
    }
}
