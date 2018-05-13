using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Coding_101_Exam___24_April_2016____Popravka_na_Plochki
{
    class Program
    {
        static void Main(string[] args)
        {
            double N = double.Parse(Console.ReadLine()); // 4;50
            double W = double.Parse(Console.ReadLine());
            double L = double.Parse(Console.ReadLine());
            double M = double.Parse(Console.ReadLine());
            double O = double.Parse(Console.ReadLine());

            double totalArea = N * N;
            double trenchSize = M * O;
            double areaToCover = totalArea - trenchSize;
            double tileArea = W * L;
            double neededTiles = areaToCover / tileArea;
            double neededTime = neededTiles * 0.2;
            Console.WriteLine($"{neededTiles:f2}");
            Console.WriteLine($"{neededTime:f2}");
        }
    }
}
