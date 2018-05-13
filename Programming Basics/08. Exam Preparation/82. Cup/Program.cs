using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _82.Cup
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); // 10:24

            int width = 5 * n;

            int dots = n;
            int num = width - (n * 2);
            //top
            for (int top = 0; top < n / 2; top++)
            {
                Console.WriteLine("{0}{1}{0}", new string('.', dots), new string('#', num));
                dots++;
                num -= 2;
            }
            //bellow
            int dotsBellow = dots;
            int dotsBellowMid = num - 2;
            for (int bellow = 0; bellow < (n / 2) + 1; bellow++)
            {
                Console.WriteLine("{0}#{1}#{0}", new string('.', dotsBellow), new string('.', dotsBellowMid));
                dotsBellow++;
                dotsBellowMid -= 2;
            }
            //mid
            Console.WriteLine("{0}{1}{0}", new string ('.', dotsBellow - 1), new string ('#', width - ((dotsBellow -1) * 2)));
            //bellow mid
            int dotsBott = dotsBellow - 3;
            int numBott = width - (dotsBott * 2);
            for (int bott = 0; bott < n / 2; bott++)
            {
                Console.WriteLine("{0}{1}{0}", new string('.', dotsBott), new string('#', numBott));
            }
            //dance
            Console.WriteLine("{0}D^A^N^C^E^{0}", new string('.', (width - 10) / 2));

            //bott bott
            for (int bott = 0; bott < n / 2; bott++)
            {
                Console.WriteLine("{0}{1}{0}", new string('.', dotsBott), new string('#', numBott));
            }
            //last
            Console.WriteLine("{0}{1}{0}", new string('.', dotsBott), new string('#', numBott));

        }
    }
}
