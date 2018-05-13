using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24.School_Camp
{
    class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine().ToLower();
            string group = Console.ReadLine().ToLower();
            int students = int.Parse(Console.ReadLine());
            int nights = int.Parse(Console.ReadLine());

            double price = 0;
            string sport = "";

            switch (season)
            {
                case "summer":
                    if (group == "boys")
                    {
                        sport = "Football";
                        price = 15;
                    }
                    else if (group == "girls")
                    {
                        sport = "Volleyball";
                        price = 15;
                    }
                    else if (group == "mixed")
                    {
                        sport = "Swimming";
                        price = 20;
                    }
                    break;
                case "spring":
                    if (group == "boys")
                    {
                        sport = "Tennis";
                        price = 7.2;
                    }
                    else if (group == "girls")
                    {
                        sport = "Athletics";
                        price = 7.2;
                    }
                    else if (group == "mixed")
                    {
                        sport = "Cycling";
                        price = 9.5;
                    }
                    break;
                case "winter":
                    if (group == "boys")
                    {
                        sport = "Judo";
                        price = 9.6;
                    }
                    else if (group == "girls")
                    {
                        sport = "Gymnastics";
                        price = 9.6;
                    }
                    else if (group == "mixed")
                    {
                        sport = "Ski";
                        price = 10;
                    }
                    break;
            }
            double calculations = students * nights * price;
            double discount = 0;
            if (students >= 10 && students < 20)
            {
                discount = calculations * 0.05;
                calculations -= discount;
            }
            else if (students >=20 && students < 50)
            {
                discount = calculations * 0.15;
                calculations -= discount;
            }
            else if (students >= 50)
            {
                discount = calculations * 0.50;
                calculations -= discount;
            }

            Console.WriteLine($"{sport} {calculations:f2} lv.");
        }
    }
}
