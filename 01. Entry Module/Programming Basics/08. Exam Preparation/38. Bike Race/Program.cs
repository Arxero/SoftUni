using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _38.Bike_Race
{
    class Program
    {
        static void Main(string[] args)
        {
            int juniors = int.Parse(Console.ReadLine()); // 10:13
            int seniors = int.Parse(Console.ReadLine());
            string raceTrack = Console.ReadLine();

            double moneyJuniours = 0;
            double moneySeniours = 0;

            switch (raceTrack)
            {
                case "trail":
                    moneyJuniours = 5.50;
                    moneySeniours = 7;
                    break;
                case "cross-country":
                    if (juniors + seniors >= 50)
                    {
                        moneyJuniours = 8 * 0.75;
                        moneySeniours = 9.50 * 0.75;
                    }
                    else
                    {
                        moneyJuniours = 8;
                        moneySeniours = 9.50;
                    }
                    break;
                case "downhill":
                    moneyJuniours = 12.25;
                    moneySeniours = 13.75;
                    break;
                case "road":
                    moneyJuniours = 20;
                    moneySeniours = 21.50;
                    break;
            }
            double calculation = (juniors * moneyJuniours + seniors * moneySeniours) * 0.95;
            Console.WriteLine($"{calculation:f2}");
        }
    }
}
