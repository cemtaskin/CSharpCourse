using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the first number");
            String value = Console.ReadLine();

            int num1 = Convert.ToInt32(value);

            Console.WriteLine("Please enter the second number");
            value = Console.ReadLine();

            int num2 = Convert.ToInt32(value);

            Console.WriteLine("The highest value of two numbers is :{0} ", Math.Max(num1, num2));
            Console.WriteLine("The lowest value of two numbers is :{0} ", Math.Min(num1, num2));
            Console.WriteLine("The sqrt value of first numbers is :{0} ", Math.Sqrt(num1));
            Console.WriteLine("The sqrt value of second numbers is :{0} ", Math.Sqrt(num2));

            Console.ReadKey();



        }
    }
}
