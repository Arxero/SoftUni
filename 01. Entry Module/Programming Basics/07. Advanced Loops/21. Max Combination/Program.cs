using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21.Max_Combination
{
    class Program
    {
        static void Main(string[] args)
        {
            int beginning = int.Parse(Console.ReadLine()); // 9:45
            int ending = int.Parse(Console.ReadLine());
            int max = int.Parse(Console.ReadLine());

            int count = 0;

            for (int first = beginning; first <= ending; first++)
            {
                for (int second = beginning; second <= ending; second++)
                {
                    count++;
                    if (max < count)
                    {
                        break;
                    }
                    Console.Write($"<{first}-{second}>");

                }
            }
            Console.WriteLine();
        }
    }
}
