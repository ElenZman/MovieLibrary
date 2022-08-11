using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieLibrary.Views.Customer
{
    public partial class NotFoundForm : Form
    {
        public NotFoundForm()
        {
            InitializeComponent();

            PictureBox picture = new PictureBox
            {
                Name = "pictureBox",
                Size = new Size(300, 300),
                Location = new Point(50, 50),
                Image = Image.FromFile("NotFound.png"),
            };

            this.Controls.Add(picture);
        }
    }
}
