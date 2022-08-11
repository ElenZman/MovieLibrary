using ClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieLibrary
{
    public class Registration
    {

        //private SqlConnection connection;
        private readonly TableManager _manager;

        public Registration()
        {
            /*connection = new SqlConnection(@"Data Source= DESKTOP-NPSC8CE\SQLEXPRESS;
                                            Initial Catalog = FilmLibrary; 
                                            Integrated Security=SSPI;");
            connection.Open();*/
            _manager = TableManager.GetManager();
        }

        public bool AddNewUsers(string login, string password)
        {
            bool IsRegistred = false;
            User user = new User()
            {
                Login = login,
                Password = password,
                Role = 1
            };
            //Role всегда стоит по умолчанию, таким образом, не возможно получить 
            //уровень доступа админа при простой регистрации
            if (_manager.userTable.Add(user))
            {
                IsRegistred = true;
            }
            return IsRegistred;           
        }        
    }
}

