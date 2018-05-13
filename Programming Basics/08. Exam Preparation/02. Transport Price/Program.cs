using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Transport_Price
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); // 4:25
            string timeOfDay = Console.ReadLine().ToLower();

            double price = 0;

            if (n < 20 && timeOfDay == "day")
            {
                price = 0.79;
                double taxi = price * n + 0.70;
                Console.WriteLine($"{taxi:f2}");


            }
            else if (n < 20 && timeOfDay == "night")
            {
                price = 0.90;
                double taxi = price * n + 0.70;
                Console.WriteLine($"{taxi:f2}");
            }

            else if (n >= 20 && n < 100)
            {
                price = 0.09;
                double buss = price * n;
                Console.WriteLine($"{buss:f2}");
            }

            else if (n >= 100)
            {
                price = 0.06;
                double train = price * n;
                Console.WriteLine($"{train:f2}");
            }
        }
    }
}
