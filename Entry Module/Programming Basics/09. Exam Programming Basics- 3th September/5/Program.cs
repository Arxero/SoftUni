using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int heitgh = 2 * n + 1;
            int width = 2 * n + 3;

            //top
            Console.WriteLine("*{0}*{0}*", new string('.', n));
            int dotsLeft = 1;
            int dotsMid = n - 1;
            for (int top = 0; top < n - 2; top++)
            {
                Console.WriteLine("{0}*{1}*{1}*{0}", new string('.', dotsLeft), new string('.', dotsMid));
                dotsLeft++;
                dotsMid--; ;
            }
            Console.WriteLine("{0}{1}{0}", new string ('.', dotsLeft), new string ('*', width - (dotsLeft * 2)));
            Console.WriteLine("{0}", new string ('*', width));
            //bott
            Console.WriteLine("{0}{1}{0}", new string('.', dotsLeft), new string('*', width - (dotsLeft * 2)));
            //bellow
            int dotsLeftBott = dotsLeft - 1;
            int dotsMidBott = 2;
            for (int bott = 0; bott < n - 2; bott++)
            {
                Console.WriteLine("{0}*{1}*{1}*{0}", new string('.', dotsLeftBott), new string('.', dotsMidBott));
                dotsLeftBott--;
                dotsMidBott++;
            }
            Console.WriteLine("*{0}*{0}*", new string('.', n));

        }
    }
}
