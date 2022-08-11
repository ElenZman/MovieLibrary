using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.DataAccess.Interfaces
{
    public interface IDataAccess<T> where T : class
    {
        bool Add(T obj);
        bool Update(T obj);
        bool Delete(int id);
        Task<List<T>> GetAll();

    }
}
