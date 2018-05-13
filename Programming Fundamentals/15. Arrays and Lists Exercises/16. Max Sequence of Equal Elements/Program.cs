using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int count = 1;
            int maxCount = 1;
            int start = 0;
            int end = 0;
            int helper = 1;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] >= input[helper])
                {
                    count++;
                    helper++;
                    if (count > maxCount)
                    {
                        //keeping how long  is the sequence of increasing numbers
                        maxCount = count;
                        start = end;
                    }
                }
                else
                {
                    count = 1;
                    end = i;
                    helper = i;
                }
            }
            for (int i = start; i < start + maxCount; i++)
            {
                Console.Write($"{input[i]} ");
            }
            Console.WriteLine();
        }
    }
}
