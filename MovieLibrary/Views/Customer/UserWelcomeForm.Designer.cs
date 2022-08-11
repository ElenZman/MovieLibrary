
namespace MovieLibrary.Views.Customer
{
    partial class UserWelcomeForm
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
            this.lbGreetings = new System.Windows.Forms.Label();
            this.lbWelcome = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tbUserInput = new System.Windows.Forms.TextBox();
            this.cBoxActors = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbGreetings
            // 
            this.lbGreetings.AutoSize = true;
            this.lbGreetings.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbGreetings.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbGreetings.Location = new System.Drawing.Point(189, 19);
            this.lbGreetings.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbGreetings.Name = "lbGreetings";
            this.lbGreetings.Size = new System.Drawing.Size(39, 24);
            this.lbGreetings.TabIndex = 41;
            this.lbGreetings.Text = "Hi,";
            this.lbGreetings.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbWelcome
            // 
            this.lbWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbWelcome.Location = new System.Drawing.Point(114, 70);
            this.lbWelcome.Name = "lbWelcome";
            this.lbWelcome.Size = new System.Drawing.Size(473, 51);
            this.lbWelcome.TabIndex = 42;
            this.lbWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnSearch.Location = new System.Drawing.Point(233, 208);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(253, 37);
            this.btnSearch.TabIndex = 43;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tbUserInput
            // 
            this.tbUserInput.BackColor = System.Drawing.Color.White;
            this.tbUserInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbUserInput.Location = new System.Drawing.Point(18, 153);
            this.tbUserInput.Multiline = true;
            this.tbUserInput.Name = "tbUserInput";
            this.tbUserInput.Size = new System.Drawing.Size(240, 27);
            this.tbUserInput.TabIndex = 58;
            this.tbUserInput.Enter += new System.EventHandler(this.tbUserInput_Enter);
            // 
            // cBoxActors
            // 
            this.cBoxActors.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cBoxActors.FormattingEnabled = true;
            this.cBoxActors.Location = new System.Drawing.Point(435, 153);
            this.cBoxActors.Name = "cBoxActors";
            this.cBoxActors.Size = new System.Drawing.Size(270, 28);
            this.cBoxActors.TabIndex = 59;
            this.cBoxActors.Enter += new System.EventHandler(this.comboBox1_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(332, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 20);
            this.label1.TabIndex = 60;
            this.label1.Text = "or";
            // 
            // UserWelcomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 277);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cBoxActors);
            this.Controls.Add(this.tbUserInput);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lbWelcome);
            this.Controls.Add(this.lbGreetings);
            this.Name = "UserWelcomeForm";
            this.Text = "UserWelcomeForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UserWelcomeForm_FormClosed);
            this.Load += new System.EventHandler(this.UserWelcomeForm_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbGreetings;
        private System.Windows.Forms.Label lbWelcome;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox tbUserInput;
        private System.Windows.Forms.ComboBox cBoxActors;
        private System.Windows.Forms.Label label1;
    }
}