using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Draw_Fort
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int width = 2 * n;
            int upArrow = n / 2;
            int underscores = 2*n -4 - 2*(n / 2);

            //top
            Console.WriteLine(@"/{0}\{1}/{0}\", new string('^', upArrow), new string ('_', underscores));

            //middle
            for (int col = 0; col < n - 3; col++)
            {
                for (int row = 0; row < width; row++)
                {
                    if (row == 0 || row == width -1)
                    {
                        Console.Write('|');
                    }
                    else
                    {
                        Console.Write(' ');
                    }
                }
                Console.WriteLine();
            }
            //bottom
            Console.WriteLine(@"|{0}{1}{0}|", new string(' ', upArrow + 1), new string('_', underscores));
            Console.WriteLine(@"\{0}/{1}\{0}/", new string ('_', upArrow), new string (' ', underscores));
        }
    }
}
