using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Diamond_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); // 7:40

            int width = n * 5;
            int height = 3 * n + 2;
            int dotsIn = (n * 5) - (2 * n);
            int dotsOut = n - 1;

            //first row
            Console.WriteLine("{0}{1}{0}", new string ('.', n), new string ('*', dotsIn));

            //second and bellow
            for (int topRows = 0; topRows < n - 1; topRows++)
            {
                Console.WriteLine("{0}*{1}*{0}", new string('.', dotsOut), new string('.', dotsIn));
                dotsOut--;
                dotsIn += 2;
            }
            //mid row
            Console.WriteLine(new string ('*', width));

            //bellow mid row
            for (int bottomRows = 0; bottomRows < n * 2; bottomRows++)
            {

                Console.WriteLine("{0}*{1}*{0}", new string('.', dotsOut + 1), new string('.', dotsIn - 2));
                dotsOut++;
                dotsIn -= 2;
            }

            //last row
            Console.WriteLine("{0}{1}{0}", new string('.', (dotsOut + 1)), new string('*', n - 2));
        }
    }
}
