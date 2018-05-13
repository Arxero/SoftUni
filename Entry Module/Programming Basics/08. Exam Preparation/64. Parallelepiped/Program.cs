using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _64.Parallelepiped
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); // 12:30

            int height = 4 * n + 4;
            int width = 3 * n + 1;
            int tilt = n - 2;

            //first
            Console.WriteLine("+{0}+{1}", new string ('~', tilt), new string ('.', width - tilt - 2));
            //second and bellow
            int dotsLeft = 0;
            int dotsRight = width - tilt - 3;
            for (int top = 0; top < (n * 2) + 1; top++)
            {
                Console.WriteLine(@"|{0}\{1}\{2}", new string('.', dotsLeft), new string('~', tilt), new string('.', dotsRight));
                dotsLeft++;
                dotsRight--; ;
            }
            //midd
            int dotsLeftBott = 0;
            int dotsRightBott = dotsLeft - 1;
            for (int bott = 0; bott < (n * 2) + 1; bott++)
            {
                Console.WriteLine(@"{0}\{1}|{2}|", new string('.', dotsLeftBott), new string('.', dotsRightBott), new string('~', tilt));
                dotsLeftBott++;
                dotsRightBott--;
            }
            Console.WriteLine("{0}+{1}+", new string('.', width - tilt - 2), new string('~', tilt));
        }
    }
}
