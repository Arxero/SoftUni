using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.Fox
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); //8:03

            int width = 2 * n + 3;
            int asteriskNum = 1;
            char asterisk = '*';
            int dasheNum = width - 4;
            char dashe = '-';
            int midAsterisk = n / 2;
            int bottAsteriskNum = width - 4;
            int bottDasheNum = 1;
            int midCycles = 2;
            

            //top
            for (int topRows = 0; topRows < n; topRows++)
            {
                Console.WriteLine(@"{0}\{1}/{0}", new string(asterisk, asteriskNum), new string(dashe, dasheNum));
                asteriskNum++;
                dasheNum -= 2;
            }
            //midd
            int centerMidAsterisk = asteriskNum - 1;
            //if (n > 7)
            //{
            //    midCycles = 3;
            //}
            //if (n % 10 == 7)
            //{
            //    midCycles = 2;
            //}
            for (int modRows = 0; modRows < n / 3; modRows++)
            {
                Console.WriteLine(@"|{0}\{1}/{0}|", new string(asterisk, midAsterisk), new string(asterisk, centerMidAsterisk));
                midAsterisk++;
                centerMidAsterisk -= 2;
            }
            //bottom
            for (int bottRows = 0; bottRows < n; bottRows++)
            {
                Console.WriteLine(@"{0}\{1}/{0}", new string(dashe, bottDasheNum), new string(asterisk, bottAsteriskNum));
                bottDasheNum++;
                bottAsteriskNum -= 2;
            }

        }
    }
}
