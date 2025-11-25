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
        private const string ConnectionString = @"Data Source=""C:\Users\morco\Downloads\testDB.db"";Version=3;";
        public UC_Inventory()
        {
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

            using (var connection = new SQLiteConnection(ConnectionString))
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
                            string name = reader["ProductName"].ToString();
                            string desc = reader["Description"].ToString();
                            decimal price = Convert.ToDecimal(reader["Price"]);
                            int qty = reader["Quantity"] is DBNull ? 0 : Convert.ToInt32(reader["Quantity"]);

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
                                Cursor = Cursors.Hand
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
                                Cursor = Cursors.Hand
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
                                Text = $"Desc: {desc}",
                                Font = new Font("Segoe UI", 8),
                                Location = new Point(10, 30),
                                AutoSize = true
                            });

                            card.Controls.Add(new Label
                            {
                                Text = $"₱{price:N2}",
                                Font = new Font("Segoe UI", 9, FontStyle.Bold),
                                ForeColor = Color.DarkGreen,
                                Location = new Point(10, 50),
                                AutoSize = true
                            });

                            card.Controls.Add(new Label
                            {
                                Text = $"Qty: {qty}",
                                Font = new Font("Segoe UI", 8),
                                ForeColor = qty < 5 ? Color.FromArgb(192, 64, 0) : Color.Black,
                                Location = new Point(150, 50),
                                AutoSize = true
                            });

                            flowPanelProducts.Controls.Add(card);
                        }
                    }
                }
            }
        }



        private void LoadInventoryCards(string searchTerm = "")
        {
            flowPanelInventory.Controls.Clear();

            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();

                string query = @"
        SELECT 
            I.InventoryID, 
            I.ProductID, 
            P.ProductName, 
            I.Quantity, 
            I.MinStock
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
                            string name = reader["ProductName"].ToString();
                            int qty = Convert.ToInt32(reader["Quantity"]);
                            int min = Convert.ToInt32(reader["MinStock"]);
                            bool isLow = qty < min;

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
                                Cursor = Cursors.Hand
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
                                Cursor = Cursors.Hand
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
                                Text = $"Qty: {qty}",
                                Font = new Font("Segoe UI", 9),
                                ForeColor = qty < 5 ? Color.FromArgb(192, 64, 0) : Color.Black,
                                Location = new Point(10, 40),
                                AutoSize = true
                            });

                            card.Controls.Add(new Label
                            {
                                Text = $"Min: {min}",
                                Font = new Font("Segoe UI", 9),
                                ForeColor = isLow ? Color.OrangeRed : Color.DarkGreen,
                                Location = new Point(100, 40),
                                AutoSize = true
                            });

                            flowPanelInventory.Controls.Add(card);
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

        private void txtSearchProduct_TextChanged(object sender, EventArgs e)
        {
            debounceTimer.Stop();
            debounceTimer.Start();
        }
        private void debounceTimer_Tick(object sender, EventArgs e)
        {
            debounceTimer.Stop();
            LoadProductCards(txtSearchProduct.Text.Trim());
        }
    }
}
