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
    public partial class SearchResultForm : Form
    {
        private List<Film> _listOfFilms;
        private UserWelcomeForm _userWelcomeForm;
        private readonly TableManager _manager;
        private User _user;
        public SearchResultForm(List<Film> list, UserWelcomeForm form, User user)
        {
            _listOfFilms = list;
            _userWelcomeForm = form;
            _manager = TableManager.GetManager();
            _user = user;
            InitializeComponent();
        }

        private void UserSearchResultForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _userWelcomeForm.Visible = true;
        }

        private async void FillListView(List<Film> filmList)
        {
            if (filmList != null && filmList.Count > 0)
            {
                var genres = await _manager.genreTable.GetAll();
                var directors = await _manager.directorTable.GetAll();
                var actors = await _manager.actorTable.GetAll();
                var films_Actors = await _manager.filmsActorsTable.GetAll();

                int index = 1;

                foreach (var item in filmList)
                {
                    ListViewItem row = new ListViewItem(index.ToString());
                    row.SubItems.Add(item.Name ?? "---");

                    if (genres.Count > 0 && genres != null)
                    {
                        row.SubItems.Add(genres.FirstOrDefault(u => u.Id == item.GenreId).Name ?? "---");
                    }
                    if (directors.Count > 0 && directors != null)
                    {
                        row.SubItems.Add(directors.FirstOrDefault(u => u.Id == item.DirectorId).Name ?? "---");
                    }
                    //rating
                    row.SubItems.Add(item.Rate.ToString());

                    //cast
                    var actorsIds = films_Actors.FindAll(u => u.FilmId == item.Id).Select(x => x.ActorId).ToList();
                    var actorsNames = new List<string>();
                    if (actorsIds.Count > 0)
                    {
                        foreach (var id in actorsIds)
                        {
                            var actorName = actors.FirstOrDefault(u => u.Id == id).Name;
                            actorsNames.Add(actorName ?? "---");
                        }
                    }
                    string cast = string.Empty;
                    for (int i = 0; i < actorsNames.Count; i++)
                    {
                        if (actorsNames[i] == "---")
                        {
                            continue;
                        }
                        else
                        {
                            cast += actorsNames[i] + ",";

                            if (i == actorsNames.Count - 1)
                            {
                                cast += cast[actorsNames.Count - 1];
                            }
                        }
                    }

                    row.SubItems.Add(cast);
                    //summary
                    row.SubItems.Add(item.Summary);

                    viewSearchResult.Items.Add(row);
                    index++;
                }
            }
        }

        private void viewSearchResult_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (viewSearchResult.SelectedIndices.Count > 0)
            {
                var selectedFilm = viewSearchResult.SelectedItems;
              
                if (selectedFilm[0].SubItems[1].Text != null)
                {
                    string filmName = selectedFilm[0].SubItems[1].Text;
                    UserFilmForm filmForm = new UserFilmForm(filmName, this, _user);
                    this.Visible = false;
                    filmForm.Show();
                }
            }
            else
            {
                return;
            }
                      
        }

        private void SearchResultForm_Load(object sender, EventArgs e)
        {
            if (_listOfFilms != null && _listOfFilms.Count > 0)
            {
                viewSearchResult.Columns.Clear();
                viewSearchResult.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                viewSearchResult.Columns.Add("No", "No");
                viewSearchResult.Columns[0].Width = 30;
                viewSearchResult.Columns.Add("film", "Film");
                viewSearchResult.Columns[1].Width = 200;
                viewSearchResult.Columns.Add("genre", "Genre");
                viewSearchResult.Columns[2].Width = 100;
                viewSearchResult.Columns.Add("director", "Director");
                viewSearchResult.Columns[3].Width = 100;
                viewSearchResult.Columns.Add("rate", "Rate");
                viewSearchResult.Columns[4].Width = 100;
                viewSearchResult.Columns.Add("cast", "Cast");
                viewSearchResult.Columns[5].Width = 180;
                viewSearchResult.Columns.Add("summary", "Summary");
                viewSearchResult.Columns[6].Width = 250;

                FillListView(_listOfFilms);
            }
            else
            {
                MessageBox.Show("Films not found.");
            }
        }
    }
}
