using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _70.Crown
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); // 4:02

            int width = (2 * n) - 1;
            int height = (n / 2) + 4;

            //firs row
            Console.WriteLine("@{0}@{0}@", new string (' ' ,(width - 3) / 2));
            //second
            Console.WriteLine("**{0}*{0}**", new string (' ', (width - 5) / 2));
            //bellow
            int dots = 1;
            int dotsMid = 1;
            int empty = (width - 9) / 2;
            for (int top = 0; top < height - 6; top++)
            {
                Console.WriteLine("*{0}*{1}*{2}*{1}*{0}*", new string('.', dots), new string(' ', empty), new string('.', dotsMid));
                dots++;
                dotsMid += 2;
                empty -= 2;
            }
            //bellow mid
            Console.WriteLine("*{0}*{1}*{0}*", new string('.', dots), new string ('.', (width - (dots * 2)) - 4));
            Console.WriteLine("*{0}{1}.{1}{0}*", new string ('.', dots + 1), new string ('*', ((width - (dots * 2)) - 5) / 2));
            //last two
            Console.WriteLine("{0}", new string ('*', width));
            Console.WriteLine("{0}", new string ('*', width));
        }
    }
}
