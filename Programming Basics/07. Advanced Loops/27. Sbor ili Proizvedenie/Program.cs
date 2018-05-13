using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27.Sbor_ili_Proizvedenie
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); // 6:50

            bool lamp = false;

            for (int a = 1; a <= 30; a++)
            {
                for (int b = 1; b <= 30; b++)
                {
                    for (int c = 1; c <= 30; c++)
                    {
                        if (a + b + c == n && (a < b && a < c && b < c))
                        {
                            Console.WriteLine($"{a} + {b} + {c} = {n}");
                            lamp = true;
                        }
                        if (a * b * c == n && (a > b && a > c && b > c))
                        {
                            Console.WriteLine($"{a} * {b} * {c} = {n}");
                            lamp = true;
                        }
                    }
                }
            }
            if (lamp == false)
            {
                Console.WriteLine("No!");
            }
        }
    }
}
