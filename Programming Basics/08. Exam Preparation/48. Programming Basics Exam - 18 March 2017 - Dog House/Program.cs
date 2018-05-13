using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _48.Programming_Basics_Exam___18_March_2017___Dog_House
{
    class Program
    {
        static void Main(string[] args)
        {
            double lengthA = double.Parse(Console.ReadLine()); // 9:59
            double heightB = double.Parse(Console.ReadLine());

            double twoPages = lengthA * (lengthA / 2) * 2;
            //back side
            double square = (lengthA / 2) * (lengthA / 2);
            double triangale = (lengthA / 2 * (heightB - lengthA / 2)) / 2.0;
            double backSide = square + triangale;
            double entrance = (lengthA / 5.0) * (lengthA / 5.0);
            double frontSide = backSide - entrance;
            double allWallsArea = twoPages + backSide + frontSide;
            double greenPadouble = allWallsArea / 3;
            double roof = lengthA * (lengthA / 2) * 2.0;
            double redPadouble = roof / 5.0;
            Console.WriteLine($"{greenPadouble:f2}");
            Console.WriteLine($"{redPadouble:f2}");
        }
    }
}
