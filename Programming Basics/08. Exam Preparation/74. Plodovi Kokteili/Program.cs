using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _74.Plodovi_Kokteili
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string size = Console.ReadLine();
            int drinks = int.Parse(Console.ReadLine());

            double small = 0;
            double big = 0;

            switch (fruit)
            {
                case "Watermelon":
                    small = 56 * 2;
                    big = 28.70 * 5;
                    break;
                case "Mango":
                    small = 36.66 * 2;
                    big = 19.60 * 5;
                    break;
                case "Pineapple":
                    small = 42.10 * 2;
                    big = 24.80 * 5;
                    break;
                case "Raspberry":
                    small = 20 * 2;
                    big = 15.20 * 5;
                    break;
            }
            double cocktail = 0;
            switch (size)
            {
                case "big":
                    cocktail = big * drinks;
                    break;
                case "small":
                    cocktail = small * drinks;
                    break;
            }
            if (cocktail >= 400 && cocktail <= 1000)
            {
                cocktail = cocktail - (cocktail * 0.15);
            }
            else if (cocktail > 1000)
            {
                cocktail = cocktail - (cocktail * 0.50);
            }
            Console.WriteLine($"{cocktail:f2} lv.");

        }
    }
}
