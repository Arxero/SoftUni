using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Magic_Letter
{
    class Program
    {
        static void Main(string[] args)
        {
            char first = char.Parse(Console.ReadLine());
            char second = char.Parse(Console.ReadLine());
            char third = char.Parse(Console.ReadLine());

            for (char a = first; a <= second; a++)
            {
                for (char b = first; b <= second; b++)
                {
                    for (char c = first; c <= second; c++)
                    {
                        if (!(a == third || b == third || c == third))
                        {
                            Console.Write($"{a}{b}{c} ");
                        }
                    }
                }
            }
            Console.WriteLine();
        }
    }
}
