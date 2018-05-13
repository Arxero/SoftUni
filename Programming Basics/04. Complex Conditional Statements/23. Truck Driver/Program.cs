using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23.Truck_Driver
{
    class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine().ToLower();
            double kilometeres = double.Parse(Console.ReadLine());

            double salary = 0;

            if (kilometeres <= 5000)
            {
                switch (season)
                {
                    case "summer":
                        salary = 0.90;
                        break;
                    case "winter":
                        salary = 1.05;
                        break;
                    default:
                        salary = 0.75;
                        break;
                }
            }
            else if (kilometeres <= 10000)
            {
                switch (season)
                {
                    case "summer":
                        salary = 1.1;
                        break;
                    case "winter":
                        salary = 1.25;
                        break;
                    default:
                        salary = 0.95;
                        break;
                }

            }
            else if (kilometeres <= 20000)
            {
                switch (season)
                {
                    default:
                        salary = 1.45;
                        break;
                }

            }
            double calculations = (kilometeres * salary * 4);
            double VAT = calculations - (calculations * 0.1);
            Console.WriteLine($"{VAT:f2}");
        }
    }
}
