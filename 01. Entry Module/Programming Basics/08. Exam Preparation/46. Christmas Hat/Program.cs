using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _46.Christmas_Hat
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); // 6:54

            int width = 4 * n + 1;
            int height = 2 * n + 5;

            //top
            Console.WriteLine(@"{0}/|\{0}", new string ('.', (width - 3) / 2));
            Console.WriteLine(@"{0}\|/{0}", new string ('.', (width - 3) / 2));
            // mid
            int dots = (width - 3) / 2;
            int dashes = 0;
            for (int top = 0; top < 2 * n; top++)
            {
                Console.WriteLine("{0}*{1}*{1}*{0}", new string('.', dots), new string('-', dashes));
                dots--;
                dashes += 1;
            }
            //bott
            Console.WriteLine("{0}", new string ('*', width));

            //between
            for (int bott = 0; bott < width / 2; bott++)
            {
                Console.Write("*.");
                
            }
            Console.Write("*");
            Console.WriteLine();

            //last row
            Console.WriteLine("{0}", new string('*', width));

        }
    }
}
