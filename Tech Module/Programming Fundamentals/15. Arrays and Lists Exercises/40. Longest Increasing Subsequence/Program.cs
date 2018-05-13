using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _40.Longest_Increasing_Subsequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] lengthCurrent = new int[input.Length];
            int[] lengthPrevious = new int[input.Length];

            for (int i = 0; i < input.Length - 1; i++)
            {
                int length = 0;
                if (input[i] < input[i + 1])
                {
                    length++;
                    lengthCurrent[i] = length;
                }
            }
        }
    }
}
