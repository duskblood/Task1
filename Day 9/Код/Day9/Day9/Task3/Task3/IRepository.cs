using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public interface IRepository<T>
    {
        void Add(T item);
        bool Remove(T item);
        IEnumerable<T> GetAll();
    }
}
