using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Practice_Chars_And_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string one = Console.ReadLine();
            char second = char.Parse(Console.ReadLine());
            char third = char.Parse(Console.ReadLine());
            char four = char.Parse(Console.ReadLine());
            string fifth = Console.ReadLine();

            Console.WriteLine($"{one}");
            Console.WriteLine($"{second}");
            Console.WriteLine($"{third}");
            Console.WriteLine($"{four}");
            Console.WriteLine($"{fifth}");
        }
    }
}
