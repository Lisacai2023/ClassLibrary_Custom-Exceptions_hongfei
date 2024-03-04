using MyClassLibrary;
using System.Diagnostics;
using System.Linq.Expressions;
using System.Numerics;


namespace ClassLibrary_Custom_Exceptions_hongfei
{

    //ClassLibrary_Custom_Exceptions
    //Hongfei
    //week8
    internal class Program
    {
        static void Main(string[] args)
        {
            var Addresult = MyMath.Add(20, 5);
            Console.WriteLine($"Add result is : {Addresult}");
            Console.WriteLine($"Subtract result is : {MyMath.Subtract(20, 5)}");
            Console.WriteLine($"Multipy result is : {MyMath.Multiply(20, 5)}");
            Console.WriteLine($"Divide result is : {MyMath.Divide(20, 5)}");

            try
            {
                Player player = new Player("", "100000");
                Console.WriteLine(player);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }




        }







    }
}
