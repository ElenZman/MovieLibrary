using ClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieLibrary
{
    public class Entry
    {

        private readonly TableManager _manager; 
        public Entry()
        {
            _manager = TableManager.GetManager();   
        }

        public async Task<User> Enter(string login, string password)
        {
            var allUsers = await _manager.userTable.GetAll();
            User user = allUsers.Where(u => u.Login == login && u.Password == password).FirstOrDefault();
            return user;

        }
    }
}
