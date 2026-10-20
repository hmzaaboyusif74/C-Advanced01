using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Advanced01.Genaric
{
    internal class SafeList<T01>
    {
        private readonly List<T01> _items = new List<T01>();

       
        public void Add(T01 item)
        {
            _items.Add(item);
        }

      
        public T01 GetElementAt(int index)
        {
       
            if (index < 0 || index >= _items.Count)
            {
               
                return default(T01);
            }

            return _items[index];
        }
    }
}
