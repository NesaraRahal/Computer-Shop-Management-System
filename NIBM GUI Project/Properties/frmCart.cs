using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NIBM_GUI_Project.Properties
{
    public partial class frmCart : Form
    {
        public frmCart(string category, string product, int qty, double price)
        {
            InitializeComponent();
            lblCategory.Text = "Category: " + category;
            lblProduct.Text = "Product: " + product;
            lblQuantity.Text = "Quantity: " + qty;
            lblPrice.Text = "Price: " + price;

        }

        private void picUMenuClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnStore_Click(object sender, EventArgs e)
        {
            frmUserMenu menu = new frmUserMenu();
            menu.Show();
            this.Hide();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            frmHome home = new frmHome();
            home.Show();
            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            login.Show();
            login.Close();
        }

        private void frmCart_Load(object sender, EventArgs e)
        {

        }
    }
}
