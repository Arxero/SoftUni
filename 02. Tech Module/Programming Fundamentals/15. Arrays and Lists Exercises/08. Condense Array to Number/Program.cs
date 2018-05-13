using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Condense_Array_to_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            while (input.Length != 1)
            {
                int[] condensed = new int[input.Length - 1];
                for (int i = 0; i < input.Length - 1; i++)
                {
                    condensed[i] = input[i] + input[i + 1];
                }
                input = condensed;
            }
            Console.WriteLine(string.Join("", input));
        }
    }
}
