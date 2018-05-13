using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _58.Hourglass
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int width = 2 * n + 1;

            //first row
            Console.WriteLine("{0}", new string ('*', width));

            //second
            Console.WriteLine(".*{0}*.", new string (' ', width - 4));
            //bellow
            int dots = 2;
            int symbol = width - 6;
            for (int top = 0; top < n - 2; top++)
            {
                Console.WriteLine("{0}*{1}*{0}", new string('.', dots), new string('@', symbol));
                dots++;
                symbol -= 2;
            }
            //mid
            Console.WriteLine("{0}*{0}", new string ('.', (width - 1) / 2));
            //bott
            int dotsBott = ((width - 1) / 2) - 1;
            int empty = 0;
            for (int bott = 0; bott < n - 2; bott++)
            {
                Console.WriteLine("{0}*{1}@{1}*{0}", new string('.', dotsBott), new string(' ', empty));
                dotsBott--;
                empty += 1;
            }
            //before last
            Console.WriteLine(".*{0}*.", new string ('@', width - 4));
            //last
            Console.WriteLine("{0}", new string('*', width));
        }
    }
}
