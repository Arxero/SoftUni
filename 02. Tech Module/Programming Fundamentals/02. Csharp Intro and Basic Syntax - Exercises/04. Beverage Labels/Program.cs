using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Beverage_Labels
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double mililiteres = double.Parse(Console.ReadLine());
            double energy = double.Parse(Console.ReadLine());
            double sugar = double.Parse(Console.ReadLine());

            double calories = (mililiteres * energy) / 100;
            double sugarAmount = (mililiteres * sugar) / 100;

            Console.WriteLine($"{mililiteres}ml {name}:");
            Console.WriteLine($"{calories}kcal, {sugarAmount}g sugars");
        }
    }
}
