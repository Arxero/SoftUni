using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Test_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int M = int.Parse(Console.ReadLine());
            int max = int.Parse(Console.ReadLine());

            double calculation = 0;
            double calculationSum = 0;
            int counter = 0;

            for (int i = N; i >= 1; i--)
            {
                for (int j = 1; j <= M; j++)
                {
                    calculation = 3 * (i * j);
                    calculationSum += calculation;
                    counter++;
                    if (calculationSum >= max)
                    {
                        break;
                    }
                }
                if (calculationSum >= max)
                {
                    break;
                }
            }
            if (calculationSum >= max)
            {
                Console.WriteLine($"{counter} combinations");
                Console.WriteLine($"Sum: {calculationSum} >= {max}");
            }
            else if (calculationSum < max)
            {
                Console.WriteLine($"{counter} combinations");
                Console.WriteLine($"Sum: {calculationSum}");
            }
        }
    }
}
