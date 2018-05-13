using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Extract_Middle_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

                //when length is 1
                if (input.Length == 1)
                {
                    int[] extracted = new int[1];
                    extracted[0] = input[0];
                    Console.WriteLine($"{{ {string.Join("", extracted)} }}");
                }
                //when length is even number
                else if (input.Length % 2 == 0)
                {
                    int[] extracted = new int[2];
                    extracted[0] = input[input.Length / 2 - 1];
                    extracted[1] = input[input.Length / 2];
                    Console.WriteLine($"{{ {string.Join(", ", extracted)} }}");
                }
                //when length is odd number
                else if (input.Length % 2 != 0)
                {
                    int[] extracted = new int[3];
                    extracted[0] = input[input.Length / 2 - 1];
                    extracted[1] = input[input.Length / 2];
                    extracted[2] = input[input.Length / 2 + 1];
                    Console.WriteLine($"{{ {string.Join(", ", extracted)} }}");
            }
        }
    }
}
