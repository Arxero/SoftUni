using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21.Flowers
{
    class Program
    {
        static void Main(string[] args)
        {
            int chrysanthemums = int.Parse(Console.ReadLine());
            int roses = int.Parse(Console.ReadLine());
            int tilips = int.Parse(Console.ReadLine());
            string season = Console.ReadLine().ToLower();
            string memorial = Console.ReadLine().ToLower();

            double bouquetPrice = 2.0;
            double chrysanthemumsPrice = 0;
            double rosesPrice = 0;
            double tilipsPrice = 0;

            switch (season)
            {
                case "spring":
                    chrysanthemumsPrice = 2.0;
                    rosesPrice = 4.10;
                    tilipsPrice = 2.50;
                    break;
                case "summer":
                    chrysanthemumsPrice = 2.0;
                    rosesPrice = 4.10;
                    tilipsPrice = 2.50;
                    break;
                case "autumn":
                    chrysanthemumsPrice = 3.75;
                    rosesPrice = 4.50;
                    tilipsPrice = 4.15;
                    break;
                case "winter":
                    chrysanthemumsPrice = 3.75;
                    rosesPrice = 4.50;
                    tilipsPrice = 4.15;
                    break;
            }
            double calculations = (chrysanthemums * chrysanthemumsPrice) + (roses * rosesPrice) + (tilips * tilipsPrice);

            double addedPercentageMemorial = 0;
            double substractedPercentageTilips = 0;
            double substractedPercentageRoses = 0;
            double totalDiscount = 0;
            int summedFlowers = chrysanthemums + roses + tilips;

            if (memorial == "y")
            {
                addedPercentageMemorial = calculations * 0.15;
                calculations += addedPercentageMemorial;
            }

            switch (season)
            {
                case "spring":
                    if (tilips > 7)
                    {
                        substractedPercentageTilips = calculations * 0.05;
                        calculations -= substractedPercentageTilips;
                    }
                    break;
                case "winter":
                    if (roses >= 10)
                    {
                        substractedPercentageRoses = calculations * 0.1;
                        calculations -= substractedPercentageRoses;
                    }
                    break;
            }
            if (summedFlowers > 20)
            {
                totalDiscount = calculations * 0.20;
                calculations -= totalDiscount;
            }
            calculations += bouquetPrice;
            Console.WriteLine($"{calculations:f2}");
        }
    }
}
