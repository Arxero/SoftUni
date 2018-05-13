using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25.Cups
{
    class Program
    {
        static void Main(string[] args)
        {
            int cups = int.Parse(Console.ReadLine());
            int workers = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());

            int cupTime = 5;
            int workDay = 8;
            double price = 4.20;

            double makingTime = workers * days * workDay;
            double producedCups = Math.Floor(makingTime / cupTime);
            double lessCups = cups - producedCups;


            if (cups >= producedCups)
            {

                double losses = lessCups * price;
                Console.WriteLine($"Losses: {losses:f2}");
            }
            else
            {
                double moreCups = producedCups - cups;
                double extra = moreCups * price;
                Console.WriteLine($"{extra:f2} extra money");
            }
        }
    }
}
