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

            int rows = size + 1;

            for (int currentRows = 0; currentRows < rows; currentRows++)
            {
                string emptySpaces = new string(' ', size - currentRows);
                string asterisk = new string('*', currentRows);

                Console.WriteLine("{0}{1}{2}{1}", emptySpaces, asterisk, " | ");
            }

        }
    }
}
