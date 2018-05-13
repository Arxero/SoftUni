using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19.Odd_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray().Where(x => x % 2 == 0).ToArray();

            double average = input.Average();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] > average)
                {
                    input[i] += 1;
                }
                else
                {
                    input[i] -= 1;
                }
            }
            Console.WriteLine(string.Join(" ", input));
        }
    }
}
