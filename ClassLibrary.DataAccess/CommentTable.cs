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
    public class CommentTable : Table, IDataAccess<Comment>
    {
        public CommentTable(string name) : base(name)
        {

        }

        public bool Add(Comment obj)
        {
            string querry = "INSERT INTO Comments VALUES (@filmId, @userId, @commentText);";
            {
                using (SqlCommand command = new SqlCommand(querry, connection))

                {
                    command.Parameters.Add("@filmId", SqlDbType.Int).Value = obj.FilmId;
                    command.Parameters.Add("@userId", SqlDbType.Int).Value = obj.UserId;
                    command.Parameters.Add("@commentText", SqlDbType.NVarChar, 1000).Value = obj.CommentText;
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

        public async Task<List<Comment>> GetAll()
        {
            List<Comment> list = new List<Comment>();
            string select = @"select * from Comments;";
            using (SqlCommand command = new SqlCommand(select, connection))
            {
                try
                {
                    using (var reader = await command.ExecuteReaderAsync())
                    {
                        if (reader.HasRows)
                        {
                            while (await reader.ReadAsync()) list.Add(new Comment()
                            {
                                Id = reader.GetInt32(0),
                                FilmId = reader.GetInt32(1),
                                UserId = reader.GetInt32(2),
                                CommentText = reader.GetString(3),
                            });
                        }
                    }
                }

                catch
                {
                    command.Cancel();
                    return null;
                }
            }
            return list;
        }

        /*public List<Comment> FindByUserId(int userId)
        {
            List<Comment> list = new List<Comment>();
            string select = @"select * from Comments where fk_user=@id;";
            using (SqlCommand command = new SqlCommand(select, connection))
            {
                command.Parameters.Add("@id", SqlDbType.Int).Value = userId;
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Comment()
                        {
                            Id = reader.GetInt32(0),
                            FilmId = reader.GetInt32(1),
                            UserId = reader.GetInt32(2),
                            CommentText = reader.GetString(3)
                        });

                    }

                }
            }
            return list;
        }

        /*public List<Comment> FindByFilmID(int filmId)
        {
            List<Comment> list = new List<Comment>();
            string select = @"select * from Comments where fk_film=@id;";
            using (SqlCommand command = new SqlCommand(select, connection))
            {
                command.Parameters.Add("@id", SqlDbType.Int).Value = filmId;
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Comment()
                        {
                            Id = reader.GetInt32(0),
                            FilmId = reader.GetInt32(1),
                            UserId = reader.GetInt32(2),
                            CommentText = reader.GetString(3)
                        });

                    }

                }
            }
            return list;
        }*/

        public bool Update(Comment obj)
        {
            string querry = $"UPDATE Comments set fk_film=@filmId, fk_user=@userId," +
                $"comment=@comment WHERE id=@id;";
            using (SqlCommand command = new SqlCommand(querry, connection))

            {
                command.Parameters.Add("@id", SqlDbType.Int).Value = obj.Id;
                command.Parameters.Add("@filmId", SqlDbType.Int).Value = obj.FilmId;
                command.Parameters.Add("@userId", SqlDbType.Int).Value = obj.UserId;
                command.Parameters.Add("@comment", SqlDbType.NVarChar, 2000).Value = obj.CommentText;
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
            string querry = $"DELETE from Comments WHERE id=@id;";
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

