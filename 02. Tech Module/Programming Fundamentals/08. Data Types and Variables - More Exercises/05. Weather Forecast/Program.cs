using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Weather_Forecast
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                long n = long.Parse(Console.ReadLine());

                if (n >= sbyte.MinValue && n <= sbyte.MaxValue)
                {
                    Console.WriteLine("Sunny");
                }
                else if (n >= int.MinValue && n <= int.MaxValue)
                {
                    Console.WriteLine("Cloudy");
                }
                else if (n >= long.MinValue && n <= long.MaxValue)
                {
                    Console.WriteLine("Windy");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Rainy");
            }

        }
    }
}
