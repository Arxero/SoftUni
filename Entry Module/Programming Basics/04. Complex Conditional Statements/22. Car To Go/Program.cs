using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22.Car_To_Go
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine().ToLower();

            string carClass = "";
            string carType = "";
            double price = 0;

            if (budget <= 100)
            {
                carClass = "Economy class";
                switch (season)
                {
                    case "summer":
                        price = budget * 0.35;
                        carType = "Cabrio";
                        break;
                    case "winter":
                        price = budget * 0.65;
                        carType = "Jeep";
                        break;
                }

            }
            else if (budget <= 500)
            {
                carClass = "Compact class";
                switch (season)
                {
                    case "summer":
                        price = budget * 0.45;
                        carType = "Cabrio";
                        break;
                    case "winter":
                        price = budget * 0.80;
                        carType = "Jeep";
                        break;
                }
            }
            else if (budget > 500)
            {
                carClass = "Luxury class";
                switch (season)
                {
                    default:
                    price = budget * 0.90;
                        carType = "Jeep";
                        break;
                }
            }
            Console.WriteLine(carClass);
            Console.WriteLine($"{carType} - {price:f2}");
        }
    }
}
