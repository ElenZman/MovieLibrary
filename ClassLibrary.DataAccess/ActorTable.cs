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
    public class ActorTable : Table, IDataAccess<Actor>
    {
        public ActorTable(string name) : base(name)
        {

        }
        public bool Add(Actor obj)
        {

            string querry = "INSERT INTO Actors VALUES (@actorName);";
            {
                using (SqlCommand command = new SqlCommand(querry, connection))

                {
                    command.Parameters.Add("@actorName", SqlDbType.NVarChar, 20).Value = obj.Name;
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
            }

            return true;
        }

        public bool Delete(int id)
        {
            string querry = $"DELETE FROM Actors WHERE id=@id;";
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

        /*public List<Actor> FindByValue(string name)
        {

            List<Actor> list = new List<Actor>();
            string select = "select * from Actors;";
            using (SqlCommand command = new SqlCommand(select, connection))
            {
                using (var reader = command.ExecuteReader())

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            list.Add(new Actor()
                            {
                                Id = reader.GetInt32(0),
                                Name = reader.GetString(1),

                            });
                        }
                        var listOfActors = list.Where(x => x.Name.ToLower().Contains(name.ToLower())).ToList();
                        return listOfActors;
                    }
            }

            return null;
        }
        
        public Actor FindById(int id)
        {
            Actor actor;
            string select = @"select * from Actors where id=@id;";
            using (SqlCommand command = new SqlCommand(select, connection))
            {
                command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        actor = new Actor()
                        {
                            Id = reader.GetInt32(0),
                            Name = reader.GetString(1),

                        };
                        return actor;
                    }

                }
            }
            return null;
        }*/

        public async Task<List<Actor>> GetAll()
        {
            List<Actor> list = new List<Actor>();
            string select = @"select * from Actors;";
            using (SqlCommand command = new SqlCommand(select, connection))
            {
                using (var reader = await command.ExecuteReaderAsync())
                {
                    while (await reader.ReadAsync())
                    {
                        list.Add(new Actor()
                        {
                            Id = reader.GetInt32(0),
                            Name = reader.GetString(1),

                        });
                    }
                }
            }
            return list;
        }

        public bool Update(Actor obj)
        {
            string querry = $"UPDATE Actors set Name=@actorName WHERE id=@id;";
            using (SqlCommand command = new SqlCommand(querry, connection))

            {
                command.Parameters.Add("@id", SqlDbType.Int).Value = obj.Id;
                command.Parameters.Add("@actorName", SqlDbType.NVarChar, 50).Value = obj.Name;
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
