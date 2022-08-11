using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.DataAccess
{
    public class DBConnection
    {
        protected string connectionString;
        protected SqlConnection connection;

        public DBConnection()
        {
            connectionString = @"Data Source= DESKTOP-NPSC8CE\SQLEXPRESS;
                                            Initial Catalog = FilmLibrary; 
                                            Integrated Security=SSPI;";
            connection = new SqlConnection(connectionString);
            connection.Open();
        }

        public void Dispose()
        {
            connection.Close();
        }



    }
}
