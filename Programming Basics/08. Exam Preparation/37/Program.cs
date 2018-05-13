using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _37_Flower_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            int magnolia = int.Parse(Console.ReadLine()); // 9:59
            int hyacinths = int.Parse(Console.ReadLine());
            int roses = int.Parse(Console.ReadLine());
            int kaktuses = int.Parse(Console.ReadLine());
            double giftPrice = double.Parse(Console.ReadLine());

            double calculation = (magnolia * 3.25 + hyacinths * 4 + roses * 3.50 + kaktuses * 8) - ((magnolia * 3.25 + hyacinths * 4 + roses * 3.50 + kaktuses * 8) * 0.05);
            double isItEnough = giftPrice - calculation;
            if (giftPrice > calculation)
            {
                Console.WriteLine($"She will have to borrow {Math.Ceiling(isItEnough)} leva.");
            }
            else
            {
                Console.WriteLine($"She is left with {Math.Abs(Math.Ceiling(isItEnough))} leva.");

            }
        }
    }
}
