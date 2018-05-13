using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Square_of_Starss
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            for (int curretnRow = 1; curretnRow <= size; curretnRow++)
            {
                for (int currentCol = 0; currentCol < curretnRow; currentCol++)
                {
                    Console.Write("$ ");
                }
                Console.WriteLine();
            }
        }
    }
}
