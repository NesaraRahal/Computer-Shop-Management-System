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
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace NIBM_GUI_Project.Properties
{
    public partial class frmUserMenu : Form
    {
        public frmUserMenu()
        {
            InitializeComponent();
            fillCombos();
            txtPrice.ReadOnly = true;
        }

        void fillCombos()
        {
            

                MySqlConnection conn = NIBM_GUI_Project.Properties.cls_connection.connectDB();
                conn.Open();

            string category = cmbUserCategory.Text;
            
                string query = "SELECT * FROM Items WHERE itemCategory = '"+ category + "' ";
                MySqlCommand cmd1 = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd1.ExecuteReader();

                while (reader.Read())
                {
                    /*string cName = reader.GetString("itemCategory" );
                    cmbUserCategory.Items.Add(cName);*/
                    string uProduct = reader.GetString("product");
                    cmbUProduct.Items.Add(uProduct);




                }

            





        }

        private void frmUserMenu_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        TotalAmountCalc calc = new TotalAmountCalc();
        public bool validate(string category, string product)
        {
            try
            {

                MySqlConnection conn = NIBM_GUI_Project.Properties.cls_connection.connectDB();
                conn.Open();


                string query = "SELECT sellingPrice FROM Items WHERE itemCategory = @category AND product = @product";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@category", category);
                cmd.Parameters.AddWithValue("@product", product);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    // Check if there is a matching user in the database
                    return reader.HasRows;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return false; // Return false in case of an exception
            }
            finally
            {
                // Close the connection in the finally block
                //cls_connection.Close_connection();
            }
        }

        public bool getQty(string category, string product)
        {
            try
            {

                MySqlConnection conn = NIBM_GUI_Project.Properties.cls_connection.connectDB();
                conn.Open();


                string query = "SELECT quantity FROM Items WHERE itemCategory = @category AND product = @product";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@category", category);
                cmd.Parameters.AddWithValue("@product", product);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        calc.ItemQty = reader.GetInt32("quantity");
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return false; 
            }
            finally
            {
                
            }
        }
   

        private void ValidateQty(string category, string product)
        {


            if (validate(category, product))
            {
                MySqlConnection conn = NIBM_GUI_Project.Properties.cls_connection.connectDB();
                conn.Open();

                string query = "SELECT quantity FROM Items WHERE itemCategory = '" + category + "' AND product ='" + product + "'";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        calc.ItemQty = reader.GetInt32("quantity");
                    }
                }

            }

        }

        private void ValidateCategoryProduct(string category, string product)
        {


            if (validate(category, product))
            {
                MySqlConnection conn = NIBM_GUI_Project.Properties.cls_connection.connectDB();
                conn.Open();

                string query = "SELECT sellingPrice FROM Items WHERE itemCategory = '"+category+"' AND product ='"+product+"'";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        calc.Selling_price = reader.GetDouble("sellingPrice");
                    }
                }
             
            }
           
        }


        string deliveryType;
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            try
            {
                

                if (cmbUProduct.SelectedIndex == -1 )
                {
                    MessageBox.Show("please select category and product");
                }
                else if (string.IsNullOrEmpty(txtQuantity.Text))
                {
                    MessageBox.Show("Please enter quantity");
                }else if (rdbNormal.Checked == false && rdbCashOn.Checked == false)
                {
                    MessageBox.Show("Delivery Type should be selected");
                }
                else
                {
                    string category = cmbUserCategory.Text;
                    string product = cmbUProduct.Text;

                    ValidateCategoryProduct(category, product);

                    calc.Quantity = Convert.ToInt32(txtQuantity.Text);

                    calc.totCal();

                    getQty(category, product);

                    MySqlConnection conn = NIBM_GUI_Project.Properties.cls_connection.connectDB();
                    conn.Open();

                    int qty = Convert.ToInt32(txtQuantity.Text);
                    double total_amt = calc.Tot;
                    if(rdbCashOn.Checked == true)
                    {
                        total_amt = total_amt + 5000;
                    }

                    
                   

                    txtPrice.Text = Convert.ToString(total_amt);

                    DialogResult result = MessageBox.Show("Do you want to proceed?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {   if(calc.ItemQty <= 0)
                        {
                            MessageBox.Show("Relevant items is out of stock");
                            
                        }
                        else
                        {
                            if (calc.ItemQty > qty)
                            {
                                string query = "INSERT INTO Orders(OitemCategory, Oproduct, Oquantity, deliveryType, Total_amt) VALUES ('" + category + "', '" + product + "', " + qty + " ,'" + deliveryType + "', " + total_amt + ")";
                                MySqlCommand cmd1 = new MySqlCommand(query, conn);
                                cmd1.ExecuteNonQuery();
                                MessageBox.Show("Values inserted");


                                calc.calcQty();
                                int totQty = calc.TotQty;
                                string query2 = "UPDATE Items SET quantity = " + totQty + " WHERE itemCategory = '" + category + "' AND product = '" + product + "'";
                                MySqlCommand cmd2 = new MySqlCommand(query2, conn);
                                cmd2.ExecuteNonQuery();
                            }
                            else
                            {
                                MessageBox.Show("required amount of items is not available");
                            }
                        }
                        
                    }
                    else
                    {

                    }




                }
            }catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);

            }
            finally
            {
                cmbUProduct.Items.Clear();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void picUMenuClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }


        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            frmHome home = new frmHome();
            home.Show();
            this.Close();
        }

        private void btnCart_Click(object sender, EventArgs e)
        {
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            deliveryType = "Normal";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            deliveryType = "Cash On Delivery";
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            frmLogin logout = new frmLogin();
            logout.Show();
            this.Close();
        }

        private void cmbUProduct_Click(object sender, EventArgs e)
        {
            fillCombos();
            
        }

        private void frmUserMenu_Click(object sender, EventArgs e)
        {
            
        }

        private void cmbUserCategory_Click(object sender, EventArgs e)
        {
            cmbUProduct.Items.Clear();
        }

        private void lblAdminMenu_Click(object sender, EventArgs e)
        {

        }
    }
}
