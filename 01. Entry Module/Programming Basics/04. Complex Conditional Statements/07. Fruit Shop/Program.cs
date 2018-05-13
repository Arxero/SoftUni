using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Fruit_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruit = (Console.ReadLine()).ToLower();
            string day = (Console.ReadLine()).ToLower();
            double quantity = double.Parse(Console.ReadLine());

            double price = -1;
            bool workdays = day == "monday" ||
                day == "tuesday" ||
                day == "wednesday" ||
                day == "thursday" ||
                day == "friday";
            bool weekend = day == "saturday" || day == "sunday";
            if (workdays)
            {
                if (fruit == "banana")
                { price = 2.5; }
                if (fruit == "apple")
                { price = 1.2; }
                if (fruit == "orange")
                { price = 0.85; }
                if (fruit == "grapefruit")
                { price = 1.45; }
                if (fruit == "kiwi")
                { price = 2.70; }
                if (fruit == "pineapple")
                { price = 5.50; }
                if (fruit == "grapes")
                { price = 3.85; }
            }
            if (weekend)
            {
                if (fruit == "banana")
                { price = 2.7; }
                if (fruit == "apple")
                { price = 1.25; }
                if (fruit == "orange")
                { price = 0.90; }
                if (fruit == "grapefruit")
                { price = 1.60; }
                if (fruit == "kiwi")
                { price = 3.0; }
                if (fruit == "pineapple")
                { price = 5.60; }
                if (fruit == "grapes")
                { price = 4.20; }
            }
            if (price >= 0)
            {
                double calculation = quantity * price;
                Console.WriteLine($"{calculation:f2}");
            }
            else
            {
                Console.WriteLine("error");
            }
            

        }
    }
}
