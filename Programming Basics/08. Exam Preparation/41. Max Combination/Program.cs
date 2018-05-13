using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _41.Max_Combination
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine()); // 12:29
            int end = int.Parse(Console.ReadLine());
            int max = int.Parse(Console.ReadLine());

            int counter = 0;

            for (int i = start; i <= end; i++)
            {
                for (int j = start; j <= end; j++)
                {
                    counter++;
                    Console.Write($"<{i}-{j}>");
                    if (counter == max)
                    {
                        break;
                    }
                }
                if (counter == max)
                {
                    break;
                }
            }
            Console.WriteLine();
        }
    }
}
