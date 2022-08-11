using ClassLibrary.DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieLibrary.Views.Admin
{
    public partial class CommentForm : Form
    {
        private Table _table;
        private TableManager _manager;
        public CommentForm(Table table)
        {
            _table = table;
            _manager = TableManager.GetManager();
            InitializeComponent();
            comboBoxSearchOption.Items.Add("User Id");
            comboBoxSearchOption.Items.Add("Film Id");
            lbTableName.Text = lbTableName.Text + " " + _table.TableName;
            btnUpsert.Enabled = false;
        }

        private async void btnAll_Click(object sender, EventArgs e)
        {
            lbInfo.Text = string.Empty;
            grid.DataSource = null;
            grid.Columns.Clear();
            grid.DataSource = await _table.ShowTableAsync();
        }

        private async void btnFind_Click_1(object sender, EventArgs e)
        {
            lbInfo.Text = string.Empty;
            grid.DataSource = null;
            grid.Columns.Clear();
            grid.Columns.Add("id", "Id");
            grid.Columns.Add("filmId", "Film Id");
            grid.Columns.Add("userId", "User Id");
            grid.Columns.Add("comment", "Comment");

            string enteredValue = textBoxEnterValue.Text;
            string searchOption = comboBoxSearchOption.Text;
            if (searchOption == string.Empty)
            {
                lbInfo.Text = "Please choose a search option.";
                return;
            }
            if (enteredValue == string.Empty)
            {
                lbInfo.Text = "Please enter a value.";
                return;
            }

            var comments = await _manager.commentTable.GetAll();

            if (comments.Count > 0)
            {
                if (searchOption == "User Id")
                {
                    int id;
                    if (int.TryParse(enteredValue, out id))
                    {
                        var commentsFound = comments.FindAll(x => x.UserId == id);
                        if (commentsFound.Count > 0)
                        {
                            foreach (var comment in commentsFound)
                            {
                                grid.Rows.Add(new object[] { comment.Id, comment.FilmId, comment.UserId, comment.CommentText, });
                            }
                        }
                        else
                        {
                            lbInfo.Text = "Id was not found.";
                            return;
                        }
                    }
                    else
                    {
                        lbInfo.Text = "Id must be a number.";
                        return;
                    }
                }
                if (searchOption == "Film Id")
                {
                    int id;
                    if (int.TryParse(enteredValue, out id))
                    {
                        var commentsFound = comments.FindAll(u => u.FilmId == id);
                        if (commentsFound.Count > 0)
                        {
                            foreach (var item in commentsFound)
                            {
                                grid.Rows.Add(new object[] { item.Id, item.FilmId, item.UserId, item.CommentText });
                            }
                        }

                        else
                        {
                            lbInfo.Text = "Id was not found.";
                            return;
                        }
                    }
                    else
                    {
                        lbInfo.Text = "Id must be a number.";
                        return;
                    }
                }
            }
            else
            {
                lbInfo.Text = "Oops! Something wen wrong!";
                return;
            }
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            lbInfo.Text = string.Empty;
            int index = (int)grid.Rows[grid.CurrentRow.Index].Cells["id"].Value;
           
            if (_manager.commentTable.Delete(index))
            {
                lbInfo.Text = "Item was deleted successfully!";
            }
            else
            {
                lbInfo.Text = "Ooops! Something went wrong.Try one more time";
            }
            grid.DataSource = await _table.ShowTableAsync();
            grid.CurrentCell = grid[0, grid.Rows.Count - 1];
        }
    }
}

