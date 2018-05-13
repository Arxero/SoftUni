using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20.Hourglass
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); // 5:47

            int width = 2 * n + 1;
            char asterisk = '*';
            char dots = '.';
            char space = ' ';
            

            //first row
            Console.WriteLine("{0}", new string (asterisk, width));

            //second
            Console.WriteLine(".*{0}*.", new string (space, width - 4));

            // third and bellow
            int dotsNum = 2;
            int atSignNum = width - 6;
            for (int topRows = 0; topRows < n - 2; topRows++)
            {
            Console.WriteLine("{0}*{1}*{0}", new string (dots, dotsNum), new string ('@', atSignNum));
                dotsNum++;
                atSignNum -= 2;
            }

            //mid
            Console.WriteLine("{0}*{0}", new string (dots, dotsNum));

            //bott 7th row
            Console.WriteLine("{0}*@*{0}", new string (dots, (width - 3) / 2));

            //bott
            int dotsNum2 = (width - 5) / 2;
            int spaceNum = 1;
            for (int bottRows = 0; bottRows < n - 3; bottRows++)
            {
                Console.WriteLine("{0}*{1}@{1}*{0}", new string(dots, dotsNum2), new string(space, spaceNum));
                dotsNum2--;
                spaceNum++;
            }
            // before the last row
            Console.WriteLine(".*{0}*.", new string ('@', width - 4));
            // last row
            Console.WriteLine("{0}", new string(asterisk, width));

        }
    }
}
