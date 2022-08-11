
namespace MovieLibrary.Views.Customer
{
    partial class AuthorizationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuthorizationForm));
            this.lbPassEmpty = new System.Windows.Forms.Label();
            this.lbLoginEmpty = new System.Windows.Forms.Label();
            this.lbInfo = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lbSignUp = new System.Windows.Forms.Label();
            this.btnSignIn = new System.Windows.Forms.Button();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.lbWelcome = new System.Windows.Forms.Label();
            this.pbFilm = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFilm)).BeginInit();
            this.SuspendLayout();
            // 
            // lbPassEmpty
            // 
            this.lbPassEmpty.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbPassEmpty.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbPassEmpty.Location = new System.Drawing.Point(135, 309);
            this.lbPassEmpty.Name = "lbPassEmpty";
            this.lbPassEmpty.Size = new System.Drawing.Size(133, 31);
            this.lbPassEmpty.TabIndex = 21;
            // 
            // lbLoginEmpty
            // 
            this.lbLoginEmpty.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbLoginEmpty.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbLoginEmpty.Location = new System.Drawing.Point(135, 227);
            this.lbLoginEmpty.Name = "lbLoginEmpty";
            this.lbLoginEmpty.Size = new System.Drawing.Size(133, 31);
            this.lbLoginEmpty.TabIndex = 20;
            // 
            // lbInfo
            // 
            this.lbInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbInfo.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbInfo.Location = new System.Drawing.Point(95, 395);
            this.lbInfo.Name = "lbInfo";
            this.lbInfo.Size = new System.Drawing.Size(341, 37);
            this.lbInfo.TabIndex = 19;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(67, 270);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(40, 37);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 18;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(67, 181);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 37);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // lbSignUp
            // 
            this.lbSignUp.BackColor = System.Drawing.Color.White;
            this.lbSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbSignUp.Location = new System.Drawing.Point(63, 443);
            this.lbSignUp.Name = "lbSignUp";
            this.lbSignUp.Size = new System.Drawing.Size(400, 28);
            this.lbSignUp.TabIndex = 16;
            this.lbSignUp.Text = "Don\'t have an account? Sign up.";
            this.lbSignUp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbSignUp.Click += new System.EventHandler(this.lbSignUp_Click);
            // 
            // btnSignIn
            // 
            this.btnSignIn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSignIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSignIn.Location = new System.Drawing.Point(135, 355);
            this.btnSignIn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(267, 37);
            this.btnSignIn.TabIndex = 15;
            this.btnSignIn.Text = "Sign In";
            this.btnSignIn.UseVisualStyleBackColor = false;
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
            // 
            // tbPassword
            // 
            this.tbPassword.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.tbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbPassword.ForeColor = System.Drawing.SystemColors.Window;
            this.tbPassword.Location = new System.Drawing.Point(135, 270);
            this.tbPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(265, 27);
            this.tbPassword.TabIndex = 14;
            this.tbPassword.UseSystemPasswordChar = true;
            // 
            // tbLogin
            // 
            this.tbLogin.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.tbLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbLogin.ForeColor = System.Drawing.SystemColors.Window;
            this.tbLogin.Location = new System.Drawing.Point(135, 181);
            this.tbLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbLogin.Multiline = true;
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(265, 36);
            this.tbLogin.TabIndex = 13;
            // 
            // lbWelcome
            // 
            this.lbWelcome.BackColor = System.Drawing.Color.White;
            this.lbWelcome.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbWelcome.Location = new System.Drawing.Point(91, 101);
            this.lbWelcome.Name = "lbWelcome";
            this.lbWelcome.Size = new System.Drawing.Size(461, 37);
            this.lbWelcome.TabIndex = 12;
            this.lbWelcome.Text = "Welcome to our Film Library!";
            // 
            // pbFilm
            // 
            this.pbFilm.Dock = System.Windows.Forms.DockStyle.Top;
            this.pbFilm.Image = ((System.Drawing.Image)(resources.GetObject("pbFilm.Image")));
            this.pbFilm.Location = new System.Drawing.Point(0, 0);
            this.pbFilm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbFilm.Name = "pbFilm";
            this.pbFilm.Size = new System.Drawing.Size(536, 89);
            this.pbFilm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbFilm.TabIndex = 11;
            this.pbFilm.TabStop = false;
            // 
            // AuthorizationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(536, 532);
            this.Controls.Add(this.lbPassEmpty);
            this.Controls.Add(this.lbLoginEmpty);
            this.Controls.Add(this.lbInfo);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lbSignUp);
            this.Controls.Add(this.btnSignIn);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbLogin);
            this.Controls.Add(this.lbWelcome);
            this.Controls.Add(this.pbFilm);
            this.Name = "AuthorizationForm";
            this.Text = "AuthorizationForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFilm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbPassEmpty;
        private System.Windows.Forms.Label lbLoginEmpty;
        private System.Windows.Forms.Label lbInfo;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lbSignUp;
        private System.Windows.Forms.Button btnSignIn;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.Label lbWelcome;
        private System.Windows.Forms.PictureBox pbFilm;
    }
}