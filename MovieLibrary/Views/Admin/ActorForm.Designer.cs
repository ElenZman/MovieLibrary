
namespace MovieLibrary.Views.Admin
{
    partial class ActorForm
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
            this.lbInfo = new System.Windows.Forms.Label();
            this.btnAll = new System.Windows.Forms.Button();
            this.lbTableName = new System.Windows.Forms.Label();
            this.gbSearch = new System.Windows.Forms.GroupBox();
            this.lbSearchOption = new System.Windows.Forms.Label();
            this.textBoxEnterValue = new System.Windows.Forms.TextBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.lbEnterValue = new System.Windows.Forms.Label();
            this.comboBoxSearchOption = new System.Windows.Forms.ComboBox();
            this.btnUpsert = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.grid = new System.Windows.Forms.DataGridView();
            this.gbSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.SuspendLayout();
            // 
            // lbInfo
            // 
            this.lbInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbInfo.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbInfo.Location = new System.Drawing.Point(12, 46);
            this.lbInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbInfo.Name = "lbInfo";
            this.lbInfo.Size = new System.Drawing.Size(316, 24);
            this.lbInfo.TabIndex = 54;
            // 
            // btnAll
            // 
            this.btnAll.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAll.Location = new System.Drawing.Point(349, 10);
            this.btnAll.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(140, 49);
            this.btnAll.TabIndex = 53;
            this.btnAll.Text = "All";
            this.btnAll.UseVisualStyleBackColor = false;
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click_1);
            // 
            // lbTableName
            // 
            this.lbTableName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbTableName.Location = new System.Drawing.Point(9, 10);
            this.lbTableName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTableName.Name = "lbTableName";
            this.lbTableName.Size = new System.Drawing.Size(325, 33);
            this.lbTableName.TabIndex = 51;
            this.lbTableName.Text = "Table:";
            // 
            // gbSearch
            // 
            this.gbSearch.Controls.Add(this.lbSearchOption);
            this.gbSearch.Controls.Add(this.textBoxEnterValue);
            this.gbSearch.Controls.Add(this.btnFind);
            this.gbSearch.Controls.Add(this.lbEnterValue);
            this.gbSearch.Controls.Add(this.comboBoxSearchOption);
            this.gbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbSearch.Location = new System.Drawing.Point(12, 72);
            this.gbSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbSearch.Name = "gbSearch";
            this.gbSearch.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbSearch.Size = new System.Drawing.Size(322, 124);
            this.gbSearch.TabIndex = 49;
            this.gbSearch.TabStop = false;
            this.gbSearch.Text = "Search";
            // 
            // lbSearchOption
            // 
            this.lbSearchOption.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbSearchOption.Location = new System.Drawing.Point(4, 20);
            this.lbSearchOption.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbSearchOption.Name = "lbSearchOption";
            this.lbSearchOption.Size = new System.Drawing.Size(164, 23);
            this.lbSearchOption.TabIndex = 18;
            this.lbSearchOption.Text = "Search by:";
            // 
            // textBoxEnterValue
            // 
            this.textBoxEnterValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxEnterValue.Location = new System.Drawing.Point(178, 51);
            this.textBoxEnterValue.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxEnterValue.Multiline = true;
            this.textBoxEnterValue.Name = "textBoxEnterValue";
            this.textBoxEnterValue.Size = new System.Drawing.Size(140, 26);
            this.textBoxEnterValue.TabIndex = 23;
            // 
            // btnFind
            // 
            this.btnFind.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnFind.Location = new System.Drawing.Point(178, 81);
            this.btnFind.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(140, 32);
            this.btnFind.TabIndex = 25;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = false;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click_1);
            // 
            // lbEnterValue
            // 
            this.lbEnterValue.AutoSize = true;
            this.lbEnterValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbEnterValue.Location = new System.Drawing.Point(4, 51);
            this.lbEnterValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbEnterValue.Name = "lbEnterValue";
            this.lbEnterValue.Size = new System.Drawing.Size(125, 20);
            this.lbEnterValue.TabIndex = 29;
            this.lbEnterValue.Text = "Enter Name/ID:";
            // 
            // comboBoxSearchOption
            // 
            this.comboBoxSearchOption.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxSearchOption.FormattingEnabled = true;
            this.comboBoxSearchOption.Location = new System.Drawing.Point(178, 20);
            this.comboBoxSearchOption.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxSearchOption.Name = "comboBoxSearchOption";
            this.comboBoxSearchOption.Size = new System.Drawing.Size(140, 28);
            this.comboBoxSearchOption.TabIndex = 30;
            // 
            // btnUpsert
            // 
            this.btnUpsert.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnUpsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnUpsert.Location = new System.Drawing.Point(352, 75);
            this.btnUpsert.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnUpsert.Name = "btnUpsert";
            this.btnUpsert.Size = new System.Drawing.Size(140, 49);
            this.btnUpsert.TabIndex = 55;
            this.btnUpsert.Text = "New/Update";
            this.btnUpsert.UseVisualStyleBackColor = false;
            this.btnUpsert.Click += new System.EventHandler(this.btnUpsert_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDelete.Location = new System.Drawing.Point(352, 136);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(140, 49);
            this.btnDelete.TabIndex = 56;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // grid
            // 
            this.grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Location = new System.Drawing.Point(12, 201);
            this.grid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grid.Name = "grid";
            this.grid.RowHeadersWidth = 51;
            this.grid.RowTemplate.Height = 24;
            this.grid.Size = new System.Drawing.Size(479, 344);
            this.grid.TabIndex = 57;
            // 
            // ActorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 555);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpsert);
            this.Controls.Add(this.lbInfo);
            this.Controls.Add(this.btnAll);
            this.Controls.Add(this.lbTableName);
            this.Controls.Add(this.gbSearch);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ActorForm";
            this.Text = "Actors";
            this.Load += new System.EventHandler(this.ActorForm_Load);
            this.gbSearch.ResumeLayout(false);
            this.gbSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbInfo;
        private System.Windows.Forms.Button btnAll;
        private System.Windows.Forms.Label lbTableName;
        private System.Windows.Forms.GroupBox gbSearch;
        private System.Windows.Forms.Label lbSearchOption;
        private System.Windows.Forms.TextBox textBoxEnterValue;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Label lbEnterValue;
        private System.Windows.Forms.ComboBox comboBoxSearchOption;
        private System.Windows.Forms.Button btnUpsert;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView grid;
    }
}