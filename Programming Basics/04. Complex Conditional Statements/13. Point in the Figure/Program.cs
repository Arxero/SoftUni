using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point_in_the_Figure
{
    class Program
    {
        static void Main(string[] args)
        {
            int h = int.Parse(Console.ReadLine());
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            bool inFigure = (((0 < x && x < 3 * h) && (0 < y && y < h)) || ((h < x && x < 2 * h) && (0 < y && y < 4 * h)));
            bool outOfFigure = ((x < 0 || 3 * h < x) || (y < 0 || h < y)) && ((x < h || 2 * h < x) || (y < 0 || 4 * h < y));

            if (inFigure)
            {
                Console.WriteLine("inside");
            }
            else if (outOfFigure)
            {
                Console.WriteLine("outside");
            }
            else
            {
                Console.WriteLine("border");
            }
        }
    }
}