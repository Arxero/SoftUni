using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Rotate_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rotations = int.Parse(Console.ReadLine());
            int[] output = new int[input.Length];

            for (int i = 0; i < rotations; i++)
            {
                int lastElement = input[input.Length - 1];

                for (int k = 0; k < input.Length - 1; k++)
                {
                    input[input.Length - 1 - k] = input[input.Length - 2 - k];
                }

                input[0] = lastElement;

                for (int sumCycle = 0; sumCycle < input.Length; sumCycle++)
                {
                    output[sumCycle] += input[sumCycle];
                }
            }
            Console.WriteLine(string.Join(" ", output));
        }
    }
}
