using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remont_na_plochki
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            double W = double.Parse(Console.ReadLine());
            double L = double.Parse(Console.ReadLine());
            int M = int.Parse(Console.ReadLine());
            int O = int.Parse(Console.ReadLine());

            double time = 0.2;
            int bench = (M * O);
            int workground = (N * N);
            int coverage_area = (workground - bench);
            double tiles = (L * W);

            double needed_tiles = (coverage_area / tiles);
            Console.WriteLine("{0:F2}",needed_tiles,2);
            Console.WriteLine("{0:F2}", (needed_tiles * time));
        }
    }
}
