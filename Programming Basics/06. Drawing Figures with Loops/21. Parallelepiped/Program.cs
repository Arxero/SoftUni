using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21.Parallelepiped
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); // 6:30

            int width = 3 * n + 1;
            int height = 4 * n + 4;
            char tild = '~';
            int tildNum = n - 2;
            char dots = '.';
            int dotsNum = width - tildNum - 2;
            

            //first row
            Console.WriteLine("+{0}+{1}", new string (tild, tildNum), new string (dots, dotsNum));

            //second and bellow
            Console.WriteLine("|\\{0}\\{1}", new string (tild, tildNum), new string (dots, dotsNum -1));
            int dotsNumLeft = 1;
            int dotsNumRight = dotsNum - 2;
            for (int topRows = 0; topRows < n * 2; topRows++)
            {
                Console.WriteLine("|{0}\\{1}\\{2}", new string(dots, dotsNumLeft), new string(tild, tildNum), new string(dots, dotsNumRight));
                dotsNumLeft++;
                dotsNumRight--;
            }
            //first after the half
            Console.WriteLine("\\{0}|{1}|",new string (dots, dotsNumLeft -1), new string (tild, tildNum));
            int dotsNumLeftInside = dotsNumLeft - 2;
            int dotsNumRightOutside = 1;
            for (int bottRows = 0; bottRows < n * 2; bottRows++)
            {
                Console.WriteLine("{0}\\{1}|{2}|", new string(dots, dotsNumRightOutside), new string(dots, dotsNumLeftInside), new string(tild, tildNum));
                dotsNumRightOutside++;
                dotsNumLeftInside--;
            }

            // last row
            Console.WriteLine("{0}+{1}+", new string(dots, dotsNum), new string(tild, tildNum));
        }
    }
}
