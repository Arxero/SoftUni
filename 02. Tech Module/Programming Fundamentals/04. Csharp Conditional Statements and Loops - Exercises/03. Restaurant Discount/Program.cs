using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Restaurant_Discount
{
    class Program
    {
        static void Main(string[] args)
        {
            int group = int.Parse(Console.ReadLine());
            string package = Console.ReadLine().ToLower();

            double price = 0;
            string hall = "";

            if (group <= 50)
            {
                price = 2500;
                hall = "Small Hall";
            }
            else if (group > 50 && group <= 100)
            {
                price = 5000;
                hall = "Terrace";

            }
            else if (group > 100 && group <= 120)
            {
                price = 7500;
                hall = "Great Hall";

            }
            else if (group > 120)
            {
                Console.WriteLine("We do not have an appropriate hall.");
            }

            double pricePackage = 0;
            double discountPercentage = 0;

            switch (package)
            {
                case "normal":
                    pricePackage = 500;
                    discountPercentage = 0.05;
                    break;
                case "gold":
                    pricePackage = 750;
                    discountPercentage = 0.10;
                    break;
                case "platinum":
                    pricePackage = 1000;
                    discountPercentage = 0.15;
                    break;
            }
            double totalPrice = price + pricePackage;
            double discount = totalPrice - (totalPrice * discountPercentage);
            double pricePerPerson = discount / group;
            if (group <= 120)
            {
                Console.WriteLine($"We can offer you the {hall}");
                Console.WriteLine($"The price per person is {pricePerPerson:f2}$");
            }
        }
    }
}
