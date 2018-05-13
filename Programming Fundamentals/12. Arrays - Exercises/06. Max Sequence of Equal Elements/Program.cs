using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int longestLength = 1;
            int longestStart = 0;

            int currentLength = 1;
            int currentStart = 0;

            int[] start = new int[numbers.Length];
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] == numbers[i - 1])
                {
                    currentLength++;
                    if (currentLength > longestLength)
                    {
                        longestLength = currentLength;
                        longestStart = currentStart;
                    }
                }
                else
                {
                    currentLength = 1;
                    currentStart = i;
                }
            }
            for (int i = longestStart; i < longestStart + longestLength; i++)
            {
                Console.Write(numbers[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
