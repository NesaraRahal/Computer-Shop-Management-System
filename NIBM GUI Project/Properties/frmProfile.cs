using MySql.Data.MySqlClient;
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
using System.Xml.Linq;

namespace NIBM_GUI_Project.Properties
{
    public partial class frmProfile : Form
    {
        public frmProfile()
        {
            InitializeComponent();
        }

        private void picUMenuClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (picShow.Visible == true)
            {
                txtPassword.UseSystemPasswordChar = false;
                picShow.Visible = false;
                picHide.Visible = true;
            }
        }

        private void picShoe_Click(object sender, EventArgs e)
        {

            if (picHide.Visible == true)
            {
                txtPassword.UseSystemPasswordChar =true;
                picShow.Visible = true;
                picHide.Visible = false;
            }
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            frmProfile profile = new frmProfile();
            profile.Show();
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Text Fields cannot be null");
            }
            else
            {
                String email = txtEmail.Text;
                String password = txtPassword.Text;

                try
                {
                    DialogResult result = MessageBox.Show("Do you want to Add new email and password to your profile? Once you add a new email and password you need to insert a new email and password to login and the old email and password will not be valid", "Configurations", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        using (MySqlConnection conn = NIBM_GUI_Project.Properties.cls_connection.connectDB())
                        {
                            conn.Open();

                            // Delete all rows from AdminLogin
                            string profileReset = "DELETE FROM AdminLogin";
                            using (MySqlCommand cmd = new MySqlCommand(profileReset, conn))
                            {
                                cmd.ExecuteNonQuery();
                            }

                            // Insert new email and password
                            string newProfile = "INSERT INTO AdminLogin(AdminEmail, AdminPassword) VALUES ('" + email + "', '" + password + "')";
                            using (MySqlCommand cmd1 = new MySqlCommand(newProfile, conn))
                            {
                                cmd1.ExecuteNonQuery();
                            }

                            MessageBox.Show("Profile Updated");

                            frmAdminLogin newLogin = new frmAdminLogin();
                            newLogin.Show();
                            this.Close();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    txtEmail.Clear();
                    txtPassword.Clear();
                }
            }
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            frmDashboard dashboard = new frmDashboard();
            dashboard.Show();
            this.Close();
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            frmMenu menu = new frmMenu();
            menu.Show();
            this.Close();
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            frmOrders orders = new frmOrders();
            orders.Show();
            this.Close ();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            frmAdminLogin login = new frmAdminLogin();
            login.Show();
            this.Close();
        }
    }
    }
    

