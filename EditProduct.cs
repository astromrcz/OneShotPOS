using SiticoneNetCoreUI;
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
    public partial class EditProduct : Form
    {
        public EditProduct()
        {
            InitializeComponent();
        }

        // 🔥 You would add public methods or properties here to set the fields:
        /*
        public void LoadProductData(string name, string category, string price, string description)
        {
            txtProductName.Text = name;
            dropCategory.SelectedItem = category; // assuming it exists
            txtPrice.Text = price;
            txtDescription.Text = description;
        }
        */

        private void AddProduct_Load(object sender, EventArgs e)
        {
            // Initial form load logic
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            // Logic to save changes back to the database and close the form
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close(); // Close the form
        }
    }
}