using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _61.Styrofoam
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            double house = double.Parse(Console.ReadLine());
            double windows = double.Parse(Console.ReadLine());
            double styrofoam = double.Parse(Console.ReadLine());
            double price = double.Parse(Console.ReadLine());

            double houseArea = house - (windows * 2.4);
            double waste = (houseArea * 0.10) + houseArea;
            double neededStyrofoam = Math.Ceiling(waste / styrofoam);
            double cost = neededStyrofoam * price;
            double isItEnough = budget - cost;
            if (budget > cost)
            {
                Console.WriteLine($"Spent: {cost:f2}");
                Console.WriteLine($"Left: {isItEnough:f2}");
            }
            else
            {
                Console.WriteLine($"Need more: {Math.Abs(isItEnough):f2}");
            }
        }
    }
}
