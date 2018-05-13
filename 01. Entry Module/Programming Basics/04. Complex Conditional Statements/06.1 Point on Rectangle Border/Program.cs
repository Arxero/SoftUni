using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06._1_Point_on_Rectangle_Border
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());

            bool left = (x == x1) && (y >= y1) && (y <= y2);
            bool right = (x == x2) && (;
            bool top =
            bool bottom =


            if (borderSide && borderCorner)
            {
                Console.WriteLine("Border");



            }
            else
            {
                Console.WriteLine("Inside / Outside");
            }
        }
    }
}
