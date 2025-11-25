using SiticoneNetCoreUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace OneShotPOS
{
    public partial class AddProduct : Form
    {
        public AddProduct(string employeeId)
        {
            InitializeComponent();
            _loggedInEmployeeId = employeeId;
        }



        private const string ConnectionString = @"Data Source=C:\Users\morco\Downloads\testDB.db;Version=3;";
        private readonly string _loggedInEmployeeId;

        private void AddProduct_Load(object sender, EventArgs e)
        {
            cbCategory.Items.Clear();

            using (var conn = new SQLiteConnection(ConnectionString))
            {
                conn.Open();
                string query = "SELECT CategoryName FROM TBL_CATEGORIES";

                using (var cmd = new SQLiteCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        cbCategory.Items.Add(reader["CategoryName"].ToString());
                    }
                }
            }
        }


        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            string name = txtProductName.Text.Trim();
            string category = cbCategory.SelectedItem?.ToString();
            string description = txtDescription.Text.Trim();
            bool isValidPrice = decimal.TryParse(txtPrice.Text, out decimal price);

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(category) || !isValidPrice)
            {
                MessageBox.Show("Please fill out all required fields correctly.", "Validation Error");
                return;
            }

            int categoryId = GetCategoryId(category);

            using (var conn = new SQLiteConnection(ConnectionString))
            {
                conn.Open();

                // Insert into TBL_PRODUCTS
                string insertProduct = @"INSERT INTO TBL_PRODUCTS 
            (CategoryID, ProductName, Description, Price, IsService) 
            VALUES (@catId, @name, @desc, @price, 0)";

                using (var cmd = new SQLiteCommand(insertProduct, conn))
                {
                    cmd.Parameters.AddWithValue("@catId", categoryId);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@desc", description);
                    cmd.Parameters.AddWithValue("@price", price);
                    cmd.ExecuteNonQuery();
                }

                // Insert into TBL_ACTIVITYLOG
                string insertLog = @"INSERT INTO TBL_ACTIVITY_LOG 
    (Timestamp, Description, ActivityType, EmployeeID) 
    VALUES (@time, @desc, 'Inventory', @empId)";

                using (var cmd = new SQLiteCommand(insertLog, conn))
                {
                    cmd.Parameters.AddWithValue("@time", DateTime.UtcNow.ToString("yyyy-MM-dd HH:mm:ss"));
                    cmd.Parameters.AddWithValue("@desc", $"Added product '{name}' under '{category}' for P{price}");
                    cmd.Parameters.AddWithValue("@empId", _loggedInEmployeeId);
                    cmd.ExecuteNonQuery();
                }

            }

            MessageBox.Show("Product added successfully.", "Success");
            this.Close();
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


        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
