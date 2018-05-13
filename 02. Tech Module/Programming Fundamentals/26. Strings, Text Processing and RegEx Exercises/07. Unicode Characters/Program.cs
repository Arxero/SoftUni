using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Unicode_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] input = Console.ReadLine().ToCharArray();

            foreach (var Char in input)
            {
                Console.Write("\\u" + ((int)Char).ToString("X").PadLeft(4, '0').ToLower());
            }
            Console.WriteLine();
        }
    }
}
