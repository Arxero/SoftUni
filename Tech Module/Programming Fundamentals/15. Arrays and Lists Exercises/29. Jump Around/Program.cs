using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29.Jump_Around
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int sum = 0;

            for (int i = 0; i < input.Length;)
            {
                int power = input[i];
                sum += input[i];

                if (i + power < input.Length)
                {
                    i = i + power;
                }
                else if (i - power >= 0)
                {
                    i = i - power;
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
