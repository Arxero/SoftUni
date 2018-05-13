using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Fruit_or_Vegetable
{
    class Program
    {
        static void Main(string[] args)
        {
            string foodChecker = Console.ReadLine();

            if (foodChecker == "banana" ||
                foodChecker == "apple" ||
                foodChecker == "kiwi" ||
                foodChecker == "cherry" ||
                foodChecker == "lemon" ||
                foodChecker == "grapes")
            {
                Console.WriteLine("fruit");
            }
            else if (foodChecker == "tomato"||
                     foodChecker == "cucumber"||
                     foodChecker == "pepper" ||
                     foodChecker == "carrot")
            {
                Console.WriteLine("vegetable");
            }
            else
            {
                Console.WriteLine("unknown");
            }
        }
    }
}
