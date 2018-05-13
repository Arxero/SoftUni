using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27.Toy_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            double tripPrice = double.Parse(Console.ReadLine());
            int puzzels = int.Parse(Console.ReadLine());
            int dolls = int.Parse(Console.ReadLine());
            int teddyBears = int.Parse(Console.ReadLine());
            int minions = int.Parse(Console.ReadLine());
            int trucks = int.Parse(Console.ReadLine());

            double puzzelPrice = 2.60;
            double dollPrice = 3;
            double teddybearPrice = 4.10;
            double minionPrice = 8.20;
            double truckPrice = 2;

            double summedPrice = puzzels * puzzelPrice + dolls * dollPrice + teddyBears * teddybearPrice + minions * minionPrice + trucks * truckPrice; //680
            double summedToys = puzzels + dolls + teddyBears + minions + trucks; // 135
            if (summedToys >= 50)
            {
                double discountPercentage = summedPrice * 0.25; // 170
                double discountPriceSubstracted = summedPrice - discountPercentage; //510
                double rentPercentage = discountPriceSubstracted * 0.10; //51
                double profit = discountPriceSubstracted - rentPercentage; //459
                double leftedmoney = Math.Round(profit - tripPrice,2);
                if (profit >= tripPrice)
                {
                    Console.WriteLine($"Yes! {leftedmoney:f2} lv left.");
                }
                else
                {
                    double neededMoney = Math.Round(tripPrice - profit,2);
                    Console.WriteLine($"Not enough money! {neededMoney:f2} lv needed.");
                }
            }
            else 
            {
                //double discountPercentage = summedPrice * 0.25; // 170
                double discountPriceSubstracted = summedPrice; //510
                double rentPercentage = discountPriceSubstracted * 0.10; //51
                double profit = discountPriceSubstracted - rentPercentage; //459
                double leftedmoney = Math.Round(tripPrice - profit,2);
                if (profit > tripPrice)
                {
                    Console.WriteLine($"Yes! {leftedmoney:f2} lv left.");
                }
                else
                {
                    double neededMoney = Math.Round(tripPrice - profit,2);
                    Console.WriteLine($"Not enough money! {leftedmoney:f2} lv needed.");
                }
            }

        }

    }
}
