using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loop3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<String> names = new List<string>() { "Baran", "Batuhan", "Baturhan", "Harun" };

            foreach(String name in names)
            {
                Console.WriteLine(name);
                Console.WriteLine(name.Length);
            }

            Console.ReadLine();
        }
    }
}
