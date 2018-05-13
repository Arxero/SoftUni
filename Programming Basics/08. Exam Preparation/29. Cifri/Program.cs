using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29.Cifri
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); // 12:44

            double digit = n / 100;
            double digit2 = (n / 10) % 10;
            double digit3 = n % 10;
            double calculation = 0;
            double newCalculation = 0;
            for (int row = 0; row < digit + digit2; row++)
            {
                for (int col = 0; col < digit + digit3; col++)
                {
                    
                    if (n % 5 == 0)
                    {
                        calculation = n - digit;
                    }
                    else if (n % 3 == 0)
                    {
                        calculation = n - digit2;
                    }
                    else
                    {
                        calculation = n + digit3;
                    }
                    n = (int)calculation;

                    Console.Write($"{calculation} ");
                }
                Console.WriteLine();
            }

        }
    }
}
