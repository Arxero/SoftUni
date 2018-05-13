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
            int rightSum = 0;
            for (int i = 0; i < numbersToRead * 2; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());

                if (i < numbersToRead)
                {
                    leftSum += currentNumber;
                }
                else
                {
                    rightSum += currentNumber;
                }
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