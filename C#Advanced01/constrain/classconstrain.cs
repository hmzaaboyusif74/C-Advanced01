using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Advanced01.constrain
{
    internal class classConstrain<T> where T : class
    {
       public void print()
        {
            Console.WriteLine("classconstrain");
        }
    }
}
