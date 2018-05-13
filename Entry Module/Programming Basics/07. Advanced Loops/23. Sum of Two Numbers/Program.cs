using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23.Sum_of_Two_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine()); // 4:50
            int end = int.Parse(Console.ReadLine());
            int magic = int.Parse(Console.ReadLine());

            int count = 0;
            bool lamp = false;

            for (int first = start; first >= end; first--)
            {
                for (int second = start; second >= end; second--)
                {
                    count++;
                    if (end < start && first + second == magic)
                    {
                        Console.WriteLine($"Combination N:{count} ({first} + {second} = {magic})");
                        lamp = true;
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