using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _59.Two_Numbers_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine()); // 10:14
            int end = int.Parse(Console.ReadLine());
            int magic = int.Parse(Console.ReadLine());

            int count = 0;
            bool lamp = false;

            for (int a = start; a >= end; a--)
            {
                for (int b = start; b >= end; b--)
                {
                    count++;
                    if (a + b == magic)
                    {
                        lamp = true;
                        Console.WriteLine($"Combination N:{count} ({a} + {b} = {magic})");
                        break;
                    }
                }
                if (lamp == true)
                {
                    break;
                }
            }
            if (lamp == false)
            {
                Console.WriteLine($"{count} combinations - neither equals {magic}");

            }

        }
    }
}
