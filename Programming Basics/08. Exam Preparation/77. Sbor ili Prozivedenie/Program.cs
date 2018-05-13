using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _77.Sbor_ili_Prozivedenie
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); // 5:53

            bool lamp = false;

            for (int a = 1; a <= 30; a++)
            {
                for (int b = 1; b <= 30; b++)
                {
                    for (int c = 1; c <= 30; c++)
                    {
                        if (a + b + c == n && (a < b && b < c && a < c))
                        {
                            Console.WriteLine($"{a} + {b} + {c} = {n}");
                            lamp = true;
                        }
                        else if (a * b * c == n && (a > b && b > c && a > c))
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
