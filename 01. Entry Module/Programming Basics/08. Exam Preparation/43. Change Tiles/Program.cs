using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _43.Change_Tiles
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine()); // 5:30
            double floor = double.Parse(Console.ReadLine());
            double length = double.Parse(Console.ReadLine());
            double sideTrinagle = double.Parse(Console.ReadLine());
            double hightTriangle = double.Parse(Console.ReadLine());
            double tilePrice = double.Parse(Console.ReadLine());
            double handyman = double.Parse(Console.ReadLine());

            double floorArea = floor * length;
            double tileArea = sideTrinagle * hightTriangle / 2;
            double neededTiles = Math.Ceiling(floorArea / tileArea + 5);
            double total = neededTiles * tilePrice + handyman;
            double isItEnough = money - total;
            if (money >= total)
            {
                Console.WriteLine($"{isItEnough:f2} lv left.");
            }
            else
            {
                Console.WriteLine($"You'll need {Math.Abs(isItEnough):f2} lv more.");
            }
        }
    }
}
