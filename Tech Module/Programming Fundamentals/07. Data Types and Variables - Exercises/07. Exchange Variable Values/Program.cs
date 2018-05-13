using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Exchange_Variable_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            a = 5;
            b = 10;
            Console.WriteLine($"Before: ");
            Console.WriteLine($"a = {a}");
            Console.WriteLine($"b = {b}");
            a = 10;
            b = 5;
            Console.WriteLine($"After: ");
            Console.WriteLine($"a = {a}");
            Console.WriteLine($"b = {b}");

        }
    }
}
