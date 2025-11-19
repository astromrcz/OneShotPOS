using SiticoneNetCoreUI;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace OneShotPOS
{
    public partial class UC_Products : UserControl
    {
        public UC_Products()
        {
            InitializeComponent();
        }
        private void LoadProducts()
        {
            FilterProducts(null, null);
        }

        private SiticonePanel CreateProductCard(string name, string category, string price, string stock)
        {
            SiticonePanel card = new SiticonePanel();
            card.Size = new Size(250, 180);
            card.Padding = new Padding(10);
            card.BackColor = Color.White;
            card.Margin = new Padding(10);

            // Product Name
            SiticoneLabel lblName = new SiticoneLabel();
            lblName.Text = name;
            lblName.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            lblName.Location = new Point(10, 10);

            // Category
            SiticoneLabel lblCategory = new SiticoneLabel();
            lblCategory.Text = category;
            lblCategory.Font = new Font("Segoe UI", 9, FontStyle.Italic);
            lblCategory.ForeColor = Color.Gray;
            lblCategory.Location = new Point(10, 40);

            // Price
            SiticoneLabel lblPrice = new SiticoneLabel();
            lblPrice.Text = price;
            lblPrice.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            lblPrice.Location = new Point(10, 70);

            // Stock
            SiticoneLabel lblStock = new SiticoneLabel();
            lblStock.Text = $"Stock: {stock}";
            lblStock.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            lblStock.Location = new Point(10, 100);

            // Action Buttons
            SiticoneButton btnEdit = new SiticoneButton();
            btnEdit.Text = "Edit";
            btnEdit.Size = new Size(80, 30);
            btnEdit.Location = new Point(10, 130);

            SiticoneButton btnDelete = new SiticoneButton();
            btnDelete.Text = "Delete";
            btnDelete.Size = new Size(80, 30);
            btnDelete.Location = new Point(100, 130);

            // Add controls to card
            card.Controls.Add(lblName);
            card.Controls.Add(lblCategory);
            card.Controls.Add(lblPrice);
            card.Controls.Add(lblStock);
            card.Controls.Add(btnEdit);
            card.Controls.Add(btnDelete);

            // Optional: border effect
            card.Paint += (s, e) =>
            {
                using (Pen pen = new Pen(Color.LightGray, 2))
                {
                    e.Graphics.DrawRectangle(pen, 0, 0, card.Width - 1, card.Height - 1);
                }
            };

            return card;
        }

        private void UC_Products_Load(object sender, EventArgs e)
        {
            // Configure ProductsPanel
            ProductsPanel.Size = new Size(1604, 749);
            ProductsPanel.Location = new Point(44, 244);
            ProductsPanel.Padding = new Padding(10);
            ProductsPanel.Margin = new Padding(3);
            ProductsPanel.BackColor = Color.WhiteSmoke;

            // Add header label
            SiticoneLabel lblHeader = new SiticoneLabel();
            lblHeader.Text = "Active Products";
            lblHeader.Font = new Font("Segoe UI", 14, FontStyle.Bold);
            lblHeader.Location = new Point(15, 15);
            ProductsPanel.Controls.Add(lblHeader);

            // FlowLayoutPanel for cards
            FlowLayoutPanel flowPanel = new FlowLayoutPanel();
            flowPanel.Dock = DockStyle.Fill;
            flowPanel.AutoScroll = true;
            flowPanel.WrapContents = true;
            flowPanel.FlowDirection = FlowDirection.LeftToRight;
            flowPanel.Padding = new Padding(20, 60, 20, 20); // leave space for header
            ProductsPanel.Controls.Add(flowPanel);

            // Add product cards
            flowPanel.Controls.Add(CreateProductCard("San Miguel Beer", "Beverages", "₱45.00", "48 bottles"));
            flowPanel.Controls.Add(CreateProductCard("Red Horse Beer", "Beverages", "₱48.00", "36 bottles"));
            flowPanel.Controls.Add(CreateProductCard("Coca-Cola", "Beverages", "₱20.00", "72 cans"));
            flowPanel.Controls.Add(CreateProductCard("Nachos", "Food", "₱80.00", "25 bags"));

            dropdownCategory.Items.Clear();
            dropdownCategory.Items.Add("All Categories");
            dropdownCategory.Items.Add("Drinks");
            dropdownCategory.Items.Add("Food");
            dropdownCategory.Items.Add("Billiards");
            dropdownCategory.SelectedIndex = 0; // Default to "All Categories"

            // Hook up events
            txtSearchProducts.TextChanged += FilterProducts;
            dropdownCategory.SelectedIndexChanged += FilterProducts;

            // Initial load
            LoadProducts();
        }
        private void FilterProducts(object sender, EventArgs e)
        {
            string searchText = txtSearchProducts.Text.ToLower();
            string selectedCategory = dropdownCategory.SelectedItem.ToString();

            ProductsPanel.Controls.Clear();

            // Add header label back
            SiticoneLabel lblHeader = new SiticoneLabel();
            lblHeader.Text = "Active Products";
            lblHeader.Font = new Font("Segoe UI", 14, FontStyle.Bold);
            lblHeader.Location = new Point(15, 15);
            ProductsPanel.Controls.Add(lblHeader);

            // Flow panel for cards
            FlowLayoutPanel flowPanel = new FlowLayoutPanel();
            flowPanel.Dock = DockStyle.Fill;
            flowPanel.AutoScroll = true;
            flowPanel.WrapContents = true;
            flowPanel.FlowDirection = FlowDirection.LeftToRight;
            flowPanel.Padding = new Padding(20, 60, 20, 20);
            ProductsPanel.Controls.Add(flowPanel);

            // Filter products
            var filtered = products.Where(p =>
                (selectedCategory == "All Categories" || p.Category.Equals(selectedCategory, StringComparison.OrdinalIgnoreCase)) &&
                (string.IsNullOrEmpty(searchText) || p.Name.ToLower().Contains(searchText))
            );

            foreach (var p in filtered)
            {
                flowPanel.Controls.Add(CreateProductCard(p.Name, p.Category, p.Price, p.Stock));
            }
        }
        private List<(string Name, string Category, string Price, string Stock)> products =
    new List<(string, string, string, string)>
    {
        ("San Miguel Beer", "Drinks", "₱45.00", "48 bottles"),
        ("Red Horse Beer", "Drinks", "₱48.00", "36 bottles"),
        ("Coca-Cola", "Drinks", "₱20.00", "72 cans"),
        ("Nachos", "Food", "₱80.00", "25 bags"),
        ("Chicken Wings", "Food", "₱280.00", "12 kg"),
        ("Billiard Chalk", "Billiards", "₱150.00", "8 boxes"),
        ("Pool Table Felt", "Billiards", "₱3500.00", "2 rolls")
    };

        private void btnAddProducts_Click(object sender, EventArgs e)
        {

        }
    }
}
