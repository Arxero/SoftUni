using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _67.Toy_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            double price = double.Parse(Console.ReadLine()); // 5:32
            int puzzels = int.Parse(Console.ReadLine());
            int dolls = int.Parse(Console.ReadLine());
            int tedybears = int.Parse(Console.ReadLine());
            int minions = int.Parse(Console.ReadLine());
            int trucks = int.Parse(Console.ReadLine());

            double total = (puzzels * 2.60) + (dolls * 3) + (tedybears * 4.10) + (minions * 8.20) + (trucks * 2);
            double toysNum = puzzels + dolls + tedybears + minions + trucks;
            if (toysNum >= 50)
            {
                total = total - (total * 0.25);
            }
            double VAT = total - (total * 0.10);
            double moneyLeft = VAT - price;

            if (VAT >= price)
            {
                Console.WriteLine($"Yes! {moneyLeft:f2} lv left.");

            }
            else
            {
                Console.WriteLine($"Not enough money! {Math.Abs(moneyLeft):f2} lv needed.");
            }
        }
    }
}
