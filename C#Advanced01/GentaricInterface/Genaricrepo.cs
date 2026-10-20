using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Advanced01.GentaricInterface
{
    internal class Genaricrepo<T> : IRepository<T>
    {
        public readonly List<T> list;
        public void Add(T item)
        {
            list.Add(item);
        }

        public List<T> getAll(int id)
        {
          return list;
        }
    }
}
