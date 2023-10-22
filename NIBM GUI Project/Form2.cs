using MySql.Data.MySqlClient;
using NIBM_GUI_Project.Properties;
using NIBM_GUI_Project.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace NIBM_GUI_Project
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (picLoginShow.Visible == true)
            {
                txtLoginPassword.UseSystemPasswordChar = false;
                picLoginShow.Visible = false;
                picLoginHide.Visible = true;
            }
        }

        private void picLoginHide_Click(object sender, EventArgs e)
        {
            if (picLoginHide.Visible == true)
            {
                txtLoginPassword.UseSystemPasswordChar = true;
                picLoginShow.Visible = true;
                picLoginHide.Visible = false;
            }
        }
        public bool ValidateUser(string email, string password)
        {
            try
            {

                MySqlConnection conn = NIBM_GUI_Project.Properties.cls_connection.connectDB();
                conn.Open();


                string query = "SELECT * FROM userSignUp WHERE userEmail = @Email AND userPassword = @UserPassword";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@UserPassword", password);

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
  
        }

        private void ValidateUserAndLogin(string email, string password)
        {

            if (ValidateUser(email, password))
            {
                frmHome home = new frmHome();
                home.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid email or password. Please try again.");
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtLoginEmail.Text) || string.IsNullOrEmpty(txtLoginPassword.Text))
            {
                MessageBox.Show("Text Fields cannot be empty");
            }
            else
            {
                string userEmail = txtLoginEmail.Text;
                string userPassword = txtLoginPassword.Text;

                ValidateUserAndLogin(userEmail, userPassword);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            frmSignUp signUp = new frmSignUp();
            signUp.Show();
            this.Close();
        }
    }
}
