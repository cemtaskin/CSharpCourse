using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditions
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

            

            if (num1 > num2)
            {
                Console.WriteLine("{0} is bigger than {1}", num1, num2);
            }else if (num1 < num2)
            {
                Console.WriteLine("{0} is lower than {1}", num1,num2);

            }
            else
            {
                Console.WriteLine("{0} is equal to {1}", num1, num2);
            }

            Console.ReadKey();
        }
    }
}
