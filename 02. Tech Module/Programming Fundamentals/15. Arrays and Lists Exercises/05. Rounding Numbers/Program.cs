using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Rounding_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] input = Console.ReadLine().Split().Select(double.Parse).ToArray();

            for (int i = 0; i < input.Length; i++)
            {
                double absoluteValue = Math.Abs(input[i]);
                double result = Math.Truncate(absoluteValue + 0.5);
                if (input[i] < 0)
                {
                    result *= -1;
                }
                Console.WriteLine($"{input[i]} => {result}");
            }
        }
    }
}
