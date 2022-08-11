using ClassLibrary.Models;
using ClassLibrary.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieLibrary
{
    public class ModelProvider
    {
        //возвращает объект IModel, собирая информацию из DataGridView
        //если поле id в DataGridView == null, то Id==null и это будет объект для внесения в базу данных 
        //если поле id заполнено, то id == DataGridView[id].Value объект для обновления
        //объект класса создается один раз в классе Manager, реализуя шаблон Singleton
        //данный клас реализует шаблон Factory, если источник вводимых данных изменится,
        //то можно будет периписать только данный класс


        public IModel GetModel(int index, DataGridView grid, string tableName)
        {

            if (tableName == "Countries")
            {

                if (grid.Rows[index].Cells["id"].Value == DBNull.Value)

                {
                    Country country = new Country()
                    {
                        Id = null,
                        Name = (string)grid.Rows[index].Cells["country"].Value,
                    };
                    return country;

                }
                else
                {
                    Country country = new Country()
                    {
                        Id = (int)grid.Rows[index].Cells["id"].Value,
                        Name = (string)grid.Rows[index].Cells["country"].Value,
                    };
                    return country;
                }

            }

            if (tableName == "Actors")
            {
                if (grid.Rows[index].Cells["id"].Value == DBNull.Value)
                {
                    Actor actor = new Actor()
                    {
                        Id = null,
                        Name = (string)grid.Rows[index].Cells["Name"].Value,
                    };
                    return actor;
                }
                else
                {
                    Actor actor = new Actor()
                    {
                        Id = (int)grid.Rows[index].Cells["id"].Value,
                        Name = (string)grid.Rows[index].Cells["Name"].Value,
                    };
                    return actor;
                }
            }
            if (tableName == "Directors")
            {
                if (grid.Rows[index].Cells["id"].Value == DBNull.Value)
                {
                    Director director = new Director()
                    {
                        Id = null,
                        Name = (string)grid.Rows[index].Cells["directorName"].Value,
                    };
                    return director;
                }
                else
                {
                    Director director = new Director()
                    {
                        Id = (int)grid.Rows[index].Cells["id"].Value,
                        Name = (string)grid.Rows[index].Cells["directorName"].Value,
                    };
                    return director;
                }
            }

            ///!!!!!!!!Исправь таблицу в базе данных
            if (tableName == "Genres")
            {
                if (grid.Rows[index].Cells["id"].Value == DBNull.Value)
                {
                    Genre genre = new Genre()
                    {
                        Id = null,
                        Name = (string)grid.Rows[index].Cells["genre"].Value,
                    };
                    return genre;
                }
                else
                {
                    Genre genre = new Genre()
                    {
                        Id = (int)grid.Rows[index].Cells["id"].Value,
                        Name = (string)grid.Rows[index].Cells["genre"].Value,
                    };
                    return genre;
                }
            }
            if (tableName == "Users")
            {
                if (grid.Rows[index].Cells["id"].Value == DBNull.Value)
                {
                    User user = new User()
                    {
                        Id = null,
                        Login = (string)grid.Rows[index].Cells["login"].Value,
                        Password = (string)grid.Rows[index].Cells["password"].Value,
                        Role= (int)grid.Rows[index].Cells["access"].Value,
                    };
                    return user;
                }

                else
                {
                    User user = new User()
                    {
                        Id = (int)grid.Rows[index].Cells["id"].Value,
                        Login = (string)grid.Rows[index].Cells["login"].Value,
                        Password = (string)grid.Rows[index].Cells["password"].Value,
                        Role = (int)grid.Rows[index].Cells["access"].Value,
                    };
                    return user;
                }
            }

            if (tableName == "Films")
            {
                if (grid.Rows[index].Cells["id"].Value == DBNull.Value)
                {
                    Film film = new Film()
                    {
                        Id = null,
                        Name = (string)grid.Rows[index].Cells["filmName"].Value,
                        GenreId = (int)grid.Rows[index].Cells["fk_genre"].Value,
                        Year = (int)grid.Rows[index].Cells["year"].Value,
                        CountryId = (int)grid.Rows[index].Cells["fk_country"].Value,
                        //проверь название колонки
                        Rate = (decimal)grid.Rows[index].Cells["rating"].Value,
                        DirectorId = (int)grid.Rows[index].Cells["directorId"].Value,
                        Summary = (string)grid.Rows[index].Cells["summary"].Value,
                        PeopleRatedNumber =(int)grid.Rows[index].Cells["peopleRatedNumber"].Value,
                    };
                    return film;
                }
                else
                {
                    Film film = new Film()
                    {
                        Id = (int)grid.Rows[index].Cells["id"].Value,
                        Name = (string)grid.Rows[index].Cells["filmName"].Value,
                        GenreId = (int)grid.Rows[index].Cells["fk_genre"].Value,
                        Year = (int)grid.Rows[index].Cells["year"].Value,
                        CountryId = (int)grid.Rows[index].Cells["fk_country"].Value,
                        //проверь название колонки
                        Rate = (decimal)grid.Rows[index].Cells["rating"].Value,
                        DirectorId = (int)grid.Rows[index].Cells["directorId"].Value,
                        Summary = (string)grid.Rows[index].Cells["summary"].Value,
                        PeopleRatedNumber = (int)grid.Rows[index].Cells["peopleRatedNumber"].Value,
                    };
                    return film;
                }
            }
            if (tableName == "Films_Actors")
            {
                if (grid.Rows[index].Cells["id"].Value == DBNull.Value)
                {
                    Films_Actors films_actors = new Films_Actors()
                    {
                        Id = null,
                        FilmId = (int)grid.Rows[index].Cells["films_id"].Value,
                        ActorId = (int)grid.Rows[index].Cells["actors_id"].Value,
                    };
                    return films_actors;
                }
                else
                {
                    Films_Actors films_actors = new Films_Actors()
                    {
                        Id = (int)grid.Rows[index].Cells["id"].Value,
                        FilmId = (int)grid.Rows[index].Cells["films_id"].Value,
                        ActorId = (int)grid.Rows[index].Cells["actors_id"].Value,
                    };
                    return films_actors;
                }
            }
            if (tableName == "Comments")
            {
                return null;
            }

            else return null;
        }
    }
}
    
 


