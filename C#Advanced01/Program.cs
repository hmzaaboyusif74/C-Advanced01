using C_Advanced01.Genaric;

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

        }
    }
}
