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
    public class Films_ActorsTable: Table, IDataAccess<Films_Actors>
    {
        public Films_ActorsTable(string name) : base(name)
        {

        }

        
        //!!! Добавляет по 2
        public bool Add(Films_Actors obj)
        {
            string querry = "INSERT INTO Films_Actors VALUES (@filmId, @actorId);";
            using (SqlCommand command = new SqlCommand(querry, connection))

            {
                command.Parameters.Add("@actorId", SqlDbType.Int).Value = obj.ActorId;
                command.Parameters.Add("@filmId", SqlDbType.Int).Value = obj.FilmId;
                command.ExecuteNonQuery();
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

        public async Task<List<Films_Actors>> GetAll()
        {
            List<Films_Actors> list = new List<Films_Actors>();
            string select = @"select * from Films_Actors;";
            using (SqlCommand command = new SqlCommand(select, connection))
            {
                using (var reader = await command.ExecuteReaderAsync())
                {
                    while (await reader.ReadAsync())
                    {
                        list.Add(new Films_Actors()
                        {
                            Id = reader.GetInt32(0),
                            FilmId = reader.GetInt32(1),
                            ActorId = reader.GetInt32(2),

                        });
                    }
                }
            }
            return list;
        }

        /*public List<Films_Actors> FindByFilmId(int filmId)
        {
            List<Films_Actors> list = new List<Films_Actors>();
            string select = @"select * from Films_Actors where films_id=@id ";
            using (SqlCommand command = new SqlCommand(select, connection))
            {
                command.Parameters.Add("@id", SqlDbType.Int).Value = filmId;
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Films_Actors()
                        {
                            Id = reader.GetInt32(0),
                            FilmId = reader.GetInt32(1),
                            ActorId = reader.GetInt32(2),

                        });
                    }
                }
            }
            return list;
        }
        public List<Films_Actors> FindByActorId(int actorId)
        {
            List<Films_Actors> list = new List<Films_Actors>();
            string select = @"select * from Films_Actors where films_id=@id ";
            using (SqlCommand command = new SqlCommand(select, connection))
            {
                command.Parameters.Add("@id", SqlDbType.Int).Value = actorId;
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Films_Actors()
                        {
                            Id = reader.GetInt32(0),
                            FilmId = reader.GetInt32(1),
                            ActorId = reader.GetInt32(2),

                        });
                    }
                }
            }
            return list;
        }*/

        public bool Update(Films_Actors obj)
        {
            string querry = $"UPDATE Films_Actors set actors_id=@actorId, films_id=@filmId WHERE id=@id;";
            using (SqlCommand command = new SqlCommand(querry, connection))

            {
                command.Parameters.Add("@id", SqlDbType.Int).Value = obj.Id;
                command.Parameters.Add("@actorId", SqlDbType.Int).Value = obj.ActorId;
                command.Parameters.Add("@filmId", SqlDbType.Int).Value = obj.FilmId;
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
            string querry = $"DELETE FROM Films_Actors WHERE id=@id;";
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
    }
}

