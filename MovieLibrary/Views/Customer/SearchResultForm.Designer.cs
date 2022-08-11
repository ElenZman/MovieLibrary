
namespace MovieLibrary.Views.Customer
{
    partial class SearchResultForm
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
            this.lbSearchResults = new System.Windows.Forms.Label();
            this.viewSearchResult = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // lbSearchResults
            // 
            this.lbSearchResults.AutoSize = true;
            this.lbSearchResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbSearchResults.Location = new System.Drawing.Point(15, 22);
            this.lbSearchResults.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbSearchResults.Name = "lbSearchResults";
            this.lbSearchResults.Size = new System.Drawing.Size(150, 20);
            this.lbSearchResults.TabIndex = 3;
            this.lbSearchResults.Text = "Search Results: ";
            // 
            // viewSearchResult
            // 
            this.viewSearchResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.viewSearchResult.FullRowSelect = true;
            this.viewSearchResult.HideSelection = false;
            this.viewSearchResult.Location = new System.Drawing.Point(14, 57);
            this.viewSearchResult.Margin = new System.Windows.Forms.Padding(6);
            this.viewSearchResult.MultiSelect = false;
            this.viewSearchResult.Name = "viewSearchResult";
            this.viewSearchResult.Size = new System.Drawing.Size(958, 368);
            this.viewSearchResult.TabIndex = 2;
            this.viewSearchResult.UseCompatibleStateImageBehavior = false;
            this.viewSearchResult.View = System.Windows.Forms.View.Details;
            this.viewSearchResult.SelectedIndexChanged += new System.EventHandler(this.viewSearchResult_SelectedIndexChanged);
            // 
            // SearchResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(987, 440);
            this.Controls.Add(this.lbSearchResults);
            this.Controls.Add(this.viewSearchResult);
            this.Name = "SearchResultForm";
            this.Text = "SearchResults";
            this.Load += new System.EventHandler(this.SearchResultForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbSearchResults;
        private System.Windows.Forms.ListView viewSearchResult;
    }
}