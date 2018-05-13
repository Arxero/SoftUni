using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23.Change_Tiles
{
    class Program
    {
        static void Main(string[] args)
        {
            double theMoney = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double length = double.Parse(Console.ReadLine());
            double triangleSide = double.Parse(Console.ReadLine());
            double triangleHeight = double.Parse(Console.ReadLine());
            double tilePrice = double.Parse(Console.ReadLine());
            double handymanPrice = double.Parse(Console.ReadLine());

            double floorSize = width * length;
            double tileSize = triangleSide * triangleHeight / 2;
            double neededTiles = Math.Ceiling((floorSize / tileSize) + 5);
            double totalPrice = (neededTiles * tilePrice) + handymanPrice;
            double leftMoney = theMoney - totalPrice;

            if (theMoney >= totalPrice)
            {
                Console.WriteLine($"{leftMoney:f2} lv left.");
            }
            else
            {
                double neededMoney = totalPrice - theMoney;
                Console.WriteLine($"You'll need {neededMoney:f2} lv more.");
            }
        }
    }
}
