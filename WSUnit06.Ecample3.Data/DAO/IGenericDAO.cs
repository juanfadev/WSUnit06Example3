using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;

namespace WS.Unit06.Example3.Data.DAO
{
    public interface IGenericDAO<T> where T:class
    {
        bool Add(T t);
        bool Remove(T t);
        bool Update(T t);
        T Find(int id);
        IEnumerable<T> All();
        int Count();
    }
}
