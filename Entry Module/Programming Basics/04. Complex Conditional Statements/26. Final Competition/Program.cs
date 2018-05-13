using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26.Final_Competition
{
    class Program
    {
        static void Main(string[] args)
        {
            int dancers = int.Parse(Console.ReadLine());
            double points = double.Parse(Console.ReadLine());
            string season = Console.ReadLine().ToLower();
            string place = Console.ReadLine().ToLower();

            double money = 0;
            double VAT = 0;

            switch (season)
            {
                case "summer":
                    if (place == "bulgaria")
                    {
                        money = points * dancers;
                        VAT = money - (money * 0.05);

                    }
                    else if (place == "abroad")
                    {
                        money = (points * dancers) + (points * dancers)* 0.5;
                        VAT = money - (money * 0.1);
                    }
                    break;

                case "winter":
                    if (place == "bulgaria")
                    {
                        money = points * dancers;
                        VAT = money - (money * 0.08);

                    }
                    else if (place == "abroad")
                    {
                        money = (points * dancers) + (points * dancers) * 0.5;
                        VAT = money - (money * 0.15);
                    }
                    break;
            }
            double charity = VAT * 0.75;
            double moneyPerDancer = (VAT - charity) / dancers;
            Console.WriteLine($"Charity - {charity:f2}");
            Console.WriteLine($"Money per dancer - {moneyPerDancer:f2}");

        }
    }
}
