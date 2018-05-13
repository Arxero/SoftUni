using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Cake_Ingredients
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;

            for (int i = 0; i <= 20; i++)
            {
                string ingredient = Console.ReadLine();
                
                if (ingredient == "Bake!")
                {
                    Console.WriteLine($"Preparing cake with {counter} ingredients.");
                    return;
                }
                Console.WriteLine($"Adding ingredient {ingredient}.");
                counter++;
            }
        }
    }
}
