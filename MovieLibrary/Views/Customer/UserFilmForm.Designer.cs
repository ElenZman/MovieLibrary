
namespace MovieLibrary.Views.Customer
{
    partial class UserFilmForm
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
            this.btnComment = new System.Windows.Forms.Button();
            this.lbComments = new System.Windows.Forms.Label();
            this.summary = new System.Windows.Forms.Label();
            this.lbSummary = new System.Windows.Forms.Label();
            this.cBoxRate = new System.Windows.Forms.ComboBox();
            this.cast = new System.Windows.Forms.Label();
            this.lbCast = new System.Windows.Forms.Label();
            this.country = new System.Windows.Forms.Label();
            this.lbCountry = new System.Windows.Forms.Label();
            this.btnRate = new System.Windows.Forms.Button();
            this.pBoxPoster = new System.Windows.Forms.PictureBox();
            this.rate = new System.Windows.Forms.Label();
            this.lbRate = new System.Windows.Forms.Label();
            this.director = new System.Windows.Forms.Label();
            this.lbDirector = new System.Windows.Forms.Label();
            this.genre = new System.Windows.Forms.Label();
            this.year = new System.Windows.Forms.Label();
            this.movieName = new System.Windows.Forms.Label();
            this.lbGenre = new System.Windows.Forms.Label();
            this.lbYear = new System.Windows.Forms.Label();
            this.lbFilmName = new System.Windows.Forms.Label();
            this.comments = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxPoster)).BeginInit();
            this.SuspendLayout();
            // 
            // btnComment
            // 
            this.btnComment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnComment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnComment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnComment.ImageKey = "(отсутствует)";
            this.btnComment.Location = new System.Drawing.Point(746, 321);
            this.btnComment.Margin = new System.Windows.Forms.Padding(4);
            this.btnComment.Name = "btnComment";
            this.btnComment.Size = new System.Drawing.Size(140, 37);
            this.btnComment.TabIndex = 44;
            this.btnComment.Text = "Comment";
            this.btnComment.UseVisualStyleBackColor = true;
            this.btnComment.Click += new System.EventHandler(this.btnComment_Click_1);
            // 
            // lbComments
            // 
            this.lbComments.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbComments.ForeColor = System.Drawing.Color.Black;
            this.lbComments.Location = new System.Drawing.Point(13, 443);
            this.lbComments.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbComments.Name = "lbComments";
            this.lbComments.Size = new System.Drawing.Size(133, 28);
            this.lbComments.TabIndex = 42;
            this.lbComments.Text = "Comments:";
            // 
            // summary
            // 
            this.summary.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.summary.ForeColor = System.Drawing.Color.Black;
            this.summary.Location = new System.Drawing.Point(13, 368);
            this.summary.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.summary.Name = "summary";
            this.summary.Size = new System.Drawing.Size(868, 75);
            this.summary.TabIndex = 41;
            // 
            // lbSummary
            // 
            this.lbSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbSummary.ForeColor = System.Drawing.Color.Black;
            this.lbSummary.Location = new System.Drawing.Point(13, 339);
            this.lbSummary.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSummary.Name = "lbSummary";
            this.lbSummary.Size = new System.Drawing.Size(133, 28);
            this.lbSummary.TabIndex = 40;
            this.lbSummary.Text = "Summary:";
            // 
            // cBoxRate
            // 
            this.cBoxRate.DropDownHeight = 160;
            this.cBoxRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cBoxRate.FormattingEnabled = true;
            this.cBoxRate.IntegralHeight = false;
            this.cBoxRate.ItemHeight = 20;
            this.cBoxRate.Items.AddRange(new object[] {
            "5",
            "4",
            "3",
            "2",
            "1"});
            this.cBoxRate.Location = new System.Drawing.Point(652, 323);
            this.cBoxRate.Margin = new System.Windows.Forms.Padding(4);
            this.cBoxRate.Name = "cBoxRate";
            this.cBoxRate.Size = new System.Drawing.Size(83, 28);
            this.cBoxRate.TabIndex = 39;
            // 
            // cast
            // 
            this.cast.AutoEllipsis = true;
            this.cast.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cast.ForeColor = System.Drawing.Color.Black;
            this.cast.Location = new System.Drawing.Point(457, 172);
            this.cast.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cast.Name = "cast";
            this.cast.Size = new System.Drawing.Size(315, 70);
            this.cast.TabIndex = 38;
            // 
            // lbCast
            // 
            this.lbCast.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbCast.ForeColor = System.Drawing.Color.Black;
            this.lbCast.Location = new System.Drawing.Point(316, 172);
            this.lbCast.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCast.Name = "lbCast";
            this.lbCast.Size = new System.Drawing.Size(141, 28);
            this.lbCast.TabIndex = 37;
            this.lbCast.Text = "Cast:";
            // 
            // country
            // 
            this.country.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.country.ForeColor = System.Drawing.Color.Black;
            this.country.Location = new System.Drawing.Point(457, 289);
            this.country.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.country.Name = "country";
            this.country.Size = new System.Drawing.Size(373, 28);
            this.country.TabIndex = 36;
            // 
            // lbCountry
            // 
            this.lbCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbCountry.ForeColor = System.Drawing.Color.Black;
            this.lbCountry.Location = new System.Drawing.Point(316, 289);
            this.lbCountry.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCountry.Name = "lbCountry";
            this.lbCountry.Size = new System.Drawing.Size(141, 28);
            this.lbCountry.TabIndex = 35;
            this.lbCountry.Text = "Country:";
            // 
            // btnRate
            // 
            this.btnRate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRate.ImageKey = "(отсутствует)";
            this.btnRate.Location = new System.Drawing.Point(504, 321);
            this.btnRate.Margin = new System.Windows.Forms.Padding(4);
            this.btnRate.Name = "btnRate";
            this.btnRate.Size = new System.Drawing.Size(140, 37);
            this.btnRate.TabIndex = 34;
            this.btnRate.Text = "Rate";
            this.btnRate.UseVisualStyleBackColor = true;
            this.btnRate.Click += new System.EventHandler(this.btnRate_Click_1);
            // 
            // pBoxPoster
            // 
            this.pBoxPoster.Location = new System.Drawing.Point(17, 6);
            this.pBoxPoster.Margin = new System.Windows.Forms.Padding(4);
            this.pBoxPoster.Name = "pBoxPoster";
            this.pBoxPoster.Size = new System.Drawing.Size(272, 311);
            this.pBoxPoster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBoxPoster.TabIndex = 33;
            this.pBoxPoster.TabStop = false;
            // 
            // rate
            // 
            this.rate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rate.ForeColor = System.Drawing.Color.Black;
            this.rate.Location = new System.Drawing.Point(457, 242);
            this.rate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.rate.Name = "rate";
            this.rate.Size = new System.Drawing.Size(187, 28);
            this.rate.TabIndex = 32;
            // 
            // lbRate
            // 
            this.lbRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbRate.ForeColor = System.Drawing.Color.Black;
            this.lbRate.Location = new System.Drawing.Point(316, 242);
            this.lbRate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbRate.Name = "lbRate";
            this.lbRate.Size = new System.Drawing.Size(141, 28);
            this.lbRate.TabIndex = 31;
            this.lbRate.Text = "Rate:";
            // 
            // director
            // 
            this.director.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.director.ForeColor = System.Drawing.Color.Black;
            this.director.Location = new System.Drawing.Point(457, 131);
            this.director.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.director.Name = "director";
            this.director.Size = new System.Drawing.Size(328, 28);
            this.director.TabIndex = 30;
            // 
            // lbDirector
            // 
            this.lbDirector.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbDirector.ForeColor = System.Drawing.Color.Black;
            this.lbDirector.Location = new System.Drawing.Point(316, 131);
            this.lbDirector.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDirector.Name = "lbDirector";
            this.lbDirector.Size = new System.Drawing.Size(141, 28);
            this.lbDirector.TabIndex = 29;
            this.lbDirector.Text = "Director:";
            // 
            // genre
            // 
            this.genre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.genre.ForeColor = System.Drawing.Color.Black;
            this.genre.Location = new System.Drawing.Point(457, 50);
            this.genre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.genre.Name = "genre";
            this.genre.Size = new System.Drawing.Size(247, 28);
            this.genre.TabIndex = 28;
            // 
            // year
            // 
            this.year.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.year.ForeColor = System.Drawing.Color.Black;
            this.year.Location = new System.Drawing.Point(457, 89);
            this.year.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.year.Name = "year";
            this.year.Size = new System.Drawing.Size(133, 28);
            this.year.TabIndex = 27;
            // 
            // movieName
            // 
            this.movieName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.movieName.ForeColor = System.Drawing.Color.Black;
            this.movieName.Location = new System.Drawing.Point(457, 9);
            this.movieName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.movieName.Name = "movieName";
            this.movieName.Size = new System.Drawing.Size(279, 28);
            this.movieName.TabIndex = 26;
            // 
            // lbGenre
            // 
            this.lbGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbGenre.ForeColor = System.Drawing.Color.Black;
            this.lbGenre.Location = new System.Drawing.Point(316, 50);
            this.lbGenre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbGenre.Name = "lbGenre";
            this.lbGenre.Size = new System.Drawing.Size(133, 28);
            this.lbGenre.TabIndex = 25;
            this.lbGenre.Text = "Genre:";
            // 
            // lbYear
            // 
            this.lbYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbYear.ForeColor = System.Drawing.Color.Black;
            this.lbYear.Location = new System.Drawing.Point(316, 89);
            this.lbYear.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbYear.Name = "lbYear";
            this.lbYear.Size = new System.Drawing.Size(133, 28);
            this.lbYear.TabIndex = 24;
            this.lbYear.Text = "Year:";
            // 
            // lbFilmName
            // 
            this.lbFilmName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbFilmName.ForeColor = System.Drawing.Color.Black;
            this.lbFilmName.Location = new System.Drawing.Point(316, 9);
            this.lbFilmName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbFilmName.Name = "lbFilmName";
            this.lbFilmName.Size = new System.Drawing.Size(133, 28);
            this.lbFilmName.TabIndex = 23;
            this.lbFilmName.Text = "Film Name:";
            // 
            // comments
            // 
            this.comments.FormattingEnabled = true;
            this.comments.ItemHeight = 16;
            this.comments.Location = new System.Drawing.Point(17, 474);
            this.comments.Name = "comments";
            this.comments.Size = new System.Drawing.Size(882, 164);
            this.comments.TabIndex = 45;
            // 
            // UserFilmForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 648);
            this.Controls.Add(this.comments);
            this.Controls.Add(this.btnComment);
            this.Controls.Add(this.lbComments);
            this.Controls.Add(this.summary);
            this.Controls.Add(this.lbSummary);
            this.Controls.Add(this.cBoxRate);
            this.Controls.Add(this.cast);
            this.Controls.Add(this.lbCast);
            this.Controls.Add(this.country);
            this.Controls.Add(this.lbCountry);
            this.Controls.Add(this.btnRate);
            this.Controls.Add(this.pBoxPoster);
            this.Controls.Add(this.rate);
            this.Controls.Add(this.lbRate);
            this.Controls.Add(this.director);
            this.Controls.Add(this.lbDirector);
            this.Controls.Add(this.genre);
            this.Controls.Add(this.year);
            this.Controls.Add(this.movieName);
            this.Controls.Add(this.lbGenre);
            this.Controls.Add(this.lbYear);
            this.Controls.Add(this.lbFilmName);
            this.Name = "UserFilmForm";
            this.Text = "Film";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FilmForm_FormClosed);
            this.Load += new System.EventHandler(this.UserFilmForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pBoxPoster)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnComment;
        private System.Windows.Forms.Label lbComments;
        private System.Windows.Forms.Label summary;
        private System.Windows.Forms.Label lbSummary;
        private System.Windows.Forms.ComboBox cBoxRate;
        private System.Windows.Forms.Label cast;
        private System.Windows.Forms.Label lbCast;
        private System.Windows.Forms.Label country;
        private System.Windows.Forms.Label lbCountry;
        private System.Windows.Forms.Button btnRate;
        private System.Windows.Forms.PictureBox pBoxPoster;
        private System.Windows.Forms.Label rate;
        private System.Windows.Forms.Label lbRate;
        private System.Windows.Forms.Label director;
        private System.Windows.Forms.Label lbDirector;
        private System.Windows.Forms.Label genre;
        private System.Windows.Forms.Label year;
        private System.Windows.Forms.Label movieName;
        private System.Windows.Forms.Label lbGenre;
        private System.Windows.Forms.Label lbYear;
        private System.Windows.Forms.Label lbFilmName;
        private System.Windows.Forms.ListBox comments;
    }
}