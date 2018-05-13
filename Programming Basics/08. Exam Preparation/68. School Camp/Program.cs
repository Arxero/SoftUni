using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _68.School_Camp
{
    class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine();
            string group = Console.ReadLine();
            int students = int.Parse(Console.ReadLine());
            int overnights = int.Parse(Console.ReadLine());

            double price = 0;
            string sport = "";

            switch (season)
            {
                case "Winter":
                    if (group == "boys")
                    {
                        price = 9.60;
                        sport = "Judo";
                    }
                    else if (group == "girls")
                    {
                        price = 9.60;
                        sport = "Gymnastics";

                    }
                    else if (group == "mixed")
                    {
                        price = 10;
                        sport = "Ski";
                    }
                    break;
                case "Spring":
                    if (group == "boys")
                    {
                        sport = "Tennis";
                        price = 7.20;
                    }
                    else if (group == "girls")
                    {
                        sport = "Athletics";
                        price = 7.20;

                    }
                    else if (group == "mixed")
                    {
                        sport = "Cycling";
                        price = 9.50;
                    }
                    break;
                case "Summer":
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
            }
            double total = students * price * overnights;
            if (students >= 50)
            {
                total = total - (total * 0.50);
            }
            else if (students >= 20 && students < 50)
            {
                total = total - (total * 0.15);
            }
            else if (students >= 10 && students < 20)
            {
                total = total - (total * 0.05);
            }
            Console.WriteLine($"{sport} {total:f2} lv.");



        }
    }
}
