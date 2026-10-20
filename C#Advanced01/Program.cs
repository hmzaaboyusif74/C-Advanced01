using C_Advanced01.constrain;
using C_Advanced01.Genaric;
using C_Advanced01.GentaricInterface;
using System.Reflection.Metadata;

namespace C_Advanced01
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Q1
            //Container<int> G01 = new Container<int>(5);


            //G01.Add(10);
            //G01.Add(23);
            //G01.Add(15);

            //foreach (int i in G01._item)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine("-----------------");

            //Console.WriteLine(G01.Getnum(2)); 
            #endregion
            #region MyRegion
            //Container<string> Name = new Container<string>(3);
            //Name.Add("hmza");
            //Name.Add("Ahmed");

            //for (int i = 0; i < Name.Value.Length; i++) 
            //{
            //    Console.WriteLine(Name.Value[i]);
            //}

            #endregion
            #region Q4
            //MulitableParameter<int, double> multi01 = new MulitableParameter<int, double>(15,20.5);
            //int num1 = 10;
            //int num2 = 20;
            //multi01.swap(ref num1, ref num2);
            #endregion
            #region Q5
            //Methode<int> num01 = new Methode<int>(6);
            //num01.nums = new int[] { 15, 16, 2, 56, 312, 45 };
            //int res=  num01.maxnum(num01.nums);
            //Console.WriteLine(res);
            #endregion
            #region Q6
            // genaric interface use for 5 CRUD operation (add-delet-update-getId-getall)
            Genaricrepo<Product> repo01 = new Genaricrepo<Product>();
            repo01.Add(new Product(5, "ahmed"));
            #endregion
            #region Q7-Q8
            structConstrain<Struct> s01= new structConstrain<Struct>();
           // structConstrain<Product> s01 = new structConstrain<Product>(); // becouse that need only stract
            classConstrain<Product> c01 = new classConstrain<Product>(); //must genaric as class
            c01.print();
            #endregion
            //Q9-Q10-Q11-Q12 at constrain file
            #region Q13
            // use for return the defult value of genaric (int-bool-double) and if it refrance type return null
            #endregion
            #region Q14
            SafeList<string> names = new SafeList<string>();
            names.Add("Ahmed");
            #endregion
            #region Q15 - Q16- Q17
            // Covariance can allow get objectchild from perants 
            // out keyword make genaric allow return only
            // contravariance let can genaric add only in object in heap but cannot return
            // in keyword make it must be add only and cannot return
            #endregion
            #region Q18
            //every type of static seperate from onther type like int or string 
            // genaric<int> G01=newgenaric<int>(); //count=1
            // genaric<int> G02=newgenaric<int>();//count=2 Becouse same type
            // genaric<string> G03=newgenaric<string>();//count=1
            #endregion
            #region Q19
            //1-inhert from genaric class  perant<T>:child<T>
            //2-inhert by special type(non genaric )    perant:child<int> 
            //3-inhert with constrain perant <T> :child<T> where T : class ,new()
            #endregion
            #region Q20

            #endregion

        }
    }
}
