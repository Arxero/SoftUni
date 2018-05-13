using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Largest_Common_End
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstArr = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string[] secondArr = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            int leftCount = GetMaxCommonItems(firstArr, secondArr);
            Array.Reverse(firstArr);
            Array.Reverse(secondArr);
            int rightCount = GetMaxCommonItems(firstArr, secondArr);
            Console.WriteLine($"{Math.Max(leftCount, rightCount)}");

        }
        static int GetMaxCommonItems(string[] firstArr, string[] secondArr)
        {
            int length = Math.Min(firstArr.Length, secondArr.Length);
            int counter = 0;
            for (int i = 0; i < length; i++)
            {
                if (firstArr[i] == secondArr[i])
                {
                    counter++;
                }
                else
                {
                    break;
                }
            }
            return counter;
        }

    }
}
