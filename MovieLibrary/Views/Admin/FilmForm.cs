using ClassLibrary.DataAccess;
using ClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieLibrary.Views.Admin
{
    public partial class FilmForm : Form
    {
        private Table _table;
        private readonly TableManager _manager;
        public FilmForm(Table table)
        {
            _table = table;
            _manager = TableManager.GetManager();
            InitializeComponent();
            comboBoxSearchOption.Items.Add("Film Id");
            comboBoxSearchOption.Items.Add("Film Name");
            comboBoxSearchOption.Items.Add("Actor Id");
            comboBoxSearchOption.Items.Add("Genre Id");
            comboBoxSearchOption.Items.Add("Director Id");
            comboBoxSearchOption.Items.Add("Year");
            
            lbTableName.Text = lbTableName.Text + " "  + _table.TableName;

            cBoxOpenTable.Items.Add("Users");
            cBoxOpenTable.Items.Add("Comments");
            cBoxOpenTable.Items.Add("Films");
            cBoxOpenTable.Items.Add("Films_Actors");
            cBoxOpenTable.Items.Add("Genres");
            cBoxOpenTable.Items.Add("Actors");
            cBoxOpenTable.Items.Add("Countries");
            cBoxOpenTable.Items.Add("Directors");
        }

    
        private async void btnUpsert_Click(object sender, EventArgs e)
        {
            int index = grid.CurrentRow.Index;
            var filmManager = _manager.filmTable;
            var model = (Film)_manager.modelProvider.GetModel(index, grid, _table.TableName);
            if (model.Id == null)
            {
                if (filmManager.Add(model))
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
                if (filmManager.Update(model))
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

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            lbInfo.Text = string.Empty;
            int index = (int)grid.Rows[grid.CurrentRow.Index].Cells["id"].Value;
            var filmManager = _manager.filmTable;
            if (filmManager.Delete(index))
            {
                lbInfo.Text = "Item was deleted successfully!";
            }
            else
            {
                lbInfo.Text = "Ooops! Something went wrong.Try one more time";
            }
            grid.DataSource = await _table.ShowTableAsync();
        }
  
        private async void btnAll_Click(object sender, EventArgs e)
        {
            lbInfo.Text = string.Empty;
            grid.DataSource = null;
            grid.Columns.Clear();
            grid.DataSource = await _table.ShowTableAsync();
            grid.CurrentCell = grid[0, grid.Rows.Count - 1];
        }

        string fileName = string.Empty;
        private void btnAddPoster_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Filter = "PNG|*.png|JPEG|*.jpg|GIF|*.gif";
            if (openDialog.ShowDialog() == DialogResult.OK)

            {
                fileName = openDialog.FileName;
                byte[] image = File.ReadAllBytes(openDialog.FileName);
                //int index = grid.CurrentRow.Index;
                string insert = @"update Films set poster=@image where id=@id;";
                using (SqlConnection connection = new SqlConnection(@"Data Source= DESKTOP-NPSC8CE\SQLEXPRESS;
                                            Initial Catalog = FilmLibrary; 
                                            Integrated Security=SSPI;"))
                {

                    using (SqlCommand command = new SqlCommand(insert, connection))
                    {
                        command.Parameters.Add("@image", SqlDbType.Image, image.Length).Value = image;
                        connection.Open();
                        try
                        {
                            command.ExecuteNonQuery();
                            lbInfo.Text = "Image was added successfully.";
                        }
                        catch (Exception ex)
                        {
                            lbInfo.Text = "Ooops! Something went wrong! Try one more time";
                            return;
                        }
                    }
                }
            }
        }

        private async void btnFind_Click_1(object sender, EventArgs e)
        {
            grid.DataSource = null;
            grid.Columns.Clear();
            grid.Columns.Add("id", "Id");
            grid.Columns.Add("filmName", "Film Name");
            grid.Columns.Add("genre", "Genre Id");
            grid.Columns.Add("country", "Country Id");
            grid.Columns.Add("year", "Year");
            grid.Columns.Add("director", "Director Id");
            grid.Columns.Add("rate", "Audience Rating");
            grid.Columns.Add("summary", "Summary");
            grid.Columns.Add("peopleRated", "Number of people rated");

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

            var films = await _manager.filmTable.GetAll();
            if (searchOption == "Film Id")
            {
                if (films.Count > 0)
                {
                    int index;
                    if (int.TryParse(enteredValue, out index))
                    {
                        var film = films.FirstOrDefault(x => x.Id == index);
                        if (film != null)
                        {
                            grid.Rows.Add(new object[] { film.Id, film.Name, film.GenreId, film.CountryId, film.Year, film.DirectorId,
                                film.Rate, film.Summary, film.PeopleRatedNumber, });
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
                else
                {
                    lbInfo.Text = "Opps! Something went wrong!";
                    return;
                }
            }

            if (searchOption == "Film Name")
            {
                if (films.Count > 0)
                {
                    var listOfFilms = films.Where(x => x.Name.ToLower().Contains(enteredValue.ToLower())).ToList();
                    if (listOfFilms.Count > 0)
                    {
                        foreach (var film in listOfFilms)
                        {
                            grid.Rows.Add(new object[] { film.Id, film.Name, film.GenreId, film.CountryId, film.Year, film.DirectorId,
                                film.Rate, film.Summary, film.PeopleRatedNumber, });
                        }
                    }
                    else
                    {
                        lbInfo.Text = "Film not found.";
                        return;
                    }
                }
                else
                {
                    lbInfo.Text = "Opps! Something went wrong!";
                    return;
                }
            }

            
            if (searchOption == "Actor Id")
            {
                int id;
                if (int.TryParse(enteredValue, out id))
                {
                    var allFilms = _manager.filmTable.GetFilmByActorId(id);
                    if (allFilms.Count > 0)
                    {
                        foreach (var film in allFilms)
                        {
                            grid.Rows.Add(new object[] { film.Id, film.Name, film.GenreId, film.CountryId, film.Year, film.DirectorId,
                                film.Rate, film.Summary, film.PeopleRatedNumber, });
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
            
            if (searchOption == "Genre Id")
            {
                if (films.Count > 0)
                {
                    int id;
                    if (int.TryParse(enteredValue, out id))
                    {
                        var allGenres = await _manager.genreTable.GetAll();
                        var genre = allGenres.FirstOrDefault(u => u.Id == id);

                        if (genre != null)
                        {
                            var filmsFound = films.FindAll(u => u.GenreId == genre.Id);
                            foreach (var film in filmsFound)
                            {
                                grid.Rows.Add(new object[] { film.Id, film.Name, film.GenreId, film.CountryId, film.Year, film.DirectorId,
                                film.Rate, film.Summary, film.PeopleRatedNumber, });
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
                else
                {
                    lbInfo.Text = "Opps! Something went wrong!";
                    return;
                }
            }
           
            if (searchOption == "Director Id")
            {
                if (films.Count > 0)
                {
                    int id;
                    if (int.TryParse(enteredValue, out id))
                    {
                        var allDirectors = await _manager.directorTable.GetAll();
                        var director = allDirectors.FirstOrDefault(u => u.Id == id);

                        if (director != null)
                        {
                            var filmsFound = films.FindAll(u => u.DirectorId == director.Id);
                            foreach (var film in filmsFound)
                            {
                                grid.Rows.Add(new object[] { film.Id, film.Name, film.GenreId, film.CountryId, film.Year, film.DirectorId,
                                film.Rate, film.Summary, film.PeopleRatedNumber, });
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
                else
                {
                    lbInfo.Text = "Opps! Something went wrong!";
                    return;
                }
            }

            if (searchOption == "Year")
            {
                if (films.Count > 0)
                {
                    int year;
                    if (int.TryParse(enteredValue, out year))
                    {

                        var filmsFound = films.FindAll(u => u.Year == year);

                        if (filmsFound.Count > 0)
                        {
                            foreach (var film in filmsFound)
                            {
                                grid.Rows.Add(new object[] { film.Id, film.Name, film.GenreId, film.CountryId, film.Year, film.DirectorId,
                                film.Rate, film.Summary, film.PeopleRatedNumber, });
                            }
                        }
                        else
                        {
                            lbInfo.Text = "Films not found.";
                            return;
                        }
                    }
                    else
                    {
                        lbInfo.Text = "Year must be a number.";
                        return;
                    }
                }
                else
                {
                    lbInfo.Text = "Opps! Something went wrong!";
                }
            }
        }

        private void btnOpenTable_Click_1(object sender, EventArgs e)
        {
            if (cBoxOpenTable.Text == string.Empty) return;
            
            string name = cBoxOpenTable.Text;
            if (name == "Countries")
            {
                _table = _manager.countryTable;
                CountryForm form = new CountryForm(_table);
                form.Show();
            }
            if (name == "Actors")
            {
                _table = _manager.actorTable;
                ActorForm form = new ActorForm(_table);
                form.Show();
            }
            if (name == "Films")
            {
                _table = _manager.filmTable;
                FilmForm form = new FilmForm(_table);
                form.Show();
                this.Close();
            }
            if (name == "Genres")
            {
                _table = _manager.genreTable;
                GenreForm form = new GenreForm(_table);
                form.Show();
            }
            if (name == "Users")
            {
                _table = _manager.userTable;
                UserForm form = new UserForm(_table);
                form.Show();
            }
            if (name == "Films_Actors")
            {
                _table = _manager.filmsActorsTable;
                FilmsActorsForm form = new FilmsActorsForm(_table);
                form.Show();
            }
            if (name == "Comments")
            {
                _table = _manager.commentTable;
                CommentForm form = new CommentForm(_table);
                form.Show();
            }

            if (name == "Directors")
            {
                _table = _manager.directorTable;
                DirectorForm form = new DirectorForm(_table);
                form.Show();
            }
        }
    }
}