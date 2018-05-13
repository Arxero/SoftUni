using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22.Crown
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); // 8:05

            int width = (2 * n) - 1;
            int heigth = (n / 2) + 4;
            char space = ' ';
            char dots = '.';
            double almostLastRow = Math.Ceiling (n / 4.0);

            //firs row
            Console.WriteLine("@{0}@{0}@", new string(space, (width - 3) / 2));

            //second and bellow
            Console.WriteLine("**{0}*{0}**", new string (space, (width - 5) / 2));
            int dotsNum = 2;
            int spaceNum = (width - 13) / 2;
            int dotsNumMid = dotsNum + 1;
            Console.WriteLine("*{0}*{1}*{0}*{1}*{0}*", new string(dots, 1), new string(space, spaceNum + 2));
            int asterisk = 1;
            for (int topRows = 0; topRows < heigth - 7; topRows++)
            {
                Console.WriteLine("{3}{0}{3}{1}{3}{2}{3}{1}{3}{0}{3}", new string (dots, dotsNum), new string (space, spaceNum), new string (dots, dotsNumMid), new string ('*', asterisk));
                //Console.WriteLine("*{0}*{1}{2}{1}*{0}*", new string(dots, dotsNum), new string(space, spaceNum), new string (dots, dotsNumMid));
                dotsNum++;
                dotsNumMid += 2;
                spaceNum -= 2;
            }
            Console.WriteLine("*{0}*{1}*{0}*", new string (dots, dotsNum), new string (dots, dotsNumMid));
            Console.WriteLine("*{0}{1}.{1}{0}*", new string (dots, dotsNum + 1), new string ('*', dotsNum -1));
            //Console.WriteLine("*{0}{1}.{1}{0}*", new string (dots, dotsNum + 1), new string ('*', (int)almostLastRow));
            Console.WriteLine(new string ('*', width));
            Console.WriteLine(new string ('*', width));
        }
    }
}
