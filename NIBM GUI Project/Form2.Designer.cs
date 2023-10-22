namespace NIBM_GUI_Project
{
    partial class frmLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblLoginEmail = new System.Windows.Forms.Label();
            this.txtLoginEmail = new System.Windows.Forms.TextBox();
            this.txtLoginPassword = new System.Windows.Forms.TextBox();
            this.lblLoginPassword = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.picLoginShow = new System.Windows.Forms.PictureBox();
            this.picLoginHide = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.picLoginClose = new System.Windows.Forms.PictureBox();
            this.picBoxLogLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picLoginShow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLoginHide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLoginClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.Location = new System.Drawing.Point(47, 22);
            this.lblLogin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(238, 13);
            this.lblLogin.TabIndex = 1;
            this.lblLogin.Text = "Computer Shop Management System | Log In";
            // 
            // lblLoginEmail
            // 
            this.lblLoginEmail.AutoSize = true;
            this.lblLoginEmail.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblLoginEmail.Location = new System.Drawing.Point(156, 313);
            this.lblLoginEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLoginEmail.Name = "lblLoginEmail";
            this.lblLoginEmail.Size = new System.Drawing.Size(36, 15);
            this.lblLoginEmail.TabIndex = 4;
            this.lblLoginEmail.Text = "Email";
            // 
            // txtLoginEmail
            // 
            this.txtLoginEmail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtLoginEmail.Location = new System.Drawing.Point(160, 333);
            this.txtLoginEmail.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtLoginEmail.Name = "txtLoginEmail";
            this.txtLoginEmail.Size = new System.Drawing.Size(339, 23);
            this.txtLoginEmail.TabIndex = 5;
            // 
            // txtLoginPassword
            // 
            this.txtLoginPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtLoginPassword.Location = new System.Drawing.Point(160, 392);
            this.txtLoginPassword.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtLoginPassword.Name = "txtLoginPassword";
            this.txtLoginPassword.Size = new System.Drawing.Size(313, 23);
            this.txtLoginPassword.TabIndex = 7;
            this.txtLoginPassword.UseSystemPasswordChar = true;
            // 
            // lblLoginPassword
            // 
            this.lblLoginPassword.AutoSize = true;
            this.lblLoginPassword.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblLoginPassword.Location = new System.Drawing.Point(156, 372);
            this.lblLoginPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLoginPassword.Name = "lblLoginPassword";
            this.lblLoginPassword.Size = new System.Drawing.Size(57, 15);
            this.lblLoginPassword.TabIndex = 6;
            this.lblLoginPassword.Text = "Password";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(133)))), ((int)(((byte)(244)))));
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLogin.Location = new System.Drawing.Point(160, 479);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(335, 38);
            this.btnLogin.TabIndex = 10;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // picLoginShow
            // 
            this.picLoginShow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picLoginShow.Image = global::NIBM_GUI_Project.Properties.Resources.show_password_icon_3;
            this.picLoginShow.Location = new System.Drawing.Point(472, 392);
            this.picLoginShow.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.picLoginShow.Name = "picLoginShow";
            this.picLoginShow.Size = new System.Drawing.Size(23, 23);
            this.picLoginShow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLoginShow.TabIndex = 9;
            this.picLoginShow.TabStop = false;
            this.picLoginShow.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // picLoginHide
            // 
            this.picLoginHide.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picLoginHide.Image = global::NIBM_GUI_Project.Properties.Resources._481_4810872_hide_password_hide_show_password_icon_png_transparent;
            this.picLoginHide.Location = new System.Drawing.Point(472, 392);
            this.picLoginHide.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.picLoginHide.Name = "picLoginHide";
            this.picLoginHide.Size = new System.Drawing.Size(23, 23);
            this.picLoginHide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLoginHide.TabIndex = 8;
            this.picLoginHide.TabStop = false;
            this.picLoginHide.Click += new System.EventHandler(this.picLoginHide_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::NIBM_GUI_Project.Properties.Resources._1635411564639;
            this.pictureBox2.Location = new System.Drawing.Point(206, 39);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(233, 231);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // picLoginClose
            // 
            this.picLoginClose.Image = global::NIBM_GUI_Project.Properties.Resources.download__1_;
            this.picLoginClose.Location = new System.Drawing.Point(606, 14);
            this.picLoginClose.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.picLoginClose.Name = "picLoginClose";
            this.picLoginClose.Size = new System.Drawing.Size(37, 37);
            this.picLoginClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLoginClose.TabIndex = 2;
            this.picLoginClose.TabStop = false;
            this.picLoginClose.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // picBoxLogLogo
            // 
            this.picBoxLogLogo.Image = global::NIBM_GUI_Project.Properties.Resources.download;
            this.picBoxLogLogo.Location = new System.Drawing.Point(14, 14);
            this.picBoxLogLogo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.picBoxLogLogo.Name = "picBoxLogLogo";
            this.picBoxLogLogo.Size = new System.Drawing.Size(32, 32);
            this.picBoxLogLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxLogLogo.TabIndex = 0;
            this.picBoxLogLogo.TabStop = false;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(662, 646);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtLoginPassword);
            this.Controls.Add(this.picLoginShow);
            this.Controls.Add(this.picLoginHide);
            this.Controls.Add(this.lblLoginPassword);
            this.Controls.Add(this.txtLoginEmail);
            this.Controls.Add(this.lblLoginEmail);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.picLoginClose);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.picBoxLogLogo);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Computer Shop Managament System | Log In";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picLoginShow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLoginHide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLoginClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBoxLogLogo;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.PictureBox picLoginClose;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblLoginEmail;
        private System.Windows.Forms.TextBox txtLoginEmail;
        private System.Windows.Forms.TextBox txtLoginPassword;
        private System.Windows.Forms.Label lblLoginPassword;
        private System.Windows.Forms.PictureBox picLoginHide;
        private System.Windows.Forms.PictureBox picLoginShow;
        private System.Windows.Forms.Button btnLogin;
    }
}