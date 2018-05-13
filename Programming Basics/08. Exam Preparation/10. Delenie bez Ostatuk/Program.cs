using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Delenie_bez_Ostatuk
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); // 7:01

            double p1 = 0;
            double p2 = 0;
            double p3= 0;

            for (int i = 0; i < n; i++)
            {
                int nextNums = int.Parse(Console.ReadLine());

                if (nextNums % 2 == 0)
                {
                    p1++;
                }
                if (nextNums % 3 == 0)
                {
                    p2++;
                }
                if (nextNums % 4 == 0)
                {
                    p3++;
                }
            }
            Console.WriteLine($"{p1 / n * 100:f2}%");
            Console.WriteLine($"{p2 / n * 100:f2}%");
            Console.WriteLine($"{p3 / n * 100:f2}%");
        }
    }
}
