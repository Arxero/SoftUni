using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Strings_And_Objects
{
    class Program
    {
        static void Main(string[] args)
        {
            string first = Console.ReadLine();
            string second = Console.ReadLine();

            object variable = first +" "+ second;
            Console.WriteLine($"{variable}");
        }
    }
}
