using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Equal_Pairs
{
    class Program
    {
        static void Main(string[] args)
        {
            int rotations = int.Parse(Console.ReadLine());

            int firstPair = 0;
            int secondPair = 0;
            int maxDiff = 0;

            for (int i = 0; i < rotations; i++)
            {
                secondPair = firstPair;

                int first = int.Parse(Console.ReadLine());
                int second = int.Parse(Console.ReadLine());

                firstPair = first + second;

                if (i > 0)
                {
                    int currentDiff = Math.Abs(secondPair - firstPair);
                    if (currentDiff > maxDiff)
                    {
                        maxDiff = currentDiff;
                    }
                }
            }
            if (maxDiff == 0)
            {
                // No diff
                Console.WriteLine($"Yes, value={firstPair}");
            }
            else
            {
                Console.WriteLine($"No, maxdiff={maxDiff}");
            }

        }
    }
}
