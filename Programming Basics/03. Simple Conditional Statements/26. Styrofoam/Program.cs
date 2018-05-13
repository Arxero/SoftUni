using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26.Styrofoam
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            double area = double.Parse(Console.ReadLine());
            double windows = double.Parse(Console.ReadLine());
            double styrofoam = double.Parse(Console.ReadLine());
            double price = double.Parse(Console.ReadLine());

            double windowArea = 2.4;

            double windowsArea = windows * windowArea;
            double houseArea = area - windowsArea;
            double percentages = houseArea * 0.1;
            double addedPercentages = houseArea + percentages;
            double neededStyrofoam = Math.Ceiling(addedPercentages / styrofoam) * price; //Spent
            double leftMoney = budget - neededStyrofoam; //Left

            if (budget >= neededStyrofoam)
            {
                Console.WriteLine($"Spent: {neededStyrofoam:f2}");
                Console.WriteLine($"Left: {leftMoney:f2}");
            }
            else
            {
                double neededMoney = neededStyrofoam - budget; //Need
                Console.WriteLine($"Need more: {neededMoney:f2}");
            }
        }
    }
}
