using SiticoneNetCoreUI;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace OneShotPOS
{
    // Define the tuple structure for clarity when passing to events
    using ProductData = (string Name, string Category, string Price, string Stock);

    public partial class UC_Products : UserControl
    {
        private FlowLayoutPanel flowPanel;

        // Define a fixed width for the entire content area (adjust this as needed)
        private const int ContentWidth = 1200;

        // Mock product data with many more entries to test scrolling
        private List<ProductData> products =
            new List<ProductData>
        {
            // --- Original Products (7) ---
            ("San Miguel Beer", "Drinks", "₱45.00", "48 bottles"),
            ("Red Horse Beer", "Drinks", "₱48.00", "36 bottles"),
            ("Coca-Cola", "Drinks", "₱20.00", "72 cans"),
            ("Nachos", "Food", "₱80.00", "25 bags"),
            ("Chicken Wings", "Food", "₱280.00", "12 kg"),
            ("Billiard Chalk", "Billiards", "₱150.00", "8 boxes"),
            ("Pool Table Felt", "Billiards", "₱3500.00", "2 rolls"),
            
            // --- Added Products for Scroll Testing (30+) ---
            ("Mineral Water 500ml", "Drinks", "₱15.00", "100 bottles"),
            ("Lemonade Pitcher", "Drinks", "₱90.00", "15 orders"),
            ("Iced Tea Glass", "Drinks", "₱35.00", "50 glasses"),
            ("Soda Water Can", "Drinks", "₱25.00", "60 cans"),
            ("Tequila Shot", "Drinks", "₱120.00", "40 shots"),

            ("Fries Regular", "Food", "₱60.00", "50 servings"),
            ("Cheeseburger", "Food", "₱150.00", "20 servings"),
            ("Club Sandwich", "Food", "₱180.00", "18 servings"),
            ("Onion Rings", "Food", "₱95.00", "30 bags"),
            ("Pizza Slice Pepperoni", "Food", "₱110.00", "45 slices"),

            ("Billiard Cue Stick", "Billiards", "₱1800.00", "10 sticks"),
            ("Billiard Ball Set", "Billiards", "₱6000.00", "3 sets"),
            ("Pool Table Brush", "Billiards", "₱400.00", "5 brushes"),
            
            // More fillers to guarantee overflow
            ("Product A", "Drinks", "₱10.00", "10 items"),
            ("Product B", "Food", "₱10.00", "10 items"),
            ("Product C", "Billiards", "₱10.00", "10 items"),
            ("Product D", "Drinks", "₱10.00", "10 items"),
            ("Product E", "Food", "₱10.00", "10 items"),
            ("Product F", "Billiards", "₱10.00", "10 items"),
            ("Product G", "Drinks", "₱10.00", "10 items"),
            ("Product H", "Food", "₱10.00", "10 items"),
            ("Product I", "Billiards", "₱10.00", "10 items"),
            ("Product J", "Drinks", "₱10.00", "10 items"),
            ("Product K", "Food", "₱10.00", "10 items"),
            ("Product L", "Billiards", "₱10.00", "10 items"),
            ("Product M", "Drinks", "₱10.00", "10 items"),
            ("Product N", "Food", "₱10.00", "10 items"),
            ("Product O", "Billiards", "₱10.00", "10 items"),
            ("Product P", "Drinks", "₱10.00", "10 items"),
            ("Product Q", "Food", "₱10.00", "10 items"),
            ("Product R", "Billiards", "₱10.00", "10 items"),
            ("Product S", "Drinks", "₱10.00", "10 items"),
        };

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
            card.MaximumSize = new Size(250, 180);
            card.MinimumSize = new Size(250, 180);

            // Create a temporary object to hold the current product data
            // Since we don't have descriptions, we'll just use the name for the description field placeholder
            var currentProduct = (Name: name, Category: category, Price: price, Stock: stock);

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

            // 🔥 Attach Edit Click Handler
            btnEdit.Tag = currentProduct; // Store the product data in the button's Tag
            btnEdit.Click += btnEdit_Click;

            SiticoneButton btnDelete = new SiticoneButton();
            btnDelete.Text = "Delete";
            btnDelete.Size = new Size(80, 30);
            btnDelete.Location = new Point(100, 130);

            // 🔥 Attach Delete Click Handler
            btnDelete.Tag = currentProduct; // Store the product data in the button's Tag
            btnDelete.Click += btnDelete_Click;


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
            // Calculate the starting X-coordinate to center the elements
            int offsetX = (this.Width - ContentWidth) / 2;
            if (offsetX < 0) offsetX = 0;

            // --- 1. Resize and Reposition the Search/Filter controls ---

            // Adjust the search box (txtSearchProducts)
            txtSearchProducts.Size = new Size(ContentWidth - 250, txtSearchProducts.Height);
            txtSearchProducts.Location = new Point(offsetX + 20, txtSearchProducts.Location.Y);

            // Adjust the category dropdown (dropdownCategory)
            dropdownCategory.Size = new Size(200, dropdownCategory.Height);
            dropdownCategory.Location = new Point(txtSearchProducts.Right + 10, dropdownCategory.Location.Y);

            // --- 2. Configure ProductsPanel ---
            ProductsPanel.Width = ContentWidth;
            ProductsPanel.Height = 749;
            ProductsPanel.Location = new Point(offsetX, ProductsPanel.Location.Y);
            ProductsPanel.Padding = new Padding(20);
            ProductsPanel.Margin = new Padding(0);
            ProductsPanel.BackColor = Color.WhiteSmoke;
            ProductsPanel.AutoSize = false;

            // 3. Add Header Label
            SiticoneLabel lblHeader = new SiticoneLabel();
            lblHeader.Text = "Active Products";
            lblHeader.Font = new Font("Segoe UI", 14, FontStyle.Bold);
            lblHeader.AutoSize = true;
            lblHeader.Location = new Point(20, 20);
            ProductsPanel.Controls.Add(lblHeader);

            // 4. FlowLayoutPanel Initialization and Placement
            flowPanel = new FlowLayoutPanel();

            int flowPanelX = 20;
            int flowPanelY = lblHeader.Bottom + 20;

            int flowPanelWidth = ProductsPanel.Width - 40;
            int flowPanelHeight = ProductsPanel.Height - flowPanelY - 20;

            flowPanel.Location = new Point(flowPanelX, flowPanelY);
            flowPanel.Size = new Size(flowPanelWidth, flowPanelHeight);

            flowPanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
            flowPanel.AutoScroll = true;
            flowPanel.WrapContents = true;
            flowPanel.FlowDirection = FlowDirection.LeftToRight;
            flowPanel.Padding = new Padding(0);
            flowPanel.Margin = new Padding(0);

            ProductsPanel.Controls.Add(flowPanel);


            // 5. Category Dropdown Setup
            dropdownCategory.Items.Clear();
            dropdownCategory.Items.Add("All Categories");
            dropdownCategory.Items.Add("Drinks");
            dropdownCategory.Items.Add("Food");
            dropdownCategory.Items.Add("Billiards");
            dropdownCategory.SelectedIndex = 0;

            // 6. Hook up events
            txtSearchProducts.TextChanged += FilterProducts;
            dropdownCategory.SelectedIndexChanged += FilterProducts;

            // 7. Initial load
            LoadProducts();
        }

        // --- 🔥 NEW: Edit and Delete Event Handlers ---

        private void btnEdit_Click(object sender, EventArgs e)
        {
            // The sender is the SiticoneButton
            SiticoneButton btn = sender as SiticoneButton;
            if (btn == null || !(btn.Tag is ProductData product)) return;

            // Create an instance of the EditProduct Form
            // Assuming EditProduct is the form class name
            // If the form requires a specific constructor, adjust here.
            EditProduct editForm = new EditProduct();

            // 🔥 Populate the EditProduct form fields (you need to implement setters 
            //    or public properties on your EditProduct form to access these controls)
            // Example of what the code would look like if EditProduct had public setters:
            /*
            editForm.ProductName = product.Name;
            editForm.Category = product.Category;
            editForm.Price = product.Price;
            // Since product list doesn't have a description, using Name as placeholder
            editForm.Description = $"Current Stock: {product.Stock}"; 
            */

            // For now, let's just show a message and the form:
            MessageBox.Show($"Editing product: {product.Name} (Price: {product.Price})",
                            "Edit Product", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Show the form
            editForm.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SiticoneButton btn = sender as SiticoneButton;
            if (btn == null || !(btn.Tag is ProductData product)) return;

            DialogResult result = MessageBox.Show($"Are you sure you want to delete {product.Name}?",
                                                  "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                // 🔥 Simulate Deletion (Actual database connection would go here)

                // 1. Remove the product from the local list
                products.Remove(product);

                // 2. Refresh the display to show the product is gone
                FilterProducts(null, null);

                MessageBox.Show($"{product.Name} has been successfully removed.",
                                "Deletion Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // --- End of NEW Handlers ---

        private void FilterProducts(object sender, EventArgs e)
        {
            if (flowPanel == null) return;

            string searchText = txtSearchProducts.Text.ToLower();
            string selectedCategory = "All Categories";

            if (dropdownCategory != null && dropdownCategory.SelectedItem != null)
            {
                selectedCategory = dropdownCategory.SelectedItem.ToString();
            }

            flowPanel.Controls.Clear();

            // Filter products
            var filtered = products.Where(p =>
                (selectedCategory == "All Categories" || p.Category.Equals(selectedCategory, StringComparison.OrdinalIgnoreCase)) &&
                (string.IsNullOrEmpty(searchText) || p.Name.ToLower().Contains(searchText))
            );

            // Add filtered product cards back to the FlowLayoutPanel
            foreach (var p in filtered)
            {
                flowPanel.Controls.Add(CreateProductCard(p.Name, p.Category, p.Price, p.Stock));
            }
        }

        private void btnAddProducts_Click(object sender, EventArgs e)
        {
            AddProduct product = new AddProduct();
            product.Show();
        }
    }
}