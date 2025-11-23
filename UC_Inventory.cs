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

        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            AddProduct product = new AddProduct();
            product.Show();
        }
    }
}
