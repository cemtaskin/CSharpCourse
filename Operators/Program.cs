using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            //int x = 100 + 50;
            //Console.WriteLine(x);

            //int sum1 = 100 + 50;
            //int sum2 = sum1 + 250;
            //int sum3 = sum2 + sum2;

            //Console.WriteLine("The value of sum1 variable is {0}", sum1);
            //Console.WriteLine("The value of sum2 variable is {0}", sum2);
            //Console.WriteLine("The value of sum3 variable is {0}", sum3);

            Console.WriteLine("Please enter the first number");
            String value = Console.ReadLine();

            int num1 = Convert.ToInt32(value);

            Console.WriteLine("Please enter the second number");
            value = Console.ReadLine();

            int num2 = Convert.ToInt32(value);


            Console.WriteLine("The numbers that you entered are : {0} - {1}",num1,num2);
            Console.WriteLine("The addidion of numbers  is {0}", num1+ num2);
            Console.WriteLine("The substraction of numbers  is {0}", num1 - num2);
            Console.WriteLine("The multiplication of numbers  is {0}", num1 * num2);
            Console.WriteLine("The divison of numbers  is {0}", num1 % num2);
            Console.WriteLine("The modulous of numbers  is {0}", num1 % num2);
            num1++;
            num2--;
            Console.WriteLine("The increment  of first number  is {0}", num1);
            Console.WriteLine("The decrement  of second number  is {0}", num2);






            Console.ReadKey();




        }
    }
}
