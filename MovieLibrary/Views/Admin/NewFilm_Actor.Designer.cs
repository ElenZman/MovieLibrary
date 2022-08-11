
namespace MovieLibrary.Views.Admin
{
    partial class NewFilm_Actor
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
            this.cBoxFilm = new System.Windows.Forms.ComboBox();
            this.cBoxActor = new System.Windows.Forms.ComboBox();
            this.lbFilm = new System.Windows.Forms.Label();
            this.lbActor = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lbInfo = new System.Windows.Forms.Label();
            this.lbHeading = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cBoxFilm
            // 
            this.cBoxFilm.FormattingEnabled = true;
            this.cBoxFilm.Location = new System.Drawing.Point(19, 122);
            this.cBoxFilm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cBoxFilm.Name = "cBoxFilm";
            this.cBoxFilm.Size = new System.Drawing.Size(151, 21);
            this.cBoxFilm.TabIndex = 0;
            // 
            // cBoxActor
            // 
            this.cBoxActor.FormattingEnabled = true;
            this.cBoxActor.Location = new System.Drawing.Point(198, 122);
            this.cBoxActor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cBoxActor.Name = "cBoxActor";
            this.cBoxActor.Size = new System.Drawing.Size(151, 21);
            this.cBoxActor.TabIndex = 1;
            // 
            // lbFilm
            // 
            this.lbFilm.AutoSize = true;
            this.lbFilm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbFilm.Location = new System.Drawing.Point(16, 97);
            this.lbFilm.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbFilm.Name = "lbFilm";
            this.lbFilm.Size = new System.Drawing.Size(41, 20);
            this.lbFilm.TabIndex = 2;
            this.lbFilm.Text = "Film";
            // 
            // lbActor
            // 
            this.lbActor.AutoSize = true;
            this.lbActor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbActor.Location = new System.Drawing.Point(195, 97);
            this.lbActor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbActor.Name = "lbActor";
            this.lbActor.Size = new System.Drawing.Size(49, 20);
            this.lbActor.TabIndex = 3;
            this.lbActor.Text = "Actor";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAdd.Location = new System.Drawing.Point(116, 155);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(130, 38);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add New";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lbInfo
            // 
            this.lbInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbInfo.Location = new System.Drawing.Point(16, 59);
            this.lbInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbInfo.Name = "lbInfo";
            this.lbInfo.Size = new System.Drawing.Size(347, 24);
            this.lbInfo.TabIndex = 5;
            // 
            // lbHeading
            // 
            this.lbHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbHeading.Location = new System.Drawing.Point(11, 18);
            this.lbHeading.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbHeading.Name = "lbHeading";
            this.lbHeading.Size = new System.Drawing.Size(342, 52);
            this.lbHeading.TabIndex = 6;
            this.lbHeading.Text = "Use dropboxes to select a film and an actor";
            this.lbHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NewFilm_Actor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 214);
            this.Controls.Add(this.lbHeading);
            this.Controls.Add(this.lbInfo);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lbActor);
            this.Controls.Add(this.lbFilm);
            this.Controls.Add(this.cBoxActor);
            this.Controls.Add(this.cBoxFilm);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "NewFilm_Actor";
            this.Text = "NewFilm_Actor";
            this.Load += new System.EventHandler(this.NewFilm_Actor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cBoxFilm;
        private System.Windows.Forms.ComboBox cBoxActor;
        private System.Windows.Forms.Label lbFilm;
        private System.Windows.Forms.Label lbActor;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lbInfo;
        private System.Windows.Forms.Label lbHeading;
    }
}