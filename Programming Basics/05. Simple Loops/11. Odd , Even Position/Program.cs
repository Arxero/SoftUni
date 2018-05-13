using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Odd___Even_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            double cycles = double.Parse(Console.ReadLine());

            double oddMin = 1000000000.0;
            double evenMin = 1000000000.0;
            double oddSum = 0;
            double evenSum = 0;
            double oddMax = -1000000000.0;
            double evenMax = -1000000000.0;

            for (double i = 0; i < cycles; i++)
            {
                double number = double.Parse(Console.ReadLine());

                if (i % 2 == 0)
                {
                    // odd numbers
                    oddSum += number;
                    if (oddMin > number && number)
                    {
                        oddMin = number;
                    }
                    if (oddMax < number)
                    {
                        oddMax = number;
                    }


                }
                else
                {
                    // even numbers

                    evenSum += number;
                    if (evenMin > number)
                    {
                        evenMin = number;
                    }
                    if (evenMax < number)
                    {
                        evenMax = number;
                    }
                }
            }
            Console.WriteLine($"OddSum = {oddSum}");
            Console.WriteLine($"OddMin = {oddMin}");
            Console.WriteLine($"OddMax = {oddMax}");
            Console.WriteLine($"EvenSum = {evenSum}");
            Console.WriteLine($"EvenMin = {evenMin}");
            Console.WriteLine($"EvenMax = {evenMax}");
        }
    }
}
