using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.DataAccess
{
    public abstract class Table:DBConnection
    {
        public string TableName { get; private set; }

        protected DataTable dataTable;

        protected SqlDataAdapter adapter;


        public Table(string tableName)
        {
            TableName = tableName;
            dataTable = new DataTable();
        }


        public Task<DataTable> ShowTableAsync()
        {

            dataTable.Clear();
            return Task.Run(() =>
            {
                adapter = new SqlDataAdapter($"select * from {TableName};", connection);
                adapter.Fill(dataTable);
                return dataTable;
            }
          );
        }
    }
}
