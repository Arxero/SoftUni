using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Operacii_mejdu_chisla
{
    class Program
    {
        static void Main(string[] args)
        {
            double N1 = double.Parse(Console.ReadLine()); //5:44
            double N2 = double.Parse(Console.ReadLine());
            char symbol = char.Parse(Console.ReadLine());

            string evenOrodd = "";
            double result = 0.0;

            switch (symbol)
            {
                case '+':
                    result = N1 + N2;
                    if (result % 2 == 0)
                    {
                        evenOrodd = "even";
                    }
                    else
                    {
                        evenOrodd = "odd";
                    }
                    Console.WriteLine($"{N1} {symbol} {N2} = {result} - {evenOrodd}");

                    break;
                case '-':
                    result = N1 - N2;
                    if (result % 2 == 0)
                    {
                        evenOrodd = "even";
                    }
                    else
                    {
                        evenOrodd = "odd";
                    }
                    Console.WriteLine($"{N1} {symbol} {N2} = {result} - {evenOrodd}");
                    break;
                case '*':
                    result = N1 * N2;
                    if (result % 2 == 0)
                    {
                        evenOrodd = "even";
                    }
                    else
                    {
                        evenOrodd = "odd";
                    }
                    Console.WriteLine($"{N1} {symbol} {N2} = {result} - {evenOrodd}");
                    break;
                case '/':
                    
                    if (N2 != 0)
                    {
                        result = N1 / N2;
                        Console.WriteLine($"{N1} {symbol} {N2} = {result:f2}");
                    }
                    else if (N2 == 0)
                    {
                        Console.WriteLine($"Cannot divide {N1} by zero");
                    }
                    break;
                case '%':
                    
                    if (N2 !=0)
                    {
                        result = N1 % N2;
                        Console.WriteLine($"{N1} {symbol} {N2} = {result}");
                    }
                    else if (N2 == 0)
                    {
                        Console.WriteLine($"Cannot divide {N1} by zero");
                    }
                    break;
            }

        }
    }
}
