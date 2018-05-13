using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22.Diamond
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); // 6:45

            int width = 5 * n;
            int height = 3 * n + 2;
            int outsideDots = n - 1;
            int insideODts = width - 2 * n;
            int insideDotsBott = width - 4;
            int outsideDotsBott = 1;


            // first row
            Console.WriteLine("{0}{1}{0}", new string ('.', n), new string ('*' , width - 2 * n));

            //second and bellow
            for (int top = 0; top < n - 1; top++)
            {
                Console.WriteLine("{0}*{1}*{0}", new string('.', outsideDots), new string('.', insideODts));
                outsideDots--;
                insideODts += 2;
            }
            // mid
            Console.WriteLine(new string ('*', width));

            //second half
            for (int bot = 0; bot < n * 2; bot++)
            {
                Console.WriteLine("{0}*{1}*{0}", new string('.', outsideDotsBott), new string('.', insideDotsBott));
                outsideDotsBott++;
                insideDotsBott -= 2;

            }
            //last row
            Console.WriteLine("{0}{1}{0}", new string ('.', outsideDotsBott), new string ('*', insideDotsBott + 2));
        }
    }
}
