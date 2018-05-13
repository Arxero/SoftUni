using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbersToRead = int.Parse(Console.ReadLine());

            // for loop for leftSum
            int leftSum = 0;
            for (int i = 0; i < numbersToRead; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                leftSum += currentNumber;
            }

            // for loop for rightSum
            int rightSum = 0;
            for (int i = 0; i < numbersToRead; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                rightSum += currentNumber;
            }

            if (leftSum == rightSum)
            {
                Console.WriteLine($"Yes, sum = {leftSum}");
            }
            else
            {
                Console.WriteLine($"No, diff = {Math.Abs(leftSum - rightSum)}");
            }
        }
    }
}