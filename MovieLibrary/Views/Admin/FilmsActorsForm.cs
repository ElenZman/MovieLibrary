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
    public partial class FilmsActorsForm : Form
    {
        private Table _table;
        private readonly TableManager _manager;
        List<Film> _films;
        List<Actor> _actors;

        public FilmsActorsForm(Table table)
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
            if (grid.Rows.Count > 1)
            {
                grid.CurrentCell = grid[0, grid.Rows.Count - 1];
            }
        }

        /*private async void btnUpsert_Click(object sender, EventArgs e)
        {
            int index = grid.CurrentRow.Index;
           
            var model = (Films_Actors)_manager.modelProvider.GetModel(index, grid, _table.TableName);
            if (model.Id != null)
            {
                if (_manager.filmsActorTable.Update(model))
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
                return;
            }

            grid.DataSource = await _table.ShowTableAsync();
            if (grid.Rows.Count > 1)
            {
                grid.CurrentCell = grid[0, grid.Rows.Count - 1];
            }
        }*/

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            lbInfo.Text = string.Empty;
            int index = (int)grid.Rows[grid.CurrentRow.Index].Cells["id"].Value;
            var filmsActorManager = _manager.filmsActorsTable;
            if (filmsActorManager.Delete(index))
            {
                lbInfo.Text = "Item was deleted successfully!";
            }
            else
            {
                lbInfo.Text = "Ooops! Something went wrong.Try one more time";
            }
            grid.DataSource = await _table.ShowTableAsync();
            if (grid.Rows.Count > 1)
            {
                grid.CurrentCell = grid[0, grid.Rows.Count - 1];
            }
        }

        private async void FilmsActorsForm_Load_1(object sender, EventArgs e)
        {
            lbTableName.Text = lbTableName.Text + " " + _table.TableName;
            //автозаполнение комбобокса Актеры
            _actors = await _manager.actorTable.GetAll();
            var actorsList = (from actor in _actors
                              select actor.Name).ToList();
            var autoCompleteActors = new AutoCompleteStringCollection();
            autoCompleteActors.AddRange(actorsList.ToArray());
            cBoxActor.AutoCompleteCustomSource = autoCompleteActors;
            cBoxActor.AutoCompleteSource = AutoCompleteSource.CustomSource;
            cBoxActor.AutoCompleteMode = AutoCompleteMode.Suggest;
            cBoxActor.DisplayMember = "Name";
            cBoxActor.ValueMember = "Id";

            //автозаполнение комбобокса Фильмы
            _films = await _manager.filmTable.GetAll();
            var filmList = (from film in _films
                            select film.Name).ToList();
            var autoCompleteFilms = new AutoCompleteStringCollection();
            autoCompleteFilms.AddRange(filmList.ToArray());
            cBoxFilm.AutoCompleteCustomSource = autoCompleteFilms;
            cBoxFilm.AutoCompleteSource = AutoCompleteSource.CustomSource;
            cBoxFilm.AutoCompleteMode = AutoCompleteMode.Suggest;
            cBoxFilm.DisplayMember = "Name";
            cBoxFilm.ValueMember = "Id";

            comboBoxSearchOption.Items.Add("Film Name");
            comboBoxSearchOption.Items.Add("Actor Name");
            //
            toolTip1.SetToolTip(cBoxActor, "Start typing actor's name");
            toolTip2.SetToolTip(cBoxFilm, "Start typing film name");

            grid.DataSource = await _table.ShowTableAsync();
            if (grid.Rows.Count > 1)
            {
                grid.CurrentCell = grid[0, grid.Rows.Count - 1];
            }
        }

        private async void btnFind_Click_1(object sender, EventArgs e)
        {
            lbInfo.Text = string.Empty;
            //grid.DataSource = await _table.ShowTableAsync();
            grid.ClearSelection();

            grid.DataSource = null;
            grid.Columns.Clear();

            grid.Columns.Add("id", "Id");
            grid.Columns.Add("filmId", "Film Id");
            grid.Columns.Add("actorId", "Actor Id");

            string searchOption = comboBoxSearchOption.Text;

            if (searchOption == string.Empty)
            {
                lbInfo.Text = "Please choose a search option.";
                return;
            }

            var allFilmsActors = await _manager.filmsActorsTable.GetAll();
            //cann not find by Actor ID???
            if (searchOption == "Actor Name")
            {
                if (cBoxActor.Text == string.Empty)
                {
                    lbInfo.Text = "Please choose an actor!";
                    return;
                }
                var actorName = cBoxActor.Text;
                var actorId = _actors.FirstOrDefault(u => u.Name == actorName).Id;
                var filmName = _manager.filmTable.GetFilmByActorId((int)actorId);
                if (actorId == null)
                {
                    lbInfo.Text = "Actor not found.";
                }
                else
                {
                    var list = allFilmsActors.Where(u => u.ActorId == actorId).ToList();
                    if (list.Count > 0)
                    {
                        grid.DataSource = null;
                        foreach (var item in list)
                        {
                            grid.Rows.Add(new object[] { item.Id, item.FilmId, item.ActorId });
                        }
                    }
                    else
                    {
                        lbInfo.Text = "Not found.";
                        return;
                    }
                }
            }
            if (searchOption == "Film Name")
            {
                if (cBoxFilm.Text == string.Empty)
                {
                    lbInfo.Text = "Please choose a film!";
                    return;
                }
                var film = cBoxFilm.Text;

                var filmId = _films.FirstOrDefault(u => u.Name == film).Id;
                if (filmId == null)
                {
                    lbInfo.Text = "Film not found";
                }
                else
                {
                    var list = allFilmsActors.Where(u => u.FilmId == filmId).ToList();
                    if (list.Count > 0)
                    {
                        //так как результатом поиска зачастую является список,
                        //именно он является источником данных для DataGridView 
                        grid.DataSource = null;

                        foreach (var item in list)
                        {
                            grid.Rows.Add(new object[] { item.Id, item.FilmId, item.ActorId });
                        }
                    }

                    else
                    {
                        lbInfo.Text = "Not found.";
                        return;
                    }
                }

            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            NewFilm_Actor newFilmActorForm = new NewFilm_Actor();
            newFilmActorForm.Show();
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            int index = grid.CurrentRow.Index;
            var model = (Films_Actors)_manager.modelProvider.GetModel(index, grid, _table.TableName);
            if (_manager.filmsActorsTable.Update(model))
            {
                lbInfo.Text = "Item was updated successfully!";
            }
            else
            {
                lbInfo.Text = "Ooops! Something went wrong.Try one more time";
            }
            grid.DataSource = await _table.ShowTableAsync();
            if (grid.Rows.Count > 1)
            {
                grid.CurrentCell = grid[0, grid.Rows.Count - 1];
            }
        }
    }
}

