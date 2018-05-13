using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _54.Programming_Basics_Exam___19_March_2017___Morning___Hous
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine()); // 8 :30
            double y = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            //walls
            double sideWall = x * y;
            double window = 1.5 * 1.5;
            double twoWall = (2 * sideWall) - (2 * window);
            double backWall = x * x;
            double frontWall = 1.2 * 2;
            double bothWall = (2 * backWall) - frontWall;
            double totalArea = twoWall + bothWall;
            double greenPaint = totalArea / 3.4;
            Console.WriteLine($"{greenPaint:f2}");
            //roof
            double twoRectangles = 2 * (x * y);
            double twoTriangles = 2 * (x * h / 2);
            double totalAreaRoof = twoRectangles + twoTriangles;
            double redPaint = totalAreaRoof / 4.3;
            Console.WriteLine($"{redPaint:f2}");

        }
    }
}
