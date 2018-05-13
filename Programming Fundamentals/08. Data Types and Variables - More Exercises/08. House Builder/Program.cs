using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.House_Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());

            int sbytePrices = 0;
            long intPrices = 0;

            if (first <= sbyte.MaxValue)
            {
                sbytePrices = first;
            }
            else
            {
                intPrices = first;
            }
            if (second <= sbyte.MaxValue)
            {
                sbytePrices = second;
            }
            else
            {
                intPrices = second;
            }
            sbytePrices *= 4;
            intPrices *= 10;

            long total = sbytePrices + intPrices;
            Console.WriteLine(total);
        }
    }
}
