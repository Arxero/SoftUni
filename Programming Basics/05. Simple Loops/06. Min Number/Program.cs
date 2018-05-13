using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Min_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberToRead = int.Parse(Console.ReadLine());

            int maxNumber = int.MaxValue;
            for (int i = 0; i < numberToRead; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                if (currentNumber < maxNumber)
                {
                    maxNumber = currentNumber;
                    Console.WriteLine(maxNumber);
                }
            }
        }
    }
}
