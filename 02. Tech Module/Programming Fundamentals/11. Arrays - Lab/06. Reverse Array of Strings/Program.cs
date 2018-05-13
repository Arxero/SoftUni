using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Reverse_Array_of_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] items = input.Split(' ');

            for (int i = items.Length; i > 0; i--)
            {
                Console.Write($"{items[i - 1]} ");
            }
            Console.WriteLine();
        }
    }
}
