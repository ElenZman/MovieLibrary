using ClassLibrary.DataAccess;
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

namespace MovieLibrary.Views.Admin
{
    public partial class GenreForm : Form
    {
        private Table _table;
        private readonly TableManager _manager;
        public GenreForm(Table table)
        {
            _table = table;
            _manager = TableManager.GetManager();
            InitializeComponent();
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
            //grid.DataSource = await _table.ShowTableAsync();
            grid.ClearSelection();

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

            var allGenres = await _manager.genreTable.GetAll();
            if (allGenres.Count > 0)
            {
                if (searchOption == "Genre ID")
                {
                    int id;
                    if (int.TryParse(enteredValue, out id))
                    {
                        var genre = allGenres.FirstOrDefault(x => x.Id == id);
                        if (genre != null)
                        {
                            //если перед поском по id вызывался поиск по имени, 
                            // то для него формировался новый DataGridView, так как результаты 
                            //поиска представляют собой список
                            //при поиске по id, так как он уникальный, ряд, содержащий, необходимые данныу
                            //подсвечивается и к нему скролится все содержимое
                            //Как проверить, что источником данных явялется именно эта таблица, 
                            //воизбежании повторного обращения к базе данных?????
                            grid.DataSource = null;
                            grid.Columns.Clear();
                            grid.DataSource = await _table.ShowTableAsync();
                            if (grid.Rows.Count > 0)
                            {
                                foreach (DataGridViewRow row in grid.Rows)
                                {
                                    if (row.Cells["id"].Value.ToString() == genre.Id.ToString())
                                    {

                                        grid.FirstDisplayedScrollingRowIndex = row.Index;
                                        grid.Rows[row.Index].Selected = true;
                                        break;
                                    }
                                }
                            }
                            else
                            {
                                return;
                            }
                        }
                        else
                        {
                            lbInfo.Text = "ID was not found.";
                            return;
                        }
                    }

                    else
                    {
                        lbInfo.Text = "ID must be a number.";
                        return;
                    }
                }

                if (searchOption == "Genre Name")
                {
                    var listOfGenres = allGenres.Where(x => x.Name.ToLower().Contains(enteredValue.ToLower())).ToList();

                    if (listOfGenres.Count > 0)
                    {
                        //так как результатом поиска зачастую является список,
                        //именно он является источником данных для DataGridView 
                        grid.DataSource = null;
                        grid.Columns.Clear();
                        grid.Columns.Add("id", "Id");
                        grid.Columns.Add("value", "Name");
                        foreach (var genre in listOfGenres)
                        {
                            grid.Rows.Add(new object[] { genre.Id, genre.Name });
                        }

                    }
                    else
                    {
                        lbInfo.Text = "Director not found.";
                        return;
                    }
                }
            }
            else
            {
                lbInfo.Text = "Opps! Something went wrong!";
            }
            enteredValue = string.Empty;
            searchOption = string.Empty;
        }

        private async void btnDelete_Click_1(object sender, EventArgs e)
        {
            lbInfo.Text = string.Empty;
            int index = (int)grid.Rows[grid.CurrentRow.Index].Cells["id"].Value;
            if (_manager.genreTable.Delete(index))
            {
                lbInfo.Text = "Item was deleted successfully!";
            }
            else
            {
                lbInfo.Text = "Ooops! Something went wrong.Try one more time";
            }
            //не показывает
            grid.DataSource = await _table.ShowTableAsync();
        }

        private async void GenreForm_Load(object sender, EventArgs e)
        {
            comboBoxSearchOption.Items.Add("Genre Name");
            comboBoxSearchOption.Items.Add("Genre ID");
            lbTableName.Text =lbTableName.Text + " " + _table.TableName;
            grid.DataSource = await _table.ShowTableAsync();
            grid.CurrentCell = grid[0, grid.Rows.Count - 1];

        }

        private async void btnUpsert_Click(object sender, EventArgs e)
        {
            int index = grid.CurrentRow.Index;
            var model = (Genre)_manager.modelProvider.GetModel(index, grid, _table.TableName);
            if (model.Id == null)
            {
                if (_manager.genreTable.Add(model))
                {
                    lbInfo.Text = "Item added successfully!";
                }
                else
                {
                    lbInfo.Text = "Ooops! Something went wrong.Try one more time";
                }
            }
            else
            {
                if (_manager.genreTable.Update(model))
                {
                    lbInfo.Text = "Item updated successfully!";
                }
                else
                {
                    lbInfo.Text = "Ooops! Something went wrong.Try one more time";
                }
            }

            grid.DataSource = await _table.ShowTableAsync();
        }
    }
}

