using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.Resurrection
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());

            for (long i = 0; i < n; i++)
            {
                long totalLength = long.Parse(Console.ReadLine());
                decimal totalWidth = decimal.Parse(Console.ReadLine());
                long wingLength = long.Parse(Console.ReadLine());

                decimal totalYears = totalLength * totalLength;
                decimal sum = totalWidth + (2 * wingLength);
                decimal result = totalYears * sum;
                Console.WriteLine($"{result}");
            }
        }
    }
}
