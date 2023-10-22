using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NIBM_GUI_Project.Properties
{
    public partial class frmAdminMenu : Form
    {
        public frmAdminMenu()
        {
            InitializeComponent();
        }

        private void lblQuantity_Click(object sender, EventArgs e)
        {

        }

        private void lblProduct_Click(object sender, EventArgs e)
        {

        }

        private void lblAdminMenu_Click(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            frmAdminLogin AdminLogout = new frmAdminLogin();
            AdminLogout.Show();
            this.Close();
        }

        private void btnStock_Click(object sender, EventArgs e)
        {

        }

        private void picLogout_Click(object sender, EventArgs e)
        {
            frmAdminLogin AdminLogout = new frmAdminLogin();
            AdminLogout.Show();
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            frmOrders order = new frmOrders();
            order.Show();
            this.Close();
        }
    }
}
