using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _50.Car_To_Go
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine()); // 10:43
            string season = Console.ReadLine();

            double car = 0;
            string carType = "";
            string clas = "";

            switch (season)
            {
                case "Summer":
                    if (budget <= 100)
                    {
                        clas = "Economy class";
                        carType = "Cabrio";
                        car = budget * 0.35;
                    }
                    else if (budget > 100 && budget <= 500)
                    {
                        clas = "Compact class";
                        carType = "Cabrio";
                        car = budget * 0.45;
                    }
                    else if (budget > 500)
                    {
                        clas = "Luxury class";
                        carType = "Jeep";
                        car = budget * 0.90;
                    }
                    break;
                case "Winter":
                    if (budget <= 100)
                    {
                        clas = "Economy class";
                        carType = "Jeep";
                        car = budget * 0.65;
                    }
                    else if (budget > 100 && budget <= 500)
                    {
                        clas = "Compact class";
                        carType = "Jeep";
                        car = budget * 0.80;
                    }
                    else if (budget > 500)
                    {
                        clas = "Luxury class";
                        carType = "Jeep";
                        car = budget * 0.90;
                    }
                    break;
            }
            //double calculation = 
            Console.WriteLine(clas);
            Console.WriteLine($"{carType} - {car:f2}");
        }
    }
}
