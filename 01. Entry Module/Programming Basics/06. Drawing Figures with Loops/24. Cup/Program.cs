using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24.Cup
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); // 6:00

            int width = 5 * n;
            char dots = '.';
            char numSign = '#';
            int dotsNum = n;
            int numSignNum = n * 3;

            //top
            for (int topRows = 0; topRows < n / 2; topRows++)
            {
                Console.WriteLine("{0}{1}{0}", new string(dots, dotsNum), new string(numSign, numSignNum));
                dotsNum++;
                numSignNum -= 2;
            }

            //mid
            int midDotsNum = width - (dotsNum * 2) - 2;
            for (int midRows = 0; midRows < (n / 2) + 1; midRows++)
            {
                Console.WriteLine("{0}#{1}#{0}", new string(dots, dotsNum), new string(dots, midDotsNum));
                dotsNum++;
                midDotsNum -= 2;
            }

            //between
            int numSignBetween = n + 4;
            int dotsBetweenNum = (width - n) / 2 - 2;

            Console.WriteLine("{0}{1}{0}", new string(dots, (width - n) / 2), new string(numSign, n));
            for (int betweenRows = 0; betweenRows < n / 2; betweenRows++)
            {
                Console.WriteLine("{0}{1}{0}", new string(dots, dotsBetweenNum), new string(numSign, numSignBetween));
            }

            //dance text
            Console.WriteLine("{0}D^A^N^C^E^{0}", new string (dots, (width - 10) /2));

            //bott
            for (int betweenRows = 0; betweenRows < n / 2 + 1; betweenRows++)
            {
                Console.WriteLine("{0}{1}{0}", new string(dots, dotsBetweenNum), new string(numSign, numSignBetween));
            }
        }
    }
}
