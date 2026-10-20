using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Advanced01.GentaricInterface
{
    internal interface IRepository<T> 
    {

        public void Add(T item);
        public List<T> getAll(int id);
    }
}
