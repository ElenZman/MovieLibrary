
namespace MovieLibrary.Views.Admin
{
    partial class FilmsActorsForm
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
            this.components = new System.ComponentModel.Container();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lbInfo = new System.Windows.Forms.Label();
            this.btnAll = new System.Windows.Forms.Button();
            this.lbTableName = new System.Windows.Forms.Label();
            this.grid = new System.Windows.Forms.DataGridView();
            this.gbSearch = new System.Windows.Forms.GroupBox();
            this.lbSearchOption = new System.Windows.Forms.Label();
            this.cBoxFilm = new System.Windows.Forms.ComboBox();
            this.cBoxActor = new System.Windows.Forms.ComboBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.lbFilm = new System.Windows.Forms.Label();
            this.comboBoxSearchOption = new System.Windows.Forms.ComboBox();
            this.lbActor = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.btnNew = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.gbSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDelete.Location = new System.Drawing.Point(357, 137);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(140, 41);
            this.btnDelete.TabIndex = 96;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lbInfo
            // 
            this.lbInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbInfo.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbInfo.Location = new System.Drawing.Point(11, 271);
            this.lbInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbInfo.Name = "lbInfo";
            this.lbInfo.Size = new System.Drawing.Size(359, 23);
            this.lbInfo.TabIndex = 94;
            // 
            // btnAll
            // 
            this.btnAll.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAll.Location = new System.Drawing.Point(356, 45);
            this.btnAll.Margin = new System.Windows.Forms.Padding(2);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(142, 41);
            this.btnAll.TabIndex = 93;
            this.btnAll.Text = "All";
            this.btnAll.UseVisualStyleBackColor = false;
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // lbTableName
            // 
            this.lbTableName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbTableName.Location = new System.Drawing.Point(9, 7);
            this.lbTableName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTableName.Name = "lbTableName";
            this.lbTableName.Size = new System.Drawing.Size(357, 28);
            this.lbTableName.TabIndex = 91;
            this.lbTableName.Text = "Table:";
            // 
            // grid
            // 
            this.grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Location = new System.Drawing.Point(11, 301);
            this.grid.Margin = new System.Windows.Forms.Padding(2);
            this.grid.Name = "grid";
            this.grid.RowHeadersWidth = 51;
            this.grid.RowTemplate.Height = 24;
            this.grid.Size = new System.Drawing.Size(499, 286);
            this.grid.TabIndex = 90;
            // 
            // gbSearch
            // 
            this.gbSearch.Controls.Add(this.lbSearchOption);
            this.gbSearch.Controls.Add(this.cBoxFilm);
            this.gbSearch.Controls.Add(this.cBoxActor);
            this.gbSearch.Controls.Add(this.btnFind);
            this.gbSearch.Controls.Add(this.lbFilm);
            this.gbSearch.Controls.Add(this.comboBoxSearchOption);
            this.gbSearch.Controls.Add(this.lbActor);
            this.gbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbSearch.Location = new System.Drawing.Point(13, 37);
            this.gbSearch.Margin = new System.Windows.Forms.Padding(2);
            this.gbSearch.Name = "gbSearch";
            this.gbSearch.Padding = new System.Windows.Forms.Padding(2);
            this.gbSearch.Size = new System.Drawing.Size(264, 220);
            this.gbSearch.TabIndex = 89;
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
            // cBoxFilm
            // 
            this.cBoxFilm.FormattingEnabled = true;
            this.cBoxFilm.Location = new System.Drawing.Point(55, 126);
            this.cBoxFilm.Margin = new System.Windows.Forms.Padding(2);
            this.cBoxFilm.Name = "cBoxFilm";
            this.cBoxFilm.Size = new System.Drawing.Size(200, 28);
            this.cBoxFilm.TabIndex = 100;
            // 
            // cBoxActor
            // 
            this.cBoxActor.FormattingEnabled = true;
            this.cBoxActor.Location = new System.Drawing.Point(57, 88);
            this.cBoxActor.Margin = new System.Windows.Forms.Padding(2);
            this.cBoxActor.Name = "cBoxActor";
            this.cBoxActor.Size = new System.Drawing.Size(198, 28);
            this.cBoxActor.TabIndex = 99;
            // 
            // btnFind
            // 
            this.btnFind.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnFind.Location = new System.Drawing.Point(8, 171);
            this.btnFind.Margin = new System.Windows.Forms.Padding(2);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(160, 32);
            this.btnFind.TabIndex = 25;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = false;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click_1);
            // 
            // lbFilm
            // 
            this.lbFilm.AutoSize = true;
            this.lbFilm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbFilm.Location = new System.Drawing.Point(12, 126);
            this.lbFilm.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbFilm.Name = "lbFilm";
            this.lbFilm.Size = new System.Drawing.Size(46, 20);
            this.lbFilm.TabIndex = 98;
            this.lbFilm.Text = "Film:";
            // 
            // comboBoxSearchOption
            // 
            this.comboBoxSearchOption.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxSearchOption.FormattingEnabled = true;
            this.comboBoxSearchOption.Location = new System.Drawing.Point(8, 45);
            this.comboBoxSearchOption.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxSearchOption.Name = "comboBoxSearchOption";
            this.comboBoxSearchOption.Size = new System.Drawing.Size(160, 28);
            this.comboBoxSearchOption.TabIndex = 30;
            // 
            // lbActor
            // 
            this.lbActor.AutoSize = true;
            this.lbActor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbActor.Location = new System.Drawing.Point(4, 86);
            this.lbActor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbActor.Name = "lbActor";
            this.lbActor.Size = new System.Drawing.Size(54, 20);
            this.lbActor.TabIndex = 97;
            this.lbActor.Text = "Actor:";
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnNew.Location = new System.Drawing.Point(356, 92);
            this.btnNew.Margin = new System.Windows.Forms.Padding(2);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(140, 41);
            this.btnNew.TabIndex = 101;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnUpdate.Location = new System.Drawing.Point(356, 182);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(140, 41);
            this.btnUpdate.TabIndex = 102;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // FilmsActorsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 598);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lbInfo);
            this.Controls.Add(this.btnAll);
            this.Controls.Add(this.lbTableName);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.gbSearch);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FilmsActorsForm";
            this.Text = "Films-Actors";
            this.Load += new System.EventHandler(this.FilmsActorsForm_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.gbSearch.ResumeLayout(false);
            this.gbSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lbInfo;
        private System.Windows.Forms.Button btnAll;
        private System.Windows.Forms.Label lbTableName;
        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.GroupBox gbSearch;
        private System.Windows.Forms.Label lbSearchOption;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.ComboBox comboBoxSearchOption;
        private System.Windows.Forms.Label lbActor;
        private System.Windows.Forms.Label lbFilm;
        private System.Windows.Forms.ComboBox cBoxActor;
        private System.Windows.Forms.ComboBox cBoxFilm;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnUpdate;
    }
}