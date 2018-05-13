using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _56.Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine()); // 9:05
            string season = Console.ReadLine();

            double price = 0;
            string place = "";
            string destination = "";

            switch (season)
            {
                case "Summer":
                    if (budget <= 1000)
                    {
                        price = budget * 0.65;
                        place = "Camp";
                        destination = "Alaska";
                    }
                    else if (budget > 1000 && budget <= 3000)
                    {
                        price = budget * 0.80;
                        place = "Hut";
                        destination = "Alaska";
                    }
                    else if (budget > 3000)
                    {
                        price = budget * 0.90;
                        place = "Hotel";
                        destination = "Alaska";
                    }
                    break;
                case "Winter":
                    if (budget <= 1000)
                    {
                        price = budget * 0.45;
                        place = "Camp";
                        destination = "Morocco";
                    }
                    else if (budget > 1000 && budget <= 3000)
                    {
                        price = budget * 0.60;
                        place = "Hut";
                        destination = "Morocco";
                    }
                    else if (budget > 3000)
                    {
                        price = budget * 0.90;
                        place = "Hotel";
                        destination = "Morocco";
                    }
                    break;
            }
            Console.WriteLine($"{destination} - {place} - {price:f2}");
        }
    }
}
