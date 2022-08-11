using ClassLibrary.Models;
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
    public partial class CommentForm : Form
    {
        private readonly TableManager _manager;
        private readonly User _user;
        private readonly int _filmId;

        public CommentForm(User user, int filmId)
        {
            InitializeComponent();
            _manager = TableManager.GetManager();
            _user = user;
            _filmId = filmId;
        }

        private async void btnSend_Click_1(object sender, EventArgs e)
        {
            string commentText = tBoxComment.Text;
            Comment comment = new Comment()
            {
                UserId = (int)_user.Id,
                FilmId = _filmId,
                CommentText = commentText,
            };


            //check if user's already commented this film
            var allComments = await _manager.commentTable.GetAll();
            var isExist = allComments.Find(u => u.UserId == comment.UserId && u.FilmId == comment.FilmId);
            if (isExist != null)
            {
                MessageBox.Show("You've already commented this film.");
                this.Close();
            }
            else
            {
                if (_manager.commentTable.Add(comment))
                {
                    btnSend.Enabled = false;
                    this.Close();
                    MessageBox.Show("Your comment added successfully.");
                }
                else
                {
                    MessageBox.Show("Oops! Something went wrong.");
                }
            }
        }
    }
}

