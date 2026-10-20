using C_Advanced01.constrain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Advanced01.GentaricInterface
{
    #region Q11
    internal class BaseEntity<T> : interfaceconstrain<T> where T : class, new()
    {
        public int Id { get; set; }

        public BaseEntity(int id)
        {
            Id = id;
        }
        public BaseEntity()
        {

        } 
    #endregion
    }
}
