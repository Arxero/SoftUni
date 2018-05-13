using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Training_Hall_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int items = int.Parse(Console.ReadLine());

            double sumSubtotal = 0;

            for (int i = 0; i < items; i++)
            {
                string itemName = Console.ReadLine();
                double itemPrice = double.Parse(Console.ReadLine());
                int itemCount = int.Parse(Console.ReadLine());

                if (itemCount > 1)
                {
                    itemName = itemName + "s";
                }
                Console.WriteLine($"Adding {itemCount} {itemName} to cart.");
                double subtotal = itemPrice * itemCount;
                sumSubtotal += subtotal;
            }
            Console.WriteLine($"Subtotal: ${sumSubtotal:f2}");
            double moneyLeft = Math.Abs(budget - sumSubtotal);
            if (budget > sumSubtotal)
            {
                Console.WriteLine($"Money left: ${moneyLeft:f2}");
            }
            else
            {
                Console.WriteLine($"Not enough. We need ${moneyLeft:f2} more.");
            }
        }
    }
}
