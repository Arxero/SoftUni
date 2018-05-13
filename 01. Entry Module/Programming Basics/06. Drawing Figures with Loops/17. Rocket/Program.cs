using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.Rocket
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); // 3:01

            int width = 3 * n;
            char dots = '.';
            int dotsNum = (3 * n - 2) / 2;
            char space = ' ';
            int spaceNum = 0;
            char asterisk = '*';
            int dotsNumBott = n / 2;

            //top
            for (int topRows = 0; topRows < n; topRows++)
            {
                Console.WriteLine(@"{0}/{1}\{0}", new string(dots, dotsNum), new string(space, spaceNum));
                dotsNum--;
                spaceNum += 2;
            }

            //mid row
            Console.WriteLine("{0}{1}{0}", new string (dots, n / 2), new string (asterisk, spaceNum));

            //mid, bellow
            for (int midRows = 0; midRows < n * 2; midRows++)
            {
                Console.WriteLine("{0}|{1}|{0}", new string(dots, n / 2), new string('\\', spaceNum - 2));
            }

            //bott
            int asteriskNumBott = spaceNum - 2;
            for (int bottRows = 0; bottRows < n / 2; bottRows++)
            {
                Console.WriteLine(@"{0}/{1}\{0}", new string(dots, dotsNumBott), new string(asterisk, asteriskNumBott));
                dotsNumBott--;
                asteriskNumBott += 2;
            }
        }
    }
}
