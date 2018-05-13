using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20.Bike_Race
{
    class Program
    {
        static void Main(string[] args)
        {
            int juniors = int.Parse(Console.ReadLine());
            int seniors = int.Parse(Console.ReadLine());
            string race = Console.ReadLine().ToLower();

            double priceJuniors = 0;
            double priceSeniors = 0;

            switch (race)
            {
                case "road":
                    priceJuniors = 20;
                    priceSeniors = 21.50;
                    break;
                case "downhill":
                    priceJuniors = 12.25;
                    priceSeniors = 13.75;
                    break;
                case "cross-country":
                    priceJuniors = 8;
                    priceSeniors = 9.5;
                    int participants = juniors + seniors;
                    if (participants >= 50)
                    {
                        priceJuniors -= priceJuniors * 0.25;
                        priceSeniors -= priceSeniors * 0.25;
                    }
                    break;
                case "trail":
                    priceJuniors = 5.5;
                    priceSeniors = 7;
                    break;
            }
            double donation = (juniors * priceJuniors) + (seniors * priceSeniors);
            double costs = donation * 0.05;
            double total = donation - costs;
            Console.WriteLine($"{total:f2}");
        }
    }
}
