using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _36.Count_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal[] input = Console.ReadLine().Split().Select(decimal.Parse).ToArray();

            Array.Sort(input);

            for (long i = 0; i < input.Length; i++)
            {
                long count = 1;

                if (i == input.Length - 1)
                {
                    Console.WriteLine($"{input[i]} -> {count}");
                    break;
                }

                while (input[i] == input[i + 1])
                {
                    count++;
                    i++;
                    if (i == input.Length - 1)
                    {
                        break;
                    }
                }
                Console.WriteLine($"{input[i]} -> {count}");
            }

        }
    }
}
