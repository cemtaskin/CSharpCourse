using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {

            string name = "John";
            Console.WriteLine(name);
            Console.WriteLine(name.Length);
            Console.WriteLine(name.ToUpper());
            Console.WriteLine(name.ToLower());
            Console.WriteLine(name.Substring(3));


            Console.WriteLine("--------------------------------");

            int myNum = 15;
            Console.WriteLine(myNum);
            myNum += 5;
            Console.WriteLine(myNum);

            double myDoubleNumber = 5.99D;
            char myChar = 'C';
            bool myBool = false;
            string myText = "hello";

            Console.WriteLine(myDoubleNumber);
            Console.WriteLine(myChar);
            Console.WriteLine(myBool);
            Console.WriteLine(myText);



            Console.ReadLine();
        }
    }
}
