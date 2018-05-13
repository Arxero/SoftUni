using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19.SoftUni_Logo
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); // 4:09

            int width = 12 * n - 5;
            int heigth = 4 * n - 2;
            char dots = '.';
            int dotsNum = (width - 1) / 2;
            char numSign = '#';
            int numSignNum = 1;

            //top
            for (int top = 0; top < n * 2 - 1; top++)
            {
                Console.WriteLine("{0}{1}{0}", new string(dots, dotsNum), new string(numSign, numSignNum));
                dotsNum -= 3;
                numSignNum += 6;
            }

            //mid
            Console.WriteLine("{0}", new string (numSign, width));

            //bottom
            int numSignNum2 = width - 6;
            int dotSum2 = 2;
            int dotSum3 = 3;
            for (int bottRows = 0; bottRows < n - 2; bottRows++)
            {
                Console.WriteLine("|{0}{1}{2}", new string(dots, dotSum2), new string(numSign, numSignNum2), new string(dots, dotSum3));
                dotSum2 += 3;
                numSignNum2 -= 6;
                dotSum3 += 3;
            }

            //last rows
            for (int lastRows = 0; lastRows < n - 1; lastRows++)
            {
                Console.WriteLine("|{0}{1}{2}", new string(dots, dotSum2), new string(numSign, numSignNum2), new string(dots, dotSum3));
            }
            Console.WriteLine("@{0}{1}{2}", new string(dots, dotSum2), new string(numSign, numSignNum2), new string(dots, dotSum3));
        }
    }
}
