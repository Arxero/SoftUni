using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Puteshestvie
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine()); // 6:35
            string season = Console.ReadLine().ToLower();

            double price = 0;
            string destination = "";
            string place = "";

            switch (season)
            {
                case "winter":
                    if (budget <= 100)
                    {
                        price = budget * 0.70;
                        destination = "Bulgaria";
                        place = "Hotel";
                    }
                    else if (budget <= 1000)
                    {
                        price = budget * 0.80;
                        destination = "Balkans";
                        place = "Hotel";
                    }
                    else if (budget > 1000)
                    {
                        price = budget * 0.90;
                        destination = "Europe";
                        place = "Hotel";
                    }
                    break;

                case "summer":
                    if (budget <= 100)
                    {
                        price = budget * 0.30;
                        destination = "Bulgaria";
                        place = "Camp";
                    }
                    else if (budget <= 1000)
                    {
                        price = budget * 0.40;
                        destination = "Balkans";
                        place = "Camp";
                    }
                    else if (budget > 1000)
                    {
                        price = budget * 0.90;
                        destination = "Europe";
                        place = "Hotel";
                    }
                    break;

            }
            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{place} - {price:f2}");


        }
    }
}
