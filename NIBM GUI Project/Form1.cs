using MySql.Data.MySqlClient;
using NIBM_GUI_Project.Properties;
using NIBM_GUI_Project.Resources;
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
    public partial class frmSignUp : Form
    {
        public frmSignUp()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void picClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void picShow_Click(object sender, EventArgs e)
        {
            if(picShow.Visible == true)
            {
                txtPassword.UseSystemPasswordChar = false;
                picShow.Visible = false;
                picHide.Visible = true;
            }
        }

        private void picHide_Click(object sender, EventArgs e)
        {
            if (picHide.Visible == true)
            {
                txtPassword.UseSystemPasswordChar = true;
                picShow.Visible = true;
                picHide.Visible = false;
            }
        }

        private void lblAccount_Click(object sender, EventArgs e)
        {
            frmLogin login  = new frmLogin();
            login.Show();

            this.Hide();
        }

        private void lblAccount_Click(object sender, EventArgs e, frmLogin frmLogin)
        {
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(txtPassword.Text))
                {
                MessageBox.Show("Text Fields cannot be null");
            }
            else
            {

                String name = txtUsername.Text;
                String email = txtEmail.Text;
                String password = txtPassword.Text;
                try
                {

                    MySqlConnection conn = NIBM_GUI_Project.Properties.cls_connection.connectDB();
                    conn.Open();

                    string emailCheck = "SELECT COUNT(*) FROM userSignUp WHERE userEmail = @Email";
                    using (MySqlCommand cmd = new MySqlCommand(emailCheck, conn))
                    {
                        
                        cmd.Parameters.AddWithValue("@Email", email);
                        int count = Convert.ToInt32(cmd.ExecuteScalar());


                        if (count > 0)
                        {
                            MessageBox.Show("That email is already taken try using a another email");
                        }
                        else
                        {

                            string query = "INSERT INTO userSignUp(userEmail, userName, userPassword) VALUES ('" + email + "', '" + name + "', '" + password + "')";
                            MySqlCommand cmd1 = new MySqlCommand(query, conn);
                            cmd1.ExecuteNonQuery();
                            MessageBox.Show("Values inserted");
                        }
                    }
   

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    txtUsername.Clear();
                    txtEmail.Clear();
                    txtPassword.Clear();
                    
                }
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
