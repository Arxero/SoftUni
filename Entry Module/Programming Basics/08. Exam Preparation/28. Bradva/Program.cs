using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28.Bradva
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); // 1:56

            int width = 5 * n;

            //top
            int dasheLeft = n * 3;
            int dasheMid = 0;
            int dasheRight = width - dasheLeft - dasheMid - 2;

            for (int top = 0; top < n; top++)
            {
                Console.WriteLine("{0}*{1}*{2}", new string('-', dasheLeft), new string('-', dasheMid), new string('-', dasheRight));
                dasheMid++;
                dasheRight -= 1;
            }
            //midd
            for (int midd = 0; midd < n / 2; midd++)
            {
                Console.WriteLine("{0}*{1}*{2}", new string('*', dasheLeft), new string('-', dasheMid - 1), new string('-', dasheRight + 1));
            }
            //bott
            int dasheLeftBott = dasheLeft;
            int dasheMiddBott = dasheMid;
            int dasheRightBott = dasheRight;
            for (int bott = 0; bott < (n / 2) - 1; bott++)
            {
                Console.WriteLine("{0}*{1}*{2}", new string('-', dasheLeftBott), new string('-', dasheMiddBott -1), new string('-', dasheRightBott + 1));
                dasheLeftBott--;
                dasheMiddBott += 2;
                dasheRightBott--;
            }
            //last row
            Console.WriteLine("{0}{1}{2}", new string ('-', dasheLeftBott), new string ('*', width - dasheLeftBott - dasheRightBott - 1), new string ('-', dasheRightBott + 1));
        }
    }
}
