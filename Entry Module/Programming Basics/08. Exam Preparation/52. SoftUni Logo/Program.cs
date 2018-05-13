using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _52.SoftUni_Logo
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); // 12:30

            int height = 4 * n - 2;
            int width = 12 * n - 5;

            //firts row
            Console.WriteLine("{0}#{0}", new string('.', (width - 1) / 2));

            //second and bellow
            int dots = (width - 7) / 2;
            int num = 7;
            for (int top = 0; top < (n * 2) - 1; top++)
            {
                Console.WriteLine("{0}{1}{0}", new string('.', dots), new string('#', num));
                num += 6;
                dots -= 3;
            }

            // midd
            int dotsBott = 5;
            int numBott = width - 12;
            int dotsBott2 = 6;
            Console.WriteLine("|{0}{1}{2}", new string('.', 2), new string('#', width - 6), new string('.', 3));

            for (int bott = 0; bott < (height - ((n * 2) - 1) - (n - 1)) - 3; bott++)
            {
                Console.WriteLine("|{0}{1}{2}", new string('.', dotsBott), new string('#', numBott), new string('.', dotsBott2));
                dotsBott += 3;
                numBott -= 6;
                dotsBott2 += 3;
            }
            for (int final = 0; final < n - 1; final++)
            {
                Console.WriteLine("|{0}{1}{2}", new string('.', dotsBott), new string('#', numBott), new string('.', dotsBott2));

            }
            Console.WriteLine("@{0}{1}{2}", new string('.', dotsBott), new string('#', numBott), new string('.', dotsBott2));


        }
    }
}
