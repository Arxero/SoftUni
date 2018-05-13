using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Rhombus_of_Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            //top
            for (int row = 1; row <= size; row++)
            {
                for (int col = 1; col <= size - row; col++)
                {
                    Console.Write(" ");
                }
                Console.Write("*");
                for (int col = 1; col < row; col++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }
            //bottom
            for (int row = size -1; row > 0; row--)
            {
                for (int space = 0; space < size - row; space++)
                {
                    Console.Write(" ");
                }
                Console.Write("*");
                for (int combination = 0; combination < row -1; combination++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();

            }
        }
    }
}
