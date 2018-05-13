using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Sunglasses
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            //top
            for (int leftGlass = 0; leftGlass < 2 * n; leftGlass++)
            {
                Console.Write("*");
            }
            for (int between = 0; between < n; between++)
            {
                Console.Write(" ");
            }
            for (int rightGlass = 0; rightGlass < 2 * n; rightGlass++)
            {
                Console.Write("*");
            }
            Console.WriteLine();

            //left glass
            for (int leftGlass = 0; leftGlass < n-2; leftGlass++)
            {
                Console.Write("*");
                for (int leftGlassForwardSlash = 0; leftGlassForwardSlash < 2*n-2; leftGlassForwardSlash++)
                {
                    Console.Write("/");
                }
                Console.Write("*");

                // middle part
                if (leftGlass == (n - 1) / 2 - 1)
                {
                    for (int pipe = 0; pipe < n; pipe++)
                    {
                        Console.Write("|");
                    }
                }
                else
                {
                    for (int emptySpace = 0; emptySpace < n; emptySpace++)
                    {
                        Console.Write(" ");
                    }
                }
                //right glass
                Console.Write("*");
                for (int rightGlassForwardSlash = 0; rightGlassForwardSlash < 2*n-2; rightGlassForwardSlash++)
                {
                    Console.Write("/");
                }
                Console.Write("*");
                Console.WriteLine();
            }

            //bottom
            for (int leftGlass = 0; leftGlass < 2 * n; leftGlass++)
            {
                Console.Write("*");
            }
            for (int between = 0; between < n; between++)
            {
                Console.Write(" ");
            }
            for (int rightGlass = 0; rightGlass < 2 * n; rightGlass++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}
