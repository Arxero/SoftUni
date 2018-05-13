using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21.Match_Tickets
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine()); // 4:57
            string category = Console.ReadLine();
            int people = int.Parse(Console.ReadLine());

            double ticketPrice = 0;
            double trasnportPrice = 0;

            switch (category)
            {
                case "VIP":
                    ticketPrice = 499.99;
                    if (people <= 4)
                    {
                        trasnportPrice = budget * 0.25;
                    }
                    else if (people >= 5 && people <= 9)
                    {
                        trasnportPrice = budget * 0.40;
                    }
                    else if (people >= 10 && people <= 24)
                    {
                        trasnportPrice = budget * 0.50;
                    }
                    else if (people >= 25 && people <= 49)
                    {
                        trasnportPrice = budget * 0.60;
                    }
                    else if (people >= 50)
                    {
                        trasnportPrice = budget * 0.75;
                    }
                    break;
                case "Normal":
                    ticketPrice = 249.99;
                    if (people <= 4)
                    {
                        trasnportPrice = budget * 0.25;
                    }
                    else if (people >= 5 && people <= 9)
                    {
                        trasnportPrice = budget * 0.40;
                    }
                    else if (people >= 10 && people <= 24)
                    {
                        trasnportPrice = budget * 0.50;
                    }
                    else if (people >= 25 && people <= 49)
                    {
                        trasnportPrice = budget * 0.60;
                    }
                    else if (people >= 50)
                    {
                        trasnportPrice = budget * 0.75;
                    }
                    break;
            }
            double calculation = ticketPrice * people;
            double howLeft = trasnportPrice - calculation;
            if (calculation <= trasnportPrice)
            {
                Console.WriteLine($"Yes! You have {howLeft:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {Math.Abs(howLeft):f2} leva.");
            }
        }
    }
}
