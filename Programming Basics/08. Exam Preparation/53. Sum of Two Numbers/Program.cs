using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _53.Sum_of_Two_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine()); // 1:35
            int end = int.Parse(Console.ReadLine());
            int magic = int.Parse(Console.ReadLine());

            int counter = 0;
            bool ass = true;

            for (int a = start; a <= end; a++)
            {
                for (int b = start; b <= end; b++)
                {
                    counter++;
                    ass = false;
                    if (a + b == magic)
                    {
                        Console.WriteLine($"Combination N:{counter} ({a} + {b} = {magic})");
                        ass = true;
                        break;
                    }
                }
                if (ass == true)
                {
                    break;
                }
            }
            if (ass == false)
            {
                Console.WriteLine($"{counter} combinations - neither equals {magic}");
            }
            

        }
    }
}
