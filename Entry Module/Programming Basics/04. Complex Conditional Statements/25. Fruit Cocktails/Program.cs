using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25.Fruit_Cocktails
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine().ToLower();
            string cocktailType = Console.ReadLine().ToLower();
            int cocktailNumber = int.Parse(Console.ReadLine());

            double price = 0;

            switch (fruit)
            {
                case "watermelon":
                    if (cocktailType == "small")
                    {
                        price = 2 * 56;
                    }
                    else if (cocktailType == "big")
                    {
                        price = 5 * 28.70;
                    }
                    break;
                case "mango":
                    if (cocktailType == "small")
                    {
                        price = 2* 36.66;
                    }
                    else if (cocktailType == "big")
                    {
                        price = 5 * 19.60;
                    }
                    break;
                case "pineapple":
                    if (cocktailType == "small")
                    {
                        price = 2 * 42.10;
                    }
                    else if (cocktailType == "big")
                    {
                        price = 5 * 24.80;
                    }
                    break;
                case "raspberry":
                    if (cocktailType == "small")
                    {
                        price = 2 * 20;
                    }
                    else if (cocktailType == "big")
                    {
                        price = 5 * 15.20;
                    }
                    break;

            }    
            double calculations = price * cocktailNumber;
            double discount = 0;

            if (calculations >= 400 && calculations <= 1000)
            {
                discount = calculations * 0.15;
                calculations -= discount;
            }
            else if (calculations > 1000)
            {
                discount = calculations * 0.50;
                calculations -= discount;
            }
            Console.WriteLine($"{calculations:f2} lv.");
        }
    }
}
