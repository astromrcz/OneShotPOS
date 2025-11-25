using Siticone.Desktop.UI.WinForms;
using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace OneShotPOS
{
    public partial class EditProduct : Form
    {
        private int employeeId;
        private const string ConnectionString = @"Data Source=C:\Users\morco\Downloads\testDB.db;Version=3;";

        private int productId;

        public EditProduct(int id)
        {
            InitializeComponent();
            productId = id;
        }
        private string GetCategoryName(int categoryId)
        {
            using (var conn = new SQLiteConnection(ConnectionString))
            {
                conn.Open();
                string query = "SELECT CategoryName FROM TBL_CATEGORIES WHERE CategoryID = @id";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", categoryId);
                    object result = cmd.ExecuteScalar();
                    return result?.ToString() ?? "";
                }
            }
        }
        private int GetCategoryId(string categoryName)
        {
            using (var conn = new SQLiteConnection(ConnectionString))
            {
                conn.Open();
                string query = "SELECT CategoryID FROM TBL_CATEGORIES WHERE CategoryName = @name";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@name", categoryName);
                    object result = cmd.ExecuteScalar();
                    return result != null ? Convert.ToInt32(result) : 0;
                }
            }
        }



        private void EditProduct_Load(object sender, EventArgs e)
        {
            cbCategory.Items.Clear();

            using (var conn = new SQLiteConnection(ConnectionString))
            {
                conn.Open();

                // Load categories
                string catQuery = "SELECT CategoryName FROM TBL_CATEGORIES";
                using (var catCmd = new SQLiteCommand(catQuery, conn))
                using (var catReader = catCmd.ExecuteReader())
                {
                    while (catReader.Read())
                    {
                        cbCategory.Items.Add(catReader["CategoryName"].ToString());
                    }
                }

                // Load product details
                string query = "SELECT * FROM TBL_PRODUCTS WHERE ProductID = @id";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", productId);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            txtProductName.Text = reader["ProductName"].ToString();
                            txtPrice.Text = reader["Price"].ToString();
                            txtDescription.Text = reader["Description"].ToString();
                            txtQuantity.Text = reader["Quantity"].ToString(); // Add this textbox to your form
                            int catId = Convert.ToInt32(reader["CategoryID"]);
                            cbCategory.SelectedItem = GetCategoryName(catId);
                        }
                    }
                }
            }
        }



        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            string name = txtProductName.Text.Trim();
            string category = cbCategory.SelectedItem?.ToString();
            string description = txtDescription.Text.Trim();
            bool isValidPrice = decimal.TryParse(txtPrice.Text, out decimal price);
            bool isValidQty = int.TryParse(txtQuantity.Text, out int quantity);

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(category) || !isValidPrice || !isValidQty)
            {
                MessageBox.Show("Please fill out all fields correctly.", "Validation Error");
                return;
            }

            int categoryId = GetCategoryId(category);

            using (var conn = new SQLiteConnection(ConnectionString))
            {
                conn.Open();

                // ✅ Update product
                string query = @"UPDATE TBL_PRODUCTS SET 
            ProductName = @name, 
            CategoryID = @catId, 
            Description = @desc, 
            Price = @price, 
            Quantity = @qty 
            WHERE ProductID = @id";

                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@catId", categoryId);
                    cmd.Parameters.AddWithValue("@desc", description);
                    cmd.Parameters.AddWithValue("@price", price);
                    cmd.Parameters.AddWithValue("@qty", quantity);
                    cmd.Parameters.AddWithValue("@id", productId);
                    cmd.ExecuteNonQuery();
                }

                // ✅ Log activity
                string logQuery = @"INSERT INTO TBL_ACTIVITY_LOG 
            (Timestamp, ActivityType, Description, EmployeeID) 
            VALUES (@time, 'Inventory', @desc, @empId)";

                using (var cmdLog = new SQLiteCommand(logQuery, conn))
                {
                    cmdLog.Parameters.AddWithValue("@time", DateTime.UtcNow.ToString("yyyy-MM-dd HH:mm:ss"));
                    cmdLog.Parameters.AddWithValue("@desc", $"Updated product '{name}' under '{category}' with new price ₱{price:N2} and quantity {quantity}");
                    cmdLog.Parameters.AddWithValue("@empId", LoginPage.Session.EmployeeID); // Logged-in user
                    cmdLog.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Product updated successfully.", "Success");
            this.DialogResult = DialogResult.OK;
            this.Close();
        }



        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
