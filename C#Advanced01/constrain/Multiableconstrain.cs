using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Advanced01.constrain
{
    #region Q12
    internal class Multiableconstrain<Tkey> where Tkey : class, IEquatable<Tkey>, new()
    {
        //use for decrese the scope make genaric more limited like must be class and Equatable and must have parameter less constractor
    } 
    #endregion
}
