using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Number_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxNumber = int.Parse(Console.ReadLine());

            for (int currentRow = 1; currentRow <= maxNumber; currentRow++)
            {
                for (int currentLeftNumber = currentRow; currentLeftNumber <= maxNumber; currentLeftNumber++)
                {
                    Console.Write($"{currentLeftNumber}");
                }

                for (int currentRightNumber = maxNumber; currentRightNumber < currentRow; currentRightNumber--)
                {
                    Console.Write($"{currentRightNumber}");
                }
                Console.WriteLine();
            }
        }
    }
}
