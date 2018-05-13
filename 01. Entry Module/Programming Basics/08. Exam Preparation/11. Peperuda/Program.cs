using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Peperuda
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); // 7:10

            int width = 2 * n - 1;
            int height = 2 * (n - 2) + 1;
            int sides = n - 2;

            //first
            Console.WriteLine(@"{0}\ /{0}", new string('*', sides));

            //top
            for (int topHalf = 1; topHalf < n / 2; topHalf++)
            {
                Console.WriteLine(@"{0}\ /{0}", new string('-', sides));
                Console.WriteLine(@"{0}\ /{0}", new string('*', sides));
            }

            //mid
            Console.WriteLine("{0} @ {0}", new string (' ', sides));

            //bott
            for (int topHalf = 1; topHalf < n / 2; topHalf++)
            {
                Console.WriteLine(@"{0}/ \{0}", new string('*', sides));
                Console.WriteLine(@"{0}/ \{0}", new string('-', sides));
            }

            //lat row
            Console.WriteLine(@"{0}/ \{0}", new string('*', sides));

        }
    }
}
