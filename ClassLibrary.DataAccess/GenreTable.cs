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
   public class GenreTable: Table, IDataAccess<Genre>
    {
        public GenreTable(string name) : base(name)
        {

        }


        public bool Add(Genre obj)
        {

            string querry = "INSERT INTO Generes VALUES (@genre);";
            {
                using (SqlCommand command = new SqlCommand(querry, connection))

                {
                    command.Parameters.Add("@genre", SqlDbType.NVarChar, 20).Value = obj.Name;
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

        public async Task<List<Genre>> GetAll()
        {
            List<Genre> list = new List<Genre>();
            string select = @"select * from Generes;";
            using (SqlCommand command = new SqlCommand(select, connection))
            {
                using (var reader = await command.ExecuteReaderAsync())
                {
                    while (await reader.ReadAsync())
                    {
                        list.Add(new Genre()
                        {
                            Id = reader.GetInt32(0),
                            Name = reader.GetString(1),

                        });
                    }
                }
            }
            return list;
        }

        public bool Update(Genre obj)
        {

            string querry = $"UPDATE Generes set genre=@genre WHERE id=@id;";
            using (SqlCommand command = new SqlCommand(querry, connection))

            {
                command.Parameters.Add("@id", SqlDbType.Int).Value = obj.Id;
                command.Parameters.Add("@genre", SqlDbType.NVarChar, 20).Value = obj.Name;
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
        /*public async Task<List<Genre>> FindByValue(string name)
        {

            List<Genre> list = new List<Genre>();
            string select = @"select * from Generes;";
            using (SqlCommand command = new SqlCommand(select, connection))
            {
                using (var reader = await command.ExecuteReaderAsync())
                {
                    while (await reader.ReadAsync())
                    {
                        list.Add(new Genre()
                        {
                            Id = reader.GetInt32(0),
                            Name = reader.GetString(1),

                        });
                    }
                }
            }
            var listOfActors = list.Where(x => x.Name.ToLower().Contains(name.ToLower())).ToList();
            return listOfActors;
        }
        public async Task<Genre> FindById(int id)
        {
            Genre genre;
            string select = @"select * from Generes where id=@id;";
            using (SqlCommand command = new SqlCommand(select, connection))
            {
                command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                using (var reader = await command.ExecuteReaderAsync())
                {
                    while (await reader.ReadAsync())
                    {
                        genre = new Genre()
                        {
                            Id = reader.GetInt32(0),
                            Name = reader.GetString(1),

                        };
                        return genre;
                    }

                }
            }
            return null;
        }*/

        public bool Delete(int id)
        {
            string querry = $"DELETE FROM Generes WHERE id=@id;";
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

