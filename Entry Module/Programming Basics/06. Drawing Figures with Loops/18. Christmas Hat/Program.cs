using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.Christmas_Hat
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); // 3:32

            int width = 4 * n + 1;
            int height = 2 * n + 5;
            char dots = '.';
            int dotsNum = (width - 3) / 2;
            char asterisk = '*';
            int dotNumMid = dotsNum - 1;
            char dash = '-';
            int dashNum = 1;

            //top
            Console.WriteLine(@"{0}/|\{0}", new string (dots, dotsNum));
            Console.WriteLine(@"{0}\|/{0}", new string (dots, dotsNum));
            Console.WriteLine(@"{0}***{0}", new string (dots, dotsNum));

            //mid
            for (int midRows = 0; midRows < n * 2 - 1; midRows++)
            {
                Console.WriteLine("{0}*{1}*{1}*{0}", new string(dots, dotNumMid), new string(dash, dashNum));
                dotNumMid--;
                dashNum++;
            }

            //bottom
            Console.WriteLine("{0}", new string (asterisk, width));
            //Console.WriteLine("*{0}*", new string ('*.', width));
            for (int almostLastRow = 0; almostLastRow < width / 2; almostLastRow++)
            {
                Console.Write("*");
                Console.Write(".");
            }
            Console.Write("*");
            Console.WriteLine();
            Console.WriteLine("{0}", new string(asterisk, width));

        }
    }
}
