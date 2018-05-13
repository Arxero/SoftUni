using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Currency_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            string from = Console.ReadLine();
            string to = Console.ReadLine();
            double USD = 1.79549;
            double EUR = 1.95583;
            double GBP = 2.53405;

            if (from == "BGN")
            {
                if (to == "USD")
                {
                    Console.Write("{0}", Math.Round(number / USD, 2));
                }
                if (to == "EUR")
                {
                    Console.Write("{0}", Math.Round(number / EUR, 2));
                }
                if (to == "GBP")
                {
                    Console.Write("{0}", Math.Round(number / GBP, 2));
                }
            }
            if (from == "USD")
            {
                if (to == "BGN")
                {
                    Console.Write("{0}", Math.Round(number * USD, 2));
                }
                if (to == "EUR")
                {
                    Console.Write("{0}", Math.Round(number * USD / EUR, 2));
                }
                if (to == "GBP")
                {
                    Console.Write("{0}", Math.Round(number * USD / GBP, 2));
                }
            }
            if (from == "EUR")
            {
                if (to == "BGN")
                {
                    Console.Write("{0}", Math.Round(number * EUR, 2));
                }
                if (to == "USD")
                {
                    Console.Write("{0}", Math.Round(number * EUR / USD, 2));
                }
                if (to == "GBP")
                {
                    Console.Write("{0}", Math.Round(number * EUR / GBP, 2));
                }
            }
            if (from == "GBP")
            {
                if (to == "BGN")
                {
                    Console.Write("{0}", Math.Round(number * GBP, 2));
                }
                if (to == "USD")
                {
                    Console.Write("{0}", Math.Round(number * GBP / USD, 2));
                }
                if (to == "EUR")
                {
                    Console.Write("{0}", Math.Round(number * GBP / EUR, 2));
                }
            }
            Console.WriteLine(" {0}", to);

        }
    }
}