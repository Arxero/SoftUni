using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Draw_Fort
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); // 6:00

            int width = 2 * n;
            int height = n;
            int midDashes = width - 4 - 2 * (n / 2);

            //first row
                Console.WriteLine(@"/{0}\{1}/{0}\", new string('^', n / 2), new string('_', midDashes));

            //sedond and bellow
            for (int firstRow = 1; firstRow < n - 2; firstRow++)
            {
                Console.WriteLine("|{0}|", new string (' ', width - 2));
            }

            // bottom
            Console.WriteLine(@"|{0}{1}{0}|", new string (' ', (n / 2) + 1), new string ('_', midDashes));
            //last row
            Console.WriteLine(@"\{0}/{1}\{0}/", new string ('_', n / 2), new string (' ', midDashes));
        }
    }
}
