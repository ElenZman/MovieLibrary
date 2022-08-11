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
    public class CountryTable: Table, IDataAccess<Country>
    {
        public CountryTable(string name) : base(name)
        {

        }

        public bool Add(Country obj)
        {
            string querry = "INSERT INTO Countries VALUES (@countryName);";
            {
                using (SqlCommand command = new SqlCommand(querry, connection))

                {
                    command.Parameters.Add("@countryName", SqlDbType.NVarChar, 20).Value = obj.Name;
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

        public async Task<List<Country>> GetAll()
        {
            List<Country> list = new List<Country>();
            string select = @"select * from Countries;";
            using (SqlCommand command = new SqlCommand(select, connection))
            {
                using (var reader = await command.ExecuteReaderAsync())
                {
                    while (await reader.ReadAsync())
                    {
                        list.Add(new Country()
                        {
                            Id = reader.GetInt32(0),
                            Name = reader.GetString(1),

                        });
                    }
                }
            }
            return list;
        }

        public bool Update(Country obj)
        {
            string querry = $"UPDATE Countries set country=@countryName where id=@id;";

            using (SqlCommand command = new SqlCommand(querry, connection))

            {
                command.Parameters.Add("@id", SqlDbType.Int).Value = obj.Id;
                command.Parameters.Add("@countryName", SqlDbType.NVarChar, 50).Value = obj.Name;
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
        /*public Country FindById(int id)
        {
            Country country;
            string select = @"select * from Countries where id=@id;";
            using (SqlCommand command = new SqlCommand(select, connection))
            {
                command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        country = new Country()
                        {
                            Id = reader.GetInt32(0),
                            Name = reader.GetString(1),

                        };
                        return country;
                    }

                }
            }
            return null;
        }
        public List<Country> FindByValue(string name)
        {

            List<Country> list = new List<Country>();
            string select = @"select * from Countries;";
            using (SqlCommand command = new SqlCommand(select, connection))
            {
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Country()
                        {
                            Id = reader.GetInt32(0),
                            Name = reader.GetString(1),

                        });
                    }
                }
            }
            var listOfCountries = list.Where(x => x.Name.ToLower().Contains(name.ToLower())).ToList();
            return listOfCountries;
        }*/

        public bool Delete(int id)
        {
            string querry = $"DELETE FROM Countries WHERE id=@id;";
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
