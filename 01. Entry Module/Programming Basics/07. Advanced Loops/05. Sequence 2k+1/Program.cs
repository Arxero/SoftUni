using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Sequence_2k_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxNumber = int.Parse(Console.ReadLine());

            int currentNumber = 1;
            while (currentNumber <= maxNumber)
            {
                //TODO:
                Console.WriteLine(currentNumber);
                currentNumber = currentNumber * 2 + 1;

            }
        }
    }
}
