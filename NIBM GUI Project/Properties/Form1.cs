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
    public partial class frmRole : Form
    {
        public frmRole()
        {
            InitializeComponent();
        }

        private void picRoleCLose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            frmSignUp user= new frmSignUp();
            user.Show();

            this.Hide();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            frmAdminLogin admin = new frmAdminLogin();
            admin.Show();

            this.Hide();
        }

        private void frmRole_Load(object sender, EventArgs e)
        {

        }
    }
}
