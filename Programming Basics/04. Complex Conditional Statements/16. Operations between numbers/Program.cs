using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.Operations_between_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double N1 = double.Parse(Console.ReadLine());
            double N2 = double.Parse(Console.ReadLine());
            string symbol = Console.ReadLine();

            double answer = 0.0;

            if (symbol == "+")
            {
                answer = N1 + N2;

                if (answer % 2 == 0)
                {
                    Console.WriteLine($"{N1} + {N2} = {answer} - even");
                }
                else
                {
                    Console.WriteLine($"{N1} + {N2} = {answer} - odd");
                }
             }
            else if (symbol == "-")
            {
                answer = N1 - N2;

               if (answer % 2 == 0)
                {
                    Console.WriteLine($"{N1} - {N2} = {answer} - even");
                }
                else
                {
                    Console.WriteLine($"{N1} - {N2} = {answer} - odd");
                }
            }
            else if (symbol == "*")
            {
                answer = N1 * N2;

                if (answer % 2 == 0)
                {
                    Console.WriteLine($"{N1} * {N2} = {answer} - even");
                }
                else
                {
                    Console.WriteLine($"{N1} * {N2} = {answer} - odd");
                }
            }
            else if (symbol == "/")
            {
                if (N2 !=0)
                {
                    answer = N1 / N2;
                    Console.WriteLine($"{N1} / {N2} = {answer:f2}");
                }
                else if (N2 == 0)
                {
                    Console.WriteLine($"Cannot divide {N1} by zero");
                }
                
            }
            else if (symbol == "%")
            {
                if (N2 !=0)
                {
                    answer = N1 % N2;
                    Console.WriteLine($"{N1} % {N2} = {answer}");
                }
                else if (N2 == 0)
                {
                    Console.WriteLine($"Cannot divide {N1} by zero");
                }
                
            }
  
        }
    }
}
