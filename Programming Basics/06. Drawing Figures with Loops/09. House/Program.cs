using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.House
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int countMiddleSymbols = 1;

            if (n % 2 == 0)
            {
                countMiddleSymbols = 2;
            }
            int dashes = (n - countMiddleSymbols) / 2;

            string rowToFormat = "{0}{1}{0}";
            int rowOfRoof = (n + 1) / 2;

            //roof
            for (int currentRow = 0; currentRow < rowOfRoof; currentRow++)
            {
                for (int i = 0; i < dashes; i++)
                {
                    Console.Write("-");
                }
                for (int i = 0; i < countMiddleSymbols; i++)
                {
                    Console.Write("*");
                }
                for (int i = 0; i < dashes; i++)
                {
                    Console.Write("-");
                }
                dashes--;
                countMiddleSymbols += 2;
                Console.WriteLine();
            }
            //body
            for (int currentRow = 0; currentRow < n / 2; currentRow++)
            {
                Console.Write("|");
                for (int asterisk = 0; asterisk < n - 2; asterisk++)
                {
                    Console.Write("*");
                }
                Console.Write("|");
                Console.WriteLine();
            }

        }
    }
}
