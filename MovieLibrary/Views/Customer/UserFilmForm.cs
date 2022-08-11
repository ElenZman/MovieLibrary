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
    public partial class UserFilmForm : Form
    {
        readonly string _filmName;
        private SearchResultForm _searchResult;
        private Film _film;
        private readonly TableManager _manager;
        private User _user;

        public UserFilmForm(string filmName, SearchResultForm searchResult, User user)
        {
            _filmName = filmName;
            _manager = TableManager.GetManager();
            _film = new Film();
            _searchResult = searchResult;
            _user = user;
            InitializeComponent();
        }

        private async void FillForm(Film film)
        {
            if (film != null)
            {
                movieName.Text = film.Name;
                var genres = await _manager.genreTable.GetAll();
                genre.Text = genres.FirstOrDefault(u => u.Id == film.GenreId).Name ?? "---";
                year.Text = film.Year.ToString() ?? "---";
                var directors = await _manager.directorTable.GetAll();
                director.Text = directors.FirstOrDefault(u => u.Id == film.DirectorId).Name ?? "---";
                //Для начала вытаскиваем все из связной таблицы
                var films_Actors = await _manager.filmsActorsTable.GetAll();
                //Тщем в ней Id всех актеров, свпадающих с id нашего фильма, и складываем в List
                var actorsIds = films_Actors.FindAll(u => u.FilmId == film.Id).Select(x => x.ActorId).ToList();
                //получаем всех актеров
                var allActors = await _manager.actorTable.GetAll();
                //Формируем список имен актеров, по найденым Id
                var actorsNames = new List<string>();
                if (actorsIds.Count > 0)
                {

                    foreach (var id in actorsIds)
                    {
                        var actor = allActors.First(u => u.Id == id).Name;
                        actorsNames.Add(actor);
                    }
                }
                //передаем в форму
                for (int i = 0; i < actorsNames.Count; i++)
                {
                    cast.Text += actorsNames[i] + ", ";
                    if (i == actorsNames.Count - 1)
                    {
                        cast.Text += actorsNames[actorsNames.Count - 1] + "\n";
                    }
                }
            }
            //country.Text 
            var countries = await _manager.countryTable.GetAll();
            country.Text = countries.FirstOrDefault(u => u.Id == film.CountryId).Name ?? "---";
            summary.Text = film.Summary ?? "---";
            //добавляеи постер
            ImageConverter converter = new ImageConverter();
            pBoxPoster.Image = (Image)converter.ConvertFrom(film.Poster);
            if (film.Rate != 0)
            {
                rate.Text = film.Rate.ToString();
            }
            else
                rate.Text = "Not rated yet.";

            //объект комментария имеет внешний ключ id пользователя и внешний ключ id фильма
            //достаем все комментарии      
            var allComments = await _manager.commentTable.GetAll();
            //чтобы найти логины пользователей, получаем всех пользователей
            var allUsers = await _manager.userTable.GetAll();
            //получаем все комментарии с id фильма
            var filmComments = allComments.FindAll(u => u.FilmId == film.Id);
            if (filmComments.Count > 0)
            {
                int index = 1;
                foreach (var item in filmComments)
                {  
                    //для каждого комментария вытаскиваем логин пользователя и текс комментария
                    //comments=ListView
                    comments.Items.Add(index.ToString() + ".  " + allUsers.FirstOrDefault(u => u.Id == item.UserId).Login +"\n\n");               
                    comments.Items.Add(item.CommentText+"\n\n");
                    index++;
                }
            }
        }

        private void FilmForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _searchResult.Visible = true;
        }


        //полю _filmName значение присваивается в контсрукторе
        //при загрузке формы ищется фильм по названию его названию(_filmName)
        //и передается в метод FillForm
        private async void UserFilmForm_Load(object sender, EventArgs e)
        {
            if (_filmName != null)
            {
                var films = await _manager.filmTable.GetAll();
                _film = films.Where(film => film.Name == _filmName).FirstOrDefault();
                FillForm(_film);
            }
            else
            {
                NotFoundForm notFound = new NotFoundForm();
                notFound.ShowDialog();
            }
        }

        //поставить фильму оценку
        private void btnRate_Click_1(object sender, EventArgs e)
        {
            if (cBoxRate.SelectedItem == null) return;
            if (_film == null || _film.Id == null) return;

            int userRate;
            int peopleRatedNumber = _film.PeopleRatedNumber;
            double updatedRating;
            if (int.TryParse(cBoxRate.SelectedItem.ToString(), out userRate))
            {
                peopleRatedNumber++;
                if (peopleRatedNumber > 0)
                {
                    updatedRating = ((double)_film.Rate + userRate) / peopleRatedNumber;
                    if (_manager.filmTable.UpdateRating((int)_film.Id, updatedRating, peopleRatedNumber))
                    {
                        MessageBox.Show("Film rated successfully.");
                    }
                    else
                    {
                        MessageBox.Show("Ooops! Rating was not updated");
                    }
                }
                else
                {
                    MessageBox.Show("Ooops! Rating was not updated");
                    return;
                }
            }
        }

        private void btnComment_Click_1(object sender, EventArgs e)
        {
            CommentForm commentForm = new CommentForm(_user, (int)_film.Id);
            commentForm.ShowDialog();
        }
    }
}

