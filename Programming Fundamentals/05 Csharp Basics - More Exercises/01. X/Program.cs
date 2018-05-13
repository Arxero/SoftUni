using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.X
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int empty = n - 2;
            int emptyOnside = 0;
            //top
            for (int top = 0; top < n / 2; top++)
            {
                Console.WriteLine("{1}x{0}x{1}", new string(' ', empty), new string(' ', emptyOnside));
                empty -= 2;
                emptyOnside += 1;
            }
            //mid
            Console.WriteLine("{0}x{0}", new string (' ', n / 2));
            //bott
            int emptyBott = 1;
            int emptyOnSideBott = (n - 3) / 2;
            for (int bott = 0; bott < n / 2; bott++)
            {
                Console.WriteLine("{1}x{0}x{1}", new string(' ', emptyBott), new string(' ', emptyOnSideBott));
                emptyBott += 2;
                emptyOnSideBott -= 1;
            }
        }
    }
}
