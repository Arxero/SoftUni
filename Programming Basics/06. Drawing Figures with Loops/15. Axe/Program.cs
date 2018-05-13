using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Axe
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); // 3:47

            int width = 5 * n;
            int insideDash = 1;
            int rightSideDashe = (5 * n) - (3 * n) - 3;
            int rightSideDashe2 = n - 1;
            int leftSideDashe = 3 * n;
            int midDashe = n - 1;
            //double lastDashe = Math.Ceiling (n / 2.0);
            //double lastRowDashe = (width + lastDashe) / 2.0;
            //int lastRowDashe2 = (int)(Math.Ceiling(lastRowDashe));

            // first row
            Console.WriteLine("{0}**{1}", new string ('-', 3 * n), new string ('-', (5 * n) - (3 * n) - 2));

            //second and bellow
            for (int topRows = 0; topRows < n - 1; topRows++)
            {
                Console.WriteLine("{0}*{1}*{2}", new string('-', 3 * n), new string('-', insideDash), new string('-', rightSideDashe));
                insideDash++;
                rightSideDashe--;
            }

            //midd
            for (int midRows = 0; midRows < n / 2; midRows++)
            {
                Console.WriteLine("{0}{1}*{2}", new string('*', 3 * n + 1), new string('-', n - 1), new string('-', n - 1));
            }

            //bellow mid
            for (int bottomRows = 0; bottomRows < n / 2 - 1; bottomRows++)
            {
                Console.WriteLine("{0}*{1}*{2}", new string('-', leftSideDashe), new string('-', midDashe), new string('-', rightSideDashe2));
                leftSideDashe--;
                midDashe += 2;
                rightSideDashe2--;
            }

            // last row
            Console.WriteLine("{0}*{1}*{2}", new string('-', leftSideDashe), new string('*', midDashe), new string('-', rightSideDashe2));
            //Console.WriteLine("{0}{1}{2}", new string ('-', lastRowDashe2), new string ('*', width - (int)lastRowDashe2 - (int)lastDashe), new string ('-', (int)lastDashe));
            //Console.WriteLine("{0}{1}{2}", new string ('-', lastRowDashe2), new string ('*', width - (int)lastRowDashe2 - (int)lastDashe), new string ('-', (int)lastDashe));
        }
    }
}
