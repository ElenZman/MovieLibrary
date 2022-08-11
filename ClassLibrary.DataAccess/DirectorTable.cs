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
    public class DirectorTable : Table, IDataAccess<Director>
    {
        public DirectorTable(string name) : base(name)
        {

        }
        public bool Add(Director obj)
        {

            string querry = "INSERT INTO Directors VALUES (@directorName);";
            {
                using (SqlCommand command = new SqlCommand(querry, connection))

                {
                    command.Parameters.Add("@directorName", SqlDbType.NVarChar, 20).Value = obj.Name;
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
            string querry = $"DELETE FROM Directors WHERE id=@id;";
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

        /* public async Task<List<Director>> FindByValue(string name)
         {

             List<Director> list = new List<Director>();
             string select = "select * from Directors;";
             using (SqlCommand command = new SqlCommand(select, connection))
             {
                 using (var reader = await command.ExecuteReaderAsync())
                 {
                     if (reader.HasRows)
                     {
                         while (await reader.ReadAsync())
                         {
                             list.Add(new Director()
                             {
                                 Id = reader.GetInt32(0),
                                 Name = reader.GetString(1),

                             });
                         }
                         var listOfDirectors = list.Where(x => x.Name.ToLower().Contains(name.ToLower())).ToList();
                         return listOfDirectors;
                     }
                 }
             }
             return null;
         }

         public async Task<Director> FindById(int id)
         {
             Director director;
             string select = @"select * from Directors where id=@id;";
             using (SqlCommand command = new SqlCommand(select, connection))
             {
                 command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                 using (var reader = await command.ExecuteReaderAsync())
                 {
                     while (await reader.ReadAsync())
                     {
                         director = new Director() { Id = reader.GetInt32(0), Name = reader.GetString(1) };
                         return director;
                     }
                 }
             }
             return null;
         }*/

        public async Task<List<Director>> GetAll()
        {
            List<Director> list = new List<Director>();
            string select = @"select * from Directors;";
            using (SqlCommand command = new SqlCommand(select, connection))
            {
                using (var reader = await command.ExecuteReaderAsync())
                {
                    while (await reader.ReadAsync())
                    {
                        list.Add(new Director() { Id = reader.GetInt32(0), Name = reader.GetString(1) });
                    }
                }
            }
            return list;
        }

        public bool Update(Director obj)
        {
            string querry = $"UPDATE Directors set directorName=@directorName WHERE id=@id;";
            using (SqlCommand command = new SqlCommand(querry, connection))

            {
                command.Parameters.Add("@id", SqlDbType.Int).Value = obj.Id;
                command.Parameters.Add("@directorName", SqlDbType.NVarChar, 50).Value = obj.Name;
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