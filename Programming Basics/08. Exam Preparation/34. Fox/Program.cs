using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _34.Fox
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); // 6:12

            int width = 2 * n + 3;
            int asterisk = 1;
            int dashes = (width - (2 * asterisk)) - 2;

            //top
            for (int top = 0; top < n; top++)
            {
                Console.WriteLine(@"{0}\{1}/{0}", new string('*', asterisk), new string('-', dashes));
                asterisk++;
                dashes -= 2;
            }

            //mid
            int asteriskMid = asterisk - 1;
            int asteriskOnSide = (width - asteriskMid - 4) / 2;

            for (int mid = 0; mid < n / 3; mid++)
            {
                Console.WriteLine(@"|{0}\{1}/{0}|", new string('*', asteriskOnSide), new string('*', asteriskMid));
                asteriskOnSide++;
                asteriskMid -= 2;
            }

            //bott
            int bottDashes = 1;
            int bottAsterisks = (width - (2 * bottDashes)) - 2;
            for (int bott = 0; bott < n; bott++)
            {
                Console.WriteLine(@"{0}\{1}/{0}", new string('-', bottDashes), new string('*', bottAsterisks));
                bottDashes++;
                bottAsterisks -= 2;
            }
        }
    }
}
