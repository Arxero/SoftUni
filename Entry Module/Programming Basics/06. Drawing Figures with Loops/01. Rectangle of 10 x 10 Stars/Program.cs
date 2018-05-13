using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Rectangle_of_10_x_10_Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            for (int currentRow = 0; currentRow < size; currentRow++)
            {
                for (int currentCol = 0; currentCol < size; currentCol++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
