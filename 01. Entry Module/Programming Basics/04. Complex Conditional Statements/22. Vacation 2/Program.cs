using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22.Vacation_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine().ToLower();

            string place = "";
            string location = "";
            double price = 0;

            if (budget <= 1000)
            {
                place = "Camp";
                switch (season)
                {
                    case "summer":
                        location = "Alaska";
                        price = budget * 0.65;
                        break;
                    case "winter":
                        location = "Morocco";
                        price = budget * 0.45;
                        break;
                }
            }
            else if (budget > 1000 && budget <= 3000)
            {
                place = "Hut";
                switch (season)
                {
                    case "summer":
                        location = "Alaska";
                        price = budget * 0.80;
                        break;
                    case "winter":
                        location = "Morocco";
                        price = budget * 0.60;
                        break;

                }
            }
            else if (budget > 3000)
            {
                place = "Hotel";
                switch (season)
                {
                    case "summer":
                        location = "Alaska";
                        price = budget * 0.90;
                        break;
                    case "winter":
                        location = "Morocco";
                        price = budget * 0.90;
                        break;
                }
            }
            Console.WriteLine($"{location} - {place} - {price:f2}");
        }
    }
}
