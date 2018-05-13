using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19.Rekolta
{
    class Program
    {
        static void Main(string[] args)
        {
            int X = int.Parse(Console.ReadLine());
            double Y = double.Parse(Console.ReadLine());
            int Z = int.Parse(Console.ReadLine());
            int people = int.Parse(Console.ReadLine());

            double liter = 2.5;

            double grossGrapes = X * Y;
            double winePercentage = grossGrapes * 0.4;
            double wine = winePercentage / liter;
            double grossliters = wine - Z;
            double literPerson = grossliters / people;

            if (wine >= Z)
            {
                Console.WriteLine($"Good harvest this year! Total wine: {Math.Floor(wine)} liters.");
                Console.WriteLine($" {Math.Ceiling(grossliters)} liters left -> {Math.Ceiling(literPerson)} liters per person.");
            }
            else
            {
                double grossliters2 = Z - wine;
                Console.WriteLine($"It will be a tough winter! More {Math.Floor(grossliters2)} liters wine needed.");
            }
        }
    }
}
