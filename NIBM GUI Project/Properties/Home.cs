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
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmUserMenu frmUserMenu = new frmUserMenu();    
            frmUserMenu.Show();
            this.Close();
        }

        private void btnStore_Click(object sender, EventArgs e)
        {
            frmUserMenu frmUserMenu = new frmUserMenu();
            frmUserMenu.Show();
            this.Close();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            login.Show();
            this.Close();
        }

        private void picUMenuClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
