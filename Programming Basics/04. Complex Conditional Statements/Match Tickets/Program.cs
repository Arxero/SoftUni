using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Match_Tickets
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string category = Console.ReadLine().ToLower();
            int people = int.Parse(Console.ReadLine());

            double transport = 0.0;
            double normalTicket = 249.99;
            double vipTicket = 499.99;
            double ticketPrice = 0.0;
            double final = 0.0;
            double finalPrice = 0.0;
            double wholePrice = transport + ticketPrice;

            if (category == "normal") //NORMAL
            {

                if (people >= 1 && people <= 4)
                {
                    transport = budget * 0.75; //750
                    ticketPrice = people * normalTicket; //249
                    wholePrice = transport + ticketPrice; //750 + 249


                    if (budget > wholePrice)
                    {
                        final = budget - wholePrice;
                        Console.WriteLine($"Yes! You have {final:f2} leva left.");
                    }
                    else
                    {
                        final = wholePrice - budget;
                        Console.WriteLine($"Not enough money! You need {final:f2} leva.");
                    }
                    
                }
                else if (people >= 5 && people <= 9)
                {
                    transport = budget * 0.60;
                    ticketPrice = people * normalTicket;
                    wholePrice = transport + ticketPrice;

                    if (budget > wholePrice)
                    {
                        final = budget - wholePrice;
                        Console.WriteLine($"Yes! You have {final:f2} leva left.");
                    }
                    else
                    {
                        final = wholePrice - budget;
                        Console.WriteLine($"Not enough money! You need {final:f2} leva.");
                    }
                }
                else if (people >= 10 && people <= 24)
                {
                    transport = budget * 0.50;
                    ticketPrice = people * normalTicket;
                    wholePrice = transport + ticketPrice;

                    if (budget > wholePrice)
                    {
                        final = budget - wholePrice;
                        Console.WriteLine($"Yes! You have {final:f2} leva left.");
                    }
                    else
                    {
                        final = wholePrice - budget;
                        Console.WriteLine($"Not enough money! You need {final:f2} leva.");
                    }
                }
                else if (people >= 25 && people <= 49)
                {
                    transport = budget * 0.40;
                    ticketPrice = people * normalTicket;
                    wholePrice = transport + ticketPrice;

                    if (budget > wholePrice)
                    {
                        final = budget - wholePrice;
                        Console.WriteLine($"Yes! You have {final:f2} leva left.");
                    }
                    else
                    {
                        final = wholePrice - budget;
                        Console.WriteLine($"Not enough money! You need {final:f2} leva.");
                    }
                }
                else if (people >= 50)
                {
                    transport = budget * 0.25;
                    ticketPrice = people * normalTicket;
                    wholePrice = transport + ticketPrice;

                    if (budget > wholePrice)
                    {
                        final = budget - wholePrice;
                        Console.WriteLine($"Yes! You have {final:f2} leva left.");
                    }
                    else
                    {
                        final = wholePrice - budget;
                        Console.WriteLine($"Not enough money! You need {final:f2} leva.");
                    }
                }
            }
            ////////////////////////////////////////////////////////////////////
            if (category == "vip") //VIP
            {

                if (people >= 1 && people <= 4)
                {
                    transport = budget * 0.75;
                    ticketPrice = people * vipTicket;
                    wholePrice = transport + ticketPrice;

                    if (budget > wholePrice)
                    {
                        final = budget - wholePrice;
                        Console.WriteLine($"Yes! You have {final:f2} leva left.");
                    }
                    else
                    {
                        final = wholePrice - budget;
                        Console.WriteLine($"Not enough money! You need {final:f2} leva.");
                    }

                }
                else if (people >= 5 && people <= 9)
                {
                    transport = budget * 0.60;
                    ticketPrice = people * vipTicket;
                    wholePrice = transport + ticketPrice;

                    if (budget > wholePrice)
                    {
                        final = budget - wholePrice;
                        Console.WriteLine($"Yes! You have {final:f2} leva left.");
                    }
                    else
                    {
                        final = wholePrice - budget;
                        Console.WriteLine($"Not enough money! You need {final:f2} leva.");
                    }
                }
                else if (people >= 10 && people <= 24)
                {
                    transport = budget * 0.50;
                    ticketPrice = people * vipTicket;
                    wholePrice = transport + ticketPrice;

                    if (budget > wholePrice)
                    {
                        final = budget - wholePrice;
                        Console.WriteLine($"Yes! You have {final:f2} leva left.");
                    }
                    else
                    {
                        final = wholePrice - budget;
                        Console.WriteLine($"Not enough money! You need {final:f2} leva.");
                    }
                }
                else if (people >= 25 && people <= 49)
                {
                    transport = budget * 0.40;
                    ticketPrice = people * vipTicket;
                    wholePrice = transport + ticketPrice;

                    if (budget > wholePrice)
                    {
                        final = budget - wholePrice;
                        Console.WriteLine($"Yes! You have {final:f2} leva left.");
                    }
                    else
                    {
                        final = wholePrice - budget;
                        Console.WriteLine($"Not enough money! You need {final:f2} leva.");
                    }
                }
                else if (people >= 50)
                {
                    transport = budget * 0.25;
                    ticketPrice = people * vipTicket;
                    wholePrice = transport + ticketPrice;

                    if (budget > wholePrice)
                    {
                        final = budget - wholePrice;
                        Console.WriteLine($"Yes! You have {final:f2} leva left.");
                    }
                    else
                    {
                        final = wholePrice - budget;
                        Console.WriteLine($"Not enough money! You need {final:f2} leva.");
                    }
                }
            }
        }
    }
}