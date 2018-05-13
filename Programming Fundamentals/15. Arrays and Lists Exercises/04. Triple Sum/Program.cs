using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Triple_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            bool lamp = true;

            for (int i = 0; i < input.Length; i++)
            {
                int a = input[i];
                //here i + 1 cause we need to check/get the next number in the array
                // if it is i again it a would be again the same in the second loop
                for (int k = i + 1; k < input.Length; k++)
                {
                    int b = input[k];
                    int sum = a + b;
                    
                    if (input.Contains(sum))
                    {
                        Console.WriteLine($"{a} + {b} == {sum}");
                        lamp = false;
                    }
                }
            }
            if (lamp)
            {
                Console.WriteLine("No");
            }
        }
    }
}
