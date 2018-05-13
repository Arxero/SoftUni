using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _58.Raindrops
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            decimal density = decimal.Parse(Console.ReadLine());
            decimal sum = 0;
            decimal regionalCoefficient = 0;

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                decimal raindropsCount = decimal.Parse(input[0]);
                decimal squareMeters = decimal.Parse(input[1]);

                regionalCoefficient = raindropsCount / squareMeters;
                sum += regionalCoefficient;
            }
            try
            {
                decimal calculation = sum / density;
                Console.WriteLine($"{calculation:f3}");
            }
            catch (Exception)
            {

                Console.WriteLine($"{sum:f3}");
            }
        }
    }
}
