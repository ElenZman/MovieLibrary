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
    public partial class NewFilm_Actor : Form
    {
        private readonly TableManager _manager;
        List<Actor> actors;
        List<Film> films;
        public NewFilm_Actor()
        {
            InitializeComponent();
            _manager = TableManager.GetManager();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string actorName = cBoxActor.Text;
            string filmName = cBoxFilm.Text;
            if (actorName == string.Empty || filmName == string.Empty)
            {
                lbInfo.Text = "Actor and Film must not be empty.";
                return;

            }
            int actorId = 0;
            int filmId = 0;
            
            //вытаскиваем Id, если FirstOrDeafault == null, то id остается 0
            actorId = (int)actors.FirstOrDefault(u => u.Name == actorName).Id;

            if (actorId == 0)
            {
                lbInfo.Text = "Actor Id cannot be 0.";
            }
            //аналогично с фильмами
            filmId = (int)films.FirstOrDefault(u => u.Name == filmName).Id;
            if (filmId == 0)
            {
                lbInfo.Text = "Film Id cannot be 0.";
            }

            if (filmId != 0 && actorId != 0)
            {

                Films_Actors filmsActors = new Films_Actors()
                {
                    FilmId = filmId,
                    ActorId = actorId,
                };
                if (_manager.filmsActorsTable.Add(filmsActors))
                {
                    lbInfo.Text = "New item added successfully.";
                }
                else
                {
                    lbInfo.Text = "Oops! something went wrong.";
                }
            }
            else
            {
                return;
            }
        }

        private async void NewFilm_Actor_Load(object sender, EventArgs e)
        {
            //автозаполнение комбобокса Актеры
            actors = await _manager.actorTable.GetAll();
            var actorsList = (from actor in actors
                              select actor.Name).ToList();
            var autoCompleteActors = new AutoCompleteStringCollection();
            autoCompleteActors.AddRange(actorsList.ToArray());
            cBoxActor.AutoCompleteCustomSource = autoCompleteActors;
            cBoxActor.AutoCompleteSource = AutoCompleteSource.CustomSource;
            cBoxActor.AutoCompleteMode = AutoCompleteMode.Suggest;
            cBoxActor.DisplayMember = "Name";
            cBoxActor.ValueMember = "Id";

            //автозаполнение комбобокса Фильмы
            films = await _manager.filmTable.GetAll();
            var filmList = (from film in films
                            select film.Name).ToList();
            var autoCompleteFilms = new AutoCompleteStringCollection();
            autoCompleteFilms.AddRange(filmList.ToArray());
            cBoxFilm.AutoCompleteCustomSource = autoCompleteFilms;
            cBoxFilm.AutoCompleteSource = AutoCompleteSource.CustomSource;
            cBoxFilm.AutoCompleteMode = AutoCompleteMode.Suggest;
            cBoxFilm.DisplayMember = "Name";
            cBoxFilm.ValueMember = "Id";
        }
    }
}
