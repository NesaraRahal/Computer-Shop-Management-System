using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NIBM_GUI_Project.Properties
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
            populateGrid();
        }

       
        private void picAdminMenuClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            frmAdminLogin adminLogin = new frmAdminLogin();
            adminLogin.Show();
            this.Close();
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            frmOrders orders = new frmOrders();
            orders.Show();
            this.Close();
        }

       

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cmbCategory.SelectedIndex == -1)
            {
                MessageBox.Show("Category should be selected");
            }
            else if (string.IsNullOrEmpty(txtProduct.Text) || string.IsNullOrEmpty(txtBPrice.Text) || string.IsNullOrEmpty(txtSPrice.Text) || string.IsNullOrEmpty(txtQty.Text))
            {
                MessageBox.Show("Text fields cannot be empty");
            }
            else
            {

                string category = cmbCategory.Text;
                string product = txtProduct.Text;
                double bprice = Convert.ToDouble(txtBPrice.Text);
                double sprice = Convert.ToDouble(txtSPrice.Text);
                int qty = Convert.ToInt32(txtQty.Text);

                try
                {

                    MySqlConnection conn = NIBM_GUI_Project.Properties.cls_connection.connectDB();
                    conn.Open();

                    string query = "INSERT INTO Items(itemCategory, product, broughtPrice, sellingPrice, quantity) VALUES ('" + category + "', '" + product + "', " + bprice + " , " + sprice + " , " + qty + ")";
                    MySqlCommand cmd1 = new MySqlCommand(query, conn);
                    cmd1.ExecuteNonQuery();
                    MessageBox.Show("Values inserted");


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    populateGrid();
                    // Close the connection in the finally block to ensure it's closed even if an exception occurs
                    //cls_connection.Close_connection();
                }

            }
        }

        private void populateGrid()
        {
            MySqlConnection conn = NIBM_GUI_Project.Properties.cls_connection.connectDB();
            conn.Open();

            string query = "SELECT * FROM Items";
            MySqlCommand cmd1 = new MySqlCommand(query, conn);
            
            MySqlDataAdapter ada = new MySqlDataAdapter(cmd1);
            DataTable dt = new DataTable();
            ada.Fill(dt);
            dgvItems.DataSource = dt;
            conn.Close();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSPrice.Text) || string.IsNullOrEmpty(txtProduct.Text) )
            {
                MessageBox.Show("Selling price text field cannot be empty");
            }
            else
            {
                string category = cmbCategory.Text;
                string product = txtProduct.Text;
                double sprice = Convert.ToDouble(txtSPrice.Text);
                

                try
                {

                    MySqlConnection conn = NIBM_GUI_Project.Properties.cls_connection.connectDB();
                    conn.Open();

                    string query = "UPDATE Items SET sellingPrice = "+sprice+" WHERE product = '"+product+"'";
                    MySqlCommand cmd1 = new MySqlCommand(query, conn);
                    cmd1.ExecuteNonQuery();
                    MessageBox.Show("Values updated");


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    populateGrid();
                    // Close the connection in the finally block to ensure it's closed even if an exception occurs
                    //cls_connection.Close_connection();
                }
            }
        }

        private void btnUpdateQty_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtQty.Text) || string.IsNullOrEmpty(txtQty.Text))
            {
                MessageBox.Show("Quantity text field cannot be empty");
            }
            else
            {
                string category = cmbCategory.Text;
                string product = txtProduct.Text;
                int quantity = Convert.ToInt32(txtQty.Text);
                int qtyn = 0;

                try
                {

                    MySqlConnection conn = NIBM_GUI_Project.Properties.cls_connection.connectDB();
                    conn.Open();

                    string query2 = "SELECT  quantity FROM Items WHERE product = '"+product+"' ";
                    MySqlCommand cmd2 = new MySqlCommand(query2, conn);

                    using (MySqlDataReader reader = cmd2.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                           qtyn  = reader.GetInt32("quantity");
                        }
                    }

                    qtyn = qtyn + quantity;
                    string query = "UPDATE Items SET quantity = " + qtyn + " WHERE  product = '" + product + "'";
                    MySqlCommand cmd1 = new MySqlCommand(query, conn);
                    cmd1.ExecuteNonQuery();
                    MessageBox.Show("Values updated");


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    populateGrid();
                    // Close the connection in the finally block to ensure it's closed even if an exception occurs
                    //cls_connection.Close_connection();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtProduct.Text))
            {
                MessageBox.Show("Product text field cannot be empty");
            }
            else
            {
               
                string product = txtProduct.Text;
               

                try
                {

                    MySqlConnection conn = NIBM_GUI_Project.Properties.cls_connection.connectDB();
                    conn.Open();

                    string query = "DELETE FROM Items WHERE product = '"+product+"'";
                    MySqlCommand cmd1 = new MySqlCommand(query, conn);
                    cmd1.ExecuteNonQuery();
                    MessageBox.Show("Product deleted");


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    populateGrid();
                    // Close the connection in the finally block to ensure it's closed even if an exception occurs
                    //cls_connection.Close_connection();
                }
            }
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            frmDashboard frmDashboard = new frmDashboard();
            frmDashboard.Show();
            this.Close();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            frmProfile profile = new frmProfile();
            profile.Show();
            this.Close();
        }

        private void btnStock_Click(object sender, EventArgs e)
        {

        }
    }
}
