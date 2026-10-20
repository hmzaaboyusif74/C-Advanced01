using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Advanced01.exrcise
{
    internal class genericCache<Tkey,Tvalve>
    {
         public readonly List<Tkey> keys= new List<Tkey>();
        public readonly List<Tvalve> values = new List<Tvalve>();

        public void Add(Tkey key)
        {
            keys.Add(key);
        }
        public Tvalve Get(Tkey key)
        {
            if (keys.Contains(key)) {  return values[keys.IndexOf(key)]; } else
            {
                return default;
            }

         }
        public bool Remove(Tkey key)
        {
            return keys.Remove(key);
        }
    }
}
