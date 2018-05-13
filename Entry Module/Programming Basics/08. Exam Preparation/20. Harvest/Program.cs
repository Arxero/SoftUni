using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20.Harvest
{
    class Program
    {
        static void Main(string[] args)
        {
            double X = double.Parse(Console.ReadLine()); // 4:32
            double Y = double.Parse(Console.ReadLine());
            double Z = double.Parse(Console.ReadLine());
            double workers = double.Parse(Console.ReadLine());

            double totalGrapes = X * Y;
            double winePercentage = totalGrapes * 0.40 / 2.5;
            double leftwine = winePercentage - Z;
            double enough = (winePercentage - Z) / workers;
            if (winePercentage >= Z)
            {
                Console.WriteLine($"Good harvest this year! Total wine: {Math.Floor(winePercentage)} liters.");
                Console.WriteLine($"{Math.Ceiling(leftwine)} liters left -> {Math.Ceiling(enough)} liters per person.");
            }
            else if (winePercentage < Z)
            {
                Console.WriteLine($"It will be a tough winter! More {Math.Floor(Math.Abs(leftwine))} liters wine needed.");
            }
        }
    }
}
