using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23.Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); // 4:27

            int width = (4 * n) + 1;
            int height = (2 * n) + 1;
            int dotsNum = 1;
            //Console.WriteLine(width);

            //first row
            Console.WriteLine(new string ('#', width));

            //second and bellow
            int numberSignNum = (width - 3) / 2;
            int spaceNum = 1;
            for (int topRows = 0; topRows < n / 2; topRows++)
            {
                Console.WriteLine("{0}{1}{2}{1}{0}", new string('.', dotsNum), new string('#', numberSignNum), new string(' ', spaceNum));
                dotsNum++;
                numberSignNum -= 2;
                spaceNum += 2;
            }
            //mid row
            Console.WriteLine("{0}{1}{2}(@){2}{1}{0}", new string('.', dotsNum), new string('#', numberSignNum), new string(' ', (spaceNum / 2) - 1));

            //mid
            int midRowsCycles = height -  (2 + n + (n / 2));
            for (int midRows = 0; midRows < midRowsCycles; midRows++)
            {
                dotsNum++;
                numberSignNum -= 2;
                spaceNum += 2;

                Console.WriteLine("{0}{1}{2}{1}{0}", new string('.', dotsNum), new string('#', numberSignNum), new string(' ', spaceNum));
            }

            //bott
            int numberSignBottNum = (width - 3) / 2;
            int dotsBottNum = dotsNum + 1;
            for (int bottRows = 0; bottRows < n; bottRows++)
            {
                Console.WriteLine("{0}{1}{0}", new string('.', dotsBottNum), new string('#', numberSignBottNum));
                dotsBottNum++;
                numberSignBottNum -= 2;
            }

        }
    }
}
