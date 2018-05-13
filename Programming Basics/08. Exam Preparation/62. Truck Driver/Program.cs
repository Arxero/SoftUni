using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _62.Truck_Driver
{
    class Program
    {
        static void Main(string[] args)
        { 
            string season = Console.ReadLine(); // 11:28
            double kilometers = double.Parse(Console.ReadLine());

            double salary = 0;

            switch (season)
            {
                case "Spring":
                    if (kilometers <= 5000)
                    {
                        salary = 0.75;
                    }
                    else if (kilometers > 5000 && kilometers <= 10000)
                    {
                        salary = 0.95;
                    }
                    else if (kilometers > 10000 && kilometers <= 20000)
                    {
                        salary = 1.45;
                    }
                    break;
                case "Autumn":
                    if (kilometers <= 5000)
                    {
                        salary = 0.75;
                    }
                    else if (kilometers > 5000 && kilometers <= 10000)
                    {
                        salary = 0.95;
                    }
                    else if (kilometers > 10000 && kilometers <= 20000)
                    {
                        salary = 1.45;
                    }
                    break;
                case "Summer":
                    if (kilometers <= 5000)
                    {
                        salary = 0.90;
                    }
                    else if (kilometers > 5000 && kilometers <= 10000)
                    {
                        salary = 1.10;
                    }
                    else if (kilometers > 10000 && kilometers <= 20000)
                    {
                        salary = 1.45;
                    }
                    break;
                case "Winter":
                    if (kilometers <= 5000)
                    {
                        salary = 1.05;
                    }
                    else if (kilometers > 5000 && kilometers <= 10000)
                    {
                        salary = 1.25;
                    }
                    else if (kilometers > 10000 && kilometers <= 20000)
                    {
                        salary = 1.45;
                    }
                    break;
            }
            double calculatesSlary = (kilometers * salary * 4) - ((kilometers * salary * 4) * 0.10);
            Console.WriteLine($"{calculatesSlary:f2}");
        }
    }
}
