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
    public partial class frmAdminLogin : Form
    {
        public frmAdminLogin()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void picAdminShow_Click(object sender, EventArgs e)
        {
            if (picAdminShow.Visible == true)
            {
                txtAdminPassword.UseSystemPasswordChar = false;
                picAdminShow.Visible = false;
                picAdminHide.Visible = true;
            }
        }

        private void picAdminHide_Click(object sender, EventArgs e)
        {
            if (picAdminHide.Visible == true)
            {
                txtAdminPassword.UseSystemPasswordChar = true;
                picAdminShow.Visible = true;
                picAdminHide.Visible = false;
            }
        }

        public bool ValidateUser(string aemail, string apassword)
        {
            try
            {

                MySqlConnection conn = NIBM_GUI_Project.Properties.cls_connection.connectDB();
                conn.Open();


                string query = "SELECT * FROM adminLogin WHERE adminEmail = @Email AND adminPassword = @UserPassword";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@Email", aemail);
                cmd.Parameters.AddWithValue("@UserPassword", apassword);

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
        private void ValidateUserAndLogin(string aemail, string apassword)
        {

            if (ValidateUser(aemail, apassword))
            {
                frmDashboard dashboard = new frmDashboard();
                dashboard.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid email or password. Please try again.");
            }
        }

        private void btnAdminLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtAdminEmail.Text) || string.IsNullOrEmpty(txtAdminPassword.Text))
            {
                MessageBox.Show("Text Fields cannot be empty");
            }
            else
            {
                string userEmail = txtAdminEmail.Text;
                string userPassword = txtAdminPassword.Text;

                ValidateUserAndLogin(userEmail, userPassword);
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            frmRole role = new frmRole();
            role.Show();
            this.Close();
        }
    }
}
