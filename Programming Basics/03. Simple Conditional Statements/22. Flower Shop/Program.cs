using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22.Flower_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            int magnolia = int.Parse(Console.ReadLine());
            int hyacinths = int.Parse(Console.ReadLine());
            int roses = int.Parse(Console.ReadLine());
            int cactuses = int.Parse(Console.ReadLine());
            double price = double.Parse(Console.ReadLine());

            double magnoliaPrice = 3.25;
            double hyacinthsPrice = 4;
            double rosesPrice = 3.50;
            double cactusesPrice = 8;

            double moneyNeeded = (magnolia * magnoliaPrice)+(hyacinths * hyacinthsPrice)+(roses * rosesPrice)+(cactuses * cactusesPrice);
            double VAT = moneyNeeded * 0.05;
            double income = moneyNeeded - VAT;
            double leftMoney = Math.Floor(income - price);

            if (price <= income)
            {
                Console.WriteLine($"She is left with {leftMoney} leva.");
            }
            else
            {
                double neededMoney = Math.Ceiling(price - income);
                Console.WriteLine($"She will have to borrow {neededMoney} leva.");
            }
        }
    }
}
