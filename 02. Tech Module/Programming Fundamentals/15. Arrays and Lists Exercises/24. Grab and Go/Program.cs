using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24.Grab_and_Go
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] input = Console.ReadLine().Split().Select(long.Parse).ToArray();
            long n = long.Parse(Console.ReadLine());
            long[] sumArr = new long[input.Length];

            Array.Reverse(input);
            bool lamp = false;

            for (long i = 0; i < input.Length; i++)
            {
                if (input[i] == n)
                {
                    for (long k = i + 1; k < input.Length; k++)
                    {
                        sumArr[i++] = input[k];
                        lamp = true;
                    }
                }
            }

            if (lamp)
            {
                Console.WriteLine(sumArr.Sum());
                
            }
            else
            {
                Console.WriteLine("No occurrences were found!");
            }
        }
    }
}
