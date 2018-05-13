using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19.Pairs_by_Difference
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int num = int.Parse(Console.ReadLine());

            int count = 0;

            for (int i = 0; i < input.Length - 1; i++)
            {
                for (int k = i + 1; k < input.Length; k++)
                {
                    if (Math.Max(input[i], input[k]) - Math.Min(input[i], input[k]) == num)
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine(count);
        }
    }
}
