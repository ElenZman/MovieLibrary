using ClassLibrary.DataAccess;
using ClassLibrary.DataAccess.Interfaces;
using ClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;


namespace ClassLibrary.DataAccess
{
    public class UserTable : Table, IDataAccess<User>
    {

        public UserTable(string name) : base(name)
        {

        }
        public bool Add(User obj)
        {

            string querry = "INSERT INTO Users VALUES (@login, @password, @accessMode);";
            {
                using (SqlCommand command = new SqlCommand(querry, connection))

                {
                    command.Parameters.Add("@login", SqlDbType.NVarChar, 20).Value = obj.Login;
                    command.Parameters.Add("@password", SqlDbType.NVarChar, 8).Value = obj.Password;
                    command.Parameters.Add("@accessMode", SqlDbType.Int).Value = obj.Role;
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
       /* public async Task<User> FindById(int id)
        {
            User user;
            string select = @"select * from Users where id=@id;";
            using (SqlCommand command = new SqlCommand(select, connection))
            {
                command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                using (var reader = await command.ExecuteReaderAsync())
                {
                    while (await reader.ReadAsync())
                    {
                        user = new User()
                        {
                            Id = reader.GetInt32(0),
                            Name = reader.GetString(1),
                            // Password = reader.GetString(2),
                            Access = reader.GetInt32(3)

                        };
                        return user;
                    }

                }
            }
            return null;
        }

        public async Task<List<User>> FindByValue(string login)
        {
            List<User> list = new List<User>();
            string find = "select * from Users;";
            using (SqlCommand command = new SqlCommand(find, connection))
            {

                using (var reader = await command.ExecuteReaderAsync())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            list.Add(new User()
                            {
                                Id = reader.GetInt32(0),
                                Name = reader.GetString(1),
                                Password = reader.GetString(2),
                                Access = reader.GetInt32(3),
                            });

                        }
                    }
                }
                var listOfUsers = list.Where(x => x.Name.ToLower().Contains(login.ToLower())).ToList();
                return listOfUsers;
            }

        }*/



        public async Task<List<User>> GetAll()
        {
            List<User> list = new List<User>();
            string select = @"select * from Users;";
            using (SqlCommand command = new SqlCommand(select, connection))
            {
                using (var reader = await command.ExecuteReaderAsync())
                {
                    while (await reader.ReadAsync())
                    {
                        list.Add(new User()
                        {
                            Id = reader.GetInt32(0),
                            Login = reader.GetString(1),
                            Password = reader.GetString(2),
                            Role = reader.GetInt32(3),

                        });
                    }
                }
            }
            return list;
        }

        public bool Update(User obj)
        {
            string querry = $"UPDATE Users set access=@access WHERE id=@id;";
            using (SqlCommand command = new SqlCommand(querry, connection))

            {
                command.Parameters.Add("@id", SqlDbType.Int).Value = obj.Id;
                command.Parameters.Add("@access", SqlDbType.Int).Value = obj.Role;
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
            string querry = $"DELETE FROM Users WHERE id=@id;";
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

