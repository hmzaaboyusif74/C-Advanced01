using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Advanced01.GentaricInterface
{
    internal class Perant<T>:BaseEntity<T> where T : class, new()
    {

        public string perantName {  get; set; }
        
        public Perant(int id,string perantName):base(id)
        {
            this.perantName = perantName;
        }
    }
}
