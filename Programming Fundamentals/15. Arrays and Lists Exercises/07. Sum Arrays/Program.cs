using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Sum_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] input2 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] results = new int[Math.Max(input.Length, input2.Length)];

            for (int i = 0; i < results.Length; i++)
            {
                results[i] = input[i % input.Length] + input2[i % input2.Length];
            }
            foreach (var item in results)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
