using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21.Pets
{
    class Program
    {
        static void Main(string[] args)
        {
            int day = int.Parse(Console.ReadLine());
            int food = int.Parse(Console.ReadLine());
            double dog = double.Parse(Console.ReadLine());
            double cat = double.Parse(Console.ReadLine());
            double turtle = double.Parse(Console.ReadLine());

            double dogFood = day * dog;
            double catFood = day * cat;
            double turtleFood = day * turtle / 1000;
            double wholeFood = dogFood + catFood + turtleFood;
            double leftFood = Math.Floor(food - wholeFood);

            if (food >= wholeFood)
            {
                Console.WriteLine($"{leftFood} kilos of food left.");
            }
            else
            {
                double neededFood = Math.Ceiling(wholeFood - food);
                Console.WriteLine($"{neededFood} more kilos of food are needed.");
            }
        }
    }
}
