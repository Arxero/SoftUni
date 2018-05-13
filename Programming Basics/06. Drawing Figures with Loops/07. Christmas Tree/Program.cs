using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07._1.Christmas_Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            string space = " ";
            string asterisk = "*";
            int rows = size + 1;

            for (int currentRow = 0; currentRow < rows; currentRow++)
            {
                for (int currentWhiteSpace = 0; currentWhiteSpace < size - currentRow; currentWhiteSpace++)
                {
                    Console.Write(space);
                }
                for (int currentAsterisk = 0; currentAsterisk < currentRow; currentAsterisk++)
                {
                    Console.Write(asterisk);
                }
                Console.Write(" | ");

                for (int currentAsterisk = 0; currentAsterisk < currentRow; currentAsterisk++)
                {
                    Console.Write(asterisk);
                }

                Console.WriteLine();
            }



        }
    }
}
