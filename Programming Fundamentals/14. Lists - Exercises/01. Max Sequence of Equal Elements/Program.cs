using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            //list.Reverse();

            int currentCount = 1;
            int maxCount = 0;
            int currentDigit = 1;
            int maxDigit = 0;

            for (int i = 1; i < list.Count; i++)
            {
                if (list[i] == list[i - 1])
                {
                    currentCount++;
                    //maxCount = list[i];
                    if (currentCount > currentDigit)
                    {
                        currentDigit = currentCount;
                        maxDigit = maxCount;
                    }
                }
                else
                {
                    if (currentCount > currentDigit)
                    {
                        currentDigit = currentCount;
                        maxDigit = maxCount;
                    }
                    maxCount = i;
                    currentCount = 1;
                }
            }
            for (int i = maxDigit; i < currentDigit + maxDigit; i++)
            {
                Console.Write($"{list[i]} ");
            }
            Console.WriteLine();
        }
    }
}
