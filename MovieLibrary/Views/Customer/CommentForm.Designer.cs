
namespace MovieLibrary.Views.Customer
{
    partial class CommentForm
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
            this.btnSend = new System.Windows.Forms.Button();
            this.tBoxComment = new System.Windows.Forms.TextBox();
            this.lbTypeYourComment = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSend
            // 
            this.btnSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSend.Location = new System.Drawing.Point(134, 389);
            this.btnSend.Margin = new System.Windows.Forms.Padding(4);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(216, 44);
            this.btnSend.TabIndex = 5;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click_1);
            // 
            // tBoxComment
            // 
            this.tBoxComment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tBoxComment.Location = new System.Drawing.Point(18, 60);
            this.tBoxComment.Margin = new System.Windows.Forms.Padding(4);
            this.tBoxComment.Multiline = true;
            this.tBoxComment.Name = "tBoxComment";
            this.tBoxComment.Size = new System.Drawing.Size(441, 308);
            this.tBoxComment.TabIndex = 4;
            // 
            // lbTypeYourComment
            // 
            this.lbTypeYourComment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbTypeYourComment.Location = new System.Drawing.Point(13, 9);
            this.lbTypeYourComment.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTypeYourComment.Name = "lbTypeYourComment";
            this.lbTypeYourComment.Size = new System.Drawing.Size(264, 28);
            this.lbTypeYourComment.TabIndex = 3;
            this.lbTypeYourComment.Text = "Type your comment here:";
            // 
            // CommentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 450);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.tBoxComment);
            this.Controls.Add(this.lbTypeYourComment);
            this.Name = "CommentForm";
            this.Text = "CommentForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox tBoxComment;
        private System.Windows.Forms.Label lbTypeYourComment;
    }
}