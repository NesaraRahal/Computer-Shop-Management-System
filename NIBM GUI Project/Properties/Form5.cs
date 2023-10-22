using MySql.Data.MySqlClient;
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
    public partial class frmOrders : Form
    {
        public frmOrders()
        {
            InitializeComponent();
            populateGrid();
        }

        private void picOrderClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            frmAdminLogin AdminLogin = new frmAdminLogin();
            AdminLogin.Show();
            this.Close();
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            frmMenu menu = new frmMenu();
            menu.Show();
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void populateGrid()
        {
            MySqlConnection conn = NIBM_GUI_Project.Properties.cls_connection.connectDB();
            conn.Open();

            string query = "SELECT * FROM Orders";
            MySqlCommand cmd1 = new MySqlCommand(query, conn);

            MySqlDataAdapter ada = new MySqlDataAdapter(cmd1);
            DataTable dt = new DataTable();
            ada.Fill(dt);
            dgvOrders.DataSource = dt;
            conn.Close();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            populateGrid(); 
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            populateGrid();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            frmDashboard frmDashboard = new frmDashboard();
            frmDashboard.Show();
            this.Close();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            frmProfile frmProfile = new frmProfile();
            frmProfile.Show();
            this.Close();
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {

        }
    }
}
