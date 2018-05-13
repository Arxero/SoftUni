using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _40.Rocket
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); // 12:18

            int width = 3 * n;
            int dots = (width - 2) / 2;
            int empty = 0;

            //top
            for (int top = 0; top < n; top++)
            {
                Console.WriteLine(@"{0}/{1}\{0}", new string('.', dots), new string(' ', empty));
                dots--;
                empty += 2;
            }
            //mid
            Console.WriteLine("{0}{1}{0}", new string ('.', dots + 1), new string ('*', empty));

            //bellow
            for (int mid = 0; mid < n * 2; mid++)
            {
                Console.WriteLine("{0}|{1}|{0}", new string('.', dots + 1), new string('\\', empty - 2));

            }
            //bott
            int dotsBott = dots + 1;
            int asterisk = empty - 2;
            for (int bott = 0; bott < n / 2; bott++)
            {
                Console.WriteLine(@"{0}/{1}\{0}", new string('.', dotsBott), new string('*', asterisk));
                dotsBott--;
                asterisk += 2;
            }
        }
    }
}
