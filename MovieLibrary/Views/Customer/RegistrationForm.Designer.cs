
namespace MovieLibrary.Views.Customer
{
    partial class RegistrationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrationForm));
            this.lbPassEmpty = new System.Windows.Forms.Label();
            this.lbLoginEmpty = new System.Windows.Forms.Label();
            this.pbPass = new System.Windows.Forms.PictureBox();
            this.pbLogin = new System.Windows.Forms.PictureBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.lbInfo = new System.Windows.Forms.Label();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.pbFilm = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFilm)).BeginInit();
            this.SuspendLayout();
            // 
            // lbPassEmpty
            // 
            this.lbPassEmpty.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbPassEmpty.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbPassEmpty.Location = new System.Drawing.Point(124, 341);
            this.lbPassEmpty.Name = "lbPassEmpty";
            this.lbPassEmpty.Size = new System.Drawing.Size(133, 31);
            this.lbPassEmpty.TabIndex = 31;
            // 
            // lbLoginEmpty
            // 
            this.lbLoginEmpty.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbLoginEmpty.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbLoginEmpty.Location = new System.Drawing.Point(124, 256);
            this.lbLoginEmpty.Name = "lbLoginEmpty";
            this.lbLoginEmpty.Size = new System.Drawing.Size(133, 31);
            this.lbLoginEmpty.TabIndex = 30;
            // 
            // pbPass
            // 
            this.pbPass.Image = ((System.Drawing.Image)(resources.GetObject("pbPass.Image")));
            this.pbPass.Location = new System.Drawing.Point(55, 302);
            this.pbPass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbPass.Name = "pbPass";
            this.pbPass.Size = new System.Drawing.Size(36, 33);
            this.pbPass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPass.TabIndex = 29;
            this.pbPass.TabStop = false;
            // 
            // pbLogin
            // 
            this.pbLogin.Image = ((System.Drawing.Image)(resources.GetObject("pbLogin.Image")));
            this.pbLogin.Location = new System.Drawing.Point(55, 217);
            this.pbLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbLogin.Name = "pbLogin";
            this.pbLogin.Size = new System.Drawing.Size(36, 33);
            this.pbLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogin.TabIndex = 28;
            this.pbLogin.TabStop = false;
            // 
            // tbPassword
            // 
            this.tbPassword.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.tbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbPassword.ForeColor = System.Drawing.SystemColors.Window;
            this.tbPassword.Location = new System.Drawing.Point(123, 305);
            this.tbPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(265, 27);
            this.tbPassword.TabIndex = 27;
            this.tbPassword.UseSystemPasswordChar = true;
            // 
            // tbLogin
            // 
            this.tbLogin.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.tbLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbLogin.ForeColor = System.Drawing.SystemColors.Window;
            this.tbLogin.Location = new System.Drawing.Point(123, 220);
            this.tbLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbLogin.Multiline = true;
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(265, 32);
            this.tbLogin.TabIndex = 26;
            // 
            // lbInfo
            // 
            this.lbInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbInfo.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbInfo.Location = new System.Drawing.Point(123, 364);
            this.lbInfo.Name = "lbInfo";
            this.lbInfo.Size = new System.Drawing.Size(267, 42);
            this.lbInfo.TabIndex = 25;
            this.lbInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSignUp
            // 
            this.btnSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSignUp.Location = new System.Drawing.Point(123, 430);
            this.btnSignUp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(267, 39);
            this.btnSignUp.TabIndex = 24;
            this.btnSignUp.Text = "Sign Up";
            this.btnSignUp.UseVisualStyleBackColor = true;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // pbFilm
            // 
            this.pbFilm.Dock = System.Windows.Forms.DockStyle.Top;
            this.pbFilm.Image = ((System.Drawing.Image)(resources.GetObject("pbFilm.Image")));
            this.pbFilm.Location = new System.Drawing.Point(0, 0);
            this.pbFilm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbFilm.Name = "pbFilm";
            this.pbFilm.Size = new System.Drawing.Size(489, 89);
            this.pbFilm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbFilm.TabIndex = 23;
            this.pbFilm.TabStop = false;
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(489, 555);
            this.Controls.Add(this.lbPassEmpty);
            this.Controls.Add(this.lbLoginEmpty);
            this.Controls.Add(this.pbPass);
            this.Controls.Add(this.pbLogin);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbLogin);
            this.Controls.Add(this.lbInfo);
            this.Controls.Add(this.btnSignUp);
            this.Controls.Add(this.pbFilm);
            this.Name = "RegistrationForm";
            this.Text = "RegistrationForm";
            ((System.ComponentModel.ISupportInitialize)(this.pbPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFilm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbPassEmpty;
        private System.Windows.Forms.Label lbLoginEmpty;
        private System.Windows.Forms.PictureBox pbPass;
        private System.Windows.Forms.PictureBox pbLogin;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.Label lbInfo;
        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.PictureBox pbFilm;
    }
}