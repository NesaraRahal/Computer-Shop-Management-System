using MySql.Data.MySqlClient;
using NIBM_GUI_Project.Properties;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NIBM_GUI_Project
{
    public partial class frmDashboard : Form
    {
        public frmDashboard()
        {
            InitializeComponent();
            displayOrders();
            earningCalc();
        }

        public void displayOrders()
        {
            MySqlConnection conn = NIBM_GUI_Project.Properties.cls_connection.connectDB();
            conn.Open();

            string query = "SELECT COUNT(*) FROM Orders;";

            using (MySqlCommand command = new MySqlCommand(query, conn))
            {
                try
                {

                    int count = Convert.ToInt32(command.ExecuteScalar());
                    lblOrderCount.Text = count.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        public void earningCalc()
        {
            MySqlConnection conn = NIBM_GUI_Project.Properties.cls_connection.connectDB();
            conn.Open();

            string query = "SELECT SUM(Total_amt) AS TotalEarnings FROM Orders;";

            using (MySqlCommand command = new MySqlCommand(query, conn))
            {
                try
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            double total = reader.GetDouble("TotalEarnings");
                            lblTot.Text = "Rs. "+total.ToString();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnViewOrders_Click(object sender, EventArgs e)
        {
            frmOrders orders = new frmOrders();
            orders.Show();
            this.Close();
        }

        private void lblOrderCount_Click(object sender, EventArgs e)
        {
            
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            frmMenu menu = new frmMenu();
            menu.Show();
            this.Close();
        }

        private void picUMenuClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblQtyDisplay_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmMenu menu = new frmMenu();
            menu.Show();
            this.Close();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            frmProfile profile = new frmProfile();
            profile.Show();
            this.Close();
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            frmOrders order = new frmOrders();
            order.Show();
            this.Close();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            frmAdminLogin login = new frmAdminLogin();
            login.Show();
            this.Close();
        }
    }
}
