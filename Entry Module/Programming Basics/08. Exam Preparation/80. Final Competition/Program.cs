using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _80.Final_Competition
{
    class Program
    {
        static void Main(string[] args)
        {
            int dancers = int.Parse(Console.ReadLine()); // 9:23
            double points = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string place = Console.ReadLine();

            double prize = 0;

            switch (season)
            {
                case "summer":
                    if (place == "Bulgaria")
                    {
                        prize = (points * dancers) - ((points * dancers) * 0.05);
                    }
                    else if (place == "Abroad")
                    {
                        prize = (points * dancers) + ((points * dancers) * 0.50) - (((points * dancers) + ((points * dancers) * 0.50)) * 0.10);
                    }
                    break;
                case "winter":
                    if (place == "Bulgaria")
                    {
                        prize = (points * dancers) - ((points * dancers) * 0.08);
                    }
                    else if (place == "Abroad")
                    {
                        prize = (points * dancers) + ((points * dancers) * 0.50) - (((points * dancers) + ((points * dancers) * 0.50)) * 0.15);
                    }
                    break;
            }
            double charity = prize * 0.75;
            double leftMoney = prize - charity;
            double moneyDancer = leftMoney / dancers;
            Console.WriteLine($"Charity - {charity:f2}");
            Console.WriteLine($"Money per dancer - {moneyDancer:f2}");

        }
    }
}
