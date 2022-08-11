
using ClassLibrary.DataAccess.Interfaces;
using ClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ClassLibrary.DataAccess
{
    public class FilmTable : Table, IDataAccess<Film>
    {

        public FilmTable(string name) : base(name)
        {

        }
        public bool Add(Film obj)
        {
            string querry = "INSERT INTO Films (filmName, fk_genre, year, fk_country, rating, directorId, summary, ) " +
                    "VALUES (@filmName, @genreId, @year, @countryId, @rate, @director, @summary) ;";

            using (SqlCommand command = new SqlCommand(querry, connection))

            {
                command.Parameters.Add("@filmName", SqlDbType.NVarChar, 50).Value = obj.Name;
                command.Parameters.Add("@genreId", SqlDbType.Int).Value = obj.GenreId;
                command.Parameters.Add("@year", SqlDbType.Int).Value = obj.Year;
                command.Parameters.Add("@countryId", SqlDbType.Int).Value = obj.CountryId;
                command.Parameters.Add("@rate", SqlDbType.Int).Value = obj.Rate;
                command.Parameters.Add("@director", SqlDbType.Int).Value = obj.DirectorId;
                command.Parameters.Add("@summary", SqlDbType.NVarChar, 2000).Value = obj.Summary;

                try
                {
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    command.Cancel();
                    return false;
                }
            }
            return true;
        }

        public async Task<List<Film>> GetAll()
        {
            List<Film> list = new List<Film>();
            string querry = "SELECT * from Films;";
            using (SqlCommand command = new SqlCommand(querry, connection))
            {
                try
                {
                    using (var reader = await command.ExecuteReaderAsync())
                    {
                        if (reader.HasRows)
                        {
                            while (await reader.ReadAsync())
                            {
                                list.Add(new Film()
                                {
                                    Id = (int)reader["id"],
                                    Name = (string)reader["filmName"],
                                    GenreId = (int)reader["fk_genre"],
                                    Year = (int)reader["year"],
                                    Poster = (byte[])reader["poster"],
                                    CountryId = (int)reader["fk_country"],
                                    Rate = (decimal)reader["rating"],
                                    Summary = (string)reader["summary"],
                                    DirectorId = (int)reader["directorId"],
                                    PeopleRatedNumber = (int)reader["peopleRatedNumber"],
                                });
                            }
                        }
                        return list;
                    }
                }
                catch (Exception ex)
                {
                    command.Cancel();
                    return null;
                }
            }
        }

        public bool Update(Film obj)
        {
            string querry = $"UPDATE Films set filmName=@filmName, fk_genre=@genreId," +
                $"year=@year, fk_country=@countryId, rating=@rate, directorId=@directorId, summary=@summary WHERE id=@id;";
            using (SqlCommand command = new SqlCommand(querry, connection))

            {
                command.Parameters.Add("@id", SqlDbType.Int).Value = obj.Id;
                command.Parameters.Add("@filmName", SqlDbType.NVarChar, 50).Value = obj.Name;
                command.Parameters.Add("@genreId", SqlDbType.Int).Value = obj.GenreId;
                command.Parameters.Add("@year", SqlDbType.Int).Value = obj.Year;
                command.Parameters.Add("@countryId", SqlDbType.Int).Value = obj.CountryId;
                command.Parameters.Add("@rate", SqlDbType.Int).Value = obj.Rate;
                command.Parameters.Add("@directorId", SqlDbType.Int).Value = obj.DirectorId;
                command.Parameters.Add("@summary", SqlDbType.NVarChar, 2000).Value = obj.Summary;
                try
                {
                    command.ExecuteNonQuery();
                }

                catch (Exception ex)
                {
                    command.Cancel();
                    return false;

                }
            }
            return true;
        }
        public bool UpdateRating(int filmId, double rating, int peopleRatedNumber)
        {
            string querry = @"update Films set rating=@rating, peopleRatedNumber 
                              = @peopleRatedNumber where id=@filmId";
            using (SqlCommand command = new SqlCommand(querry, connection))
            {
                command.Parameters.Add("@filmId", SqlDbType.Int).Value = filmId;
                command.Parameters.Add("@rating", SqlDbType.Decimal).Value = rating;
                command.Parameters.Add("@peopleRatedNumber", SqlDbType.Int).Value = peopleRatedNumber;
                try
                {
                    command.ExecuteNonQuery();
                }

                catch (Exception ex)
                {

                    command.Cancel();
                    return false;

                }
            }
            return true;
        }

        public bool Delete(int id)
        {
            string querry = $"DELETE FROM Films WHERE id=@id;";
            using (SqlCommand command = new SqlCommand(querry, connection))

            {
                command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                try
                {
                    command.ExecuteNonQuery();

                }

                catch (Exception ex)
                {

                    command.Cancel();
                    return false;

                }
            }
            return true;
        }
        
        public List<Film> GetFilmByActorId(int id)
        {
            List<Film> list = new List<Film>();

            string querry = $"select Films.id, Films.filmName, Films.fk_genre, Films.fk_country, Films.year, Films.rating, Films.summary, Films.directorId, Films.peopleRatedNumber" +
                $" from Films join Films_Actors on Films.id = Films_Actors.films_id join Actors on Films_Actors.actors_id = Actors.id " +
                $"where Actors.Id = @actorId;";

            using (SqlCommand command = new SqlCommand(querry, connection))
            {
                command.Parameters.Add("@actorId", SqlDbType.Int).Value = id;
                try
                {
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                list.Add(new Film()
                                {
                                    Id = (int)reader["id"],
                                    Name = (string)reader["filmName"],
                                    GenreId = (int)reader["fk_genre"],
                                    Year = (int)reader["year"],
                                    CountryId = (int)reader["fk_country"],
                                    Rate = (decimal)reader["rating"],
                                    Summary = (string)reader["summary"],
                                    DirectorId = (int)reader["directorId"],
                                    PeopleRatedNumber = (int)reader["peopleRatedNumber"],
                                });
                            }
                        }
                        return list;
                    }
                }
                catch (Exception ex)
                {
                    command.Cancel();
                    return null;
                }
            }
        }
    }
}
