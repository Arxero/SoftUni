using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31.Pets
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine()); // 5:17
            int food = int.Parse(Console.ReadLine());
            double foodDOg = double.Parse(Console.ReadLine());
            double foodCat = double.Parse(Console.ReadLine());
            double foodTurtle = double.Parse(Console.ReadLine());

            double neededDogFood = days * foodDOg;
            double neededCatFood = days * foodCat;
            double neededTurtleFood = (days * foodTurtle) / 1000;
            double totalFood = neededDogFood + neededCatFood + neededTurtleFood;
            double isItEnough = Math.Abs(food - totalFood);
            if (food >= totalFood)
            {
                Console.WriteLine($"{Math.Floor(isItEnough)} kilos of food left.");
            }
            else
            {
                Console.WriteLine($"{Math.Ceiling(isItEnough)} more kilos of food are needed.");
            }
        }
    }
}
