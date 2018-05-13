using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Calories_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int calories = 0;
            int totalCalories = 0;

            for (int i = 0; i < n; i++)
            {
                string ingredients = Console.ReadLine().ToLower();

                switch (ingredients)
                {
                    case "cheese":
                        calories = 500;
                        totalCalories += calories;
                        break;
                    case "tomato sauce":
                        calories = 150;
                        totalCalories += calories;
                        break;
                    case "salami":
                        calories = 600;
                        totalCalories += calories;
                        break;
                    case "pepper":
                        calories = 50;
                        totalCalories += calories;
                        break;
                }
            }
            Console.WriteLine($"Total calories: {totalCalories}");
        }
    }
}
