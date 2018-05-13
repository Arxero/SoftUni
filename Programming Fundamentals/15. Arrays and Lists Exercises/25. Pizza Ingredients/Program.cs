using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25.Pizza_Ingredients
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split().ToArray();
            int n = int.Parse(Console.ReadLine());
            int count = 0;
            string[] ingredients = new string[input.Length];
            int iCorector = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i].Count() == n && count < 10)
                {
                    Console.WriteLine($"Adding {input[i]}.");
                    count++;
                    //rray.Resize(ingredients, count);
                    ingredients[iCorector] = input[i];
                    iCorector++;
                }
            }
            Array.Resize(ref ingredients, count);
            Console.WriteLine($"Made pizza with total of {count} ingredients.");
            Console.WriteLine($"The ingredients are: {string.Join(", ", ingredients)}.");
        }
    }
}
