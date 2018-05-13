using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20.Equal_Sums
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int leftSum = 0;
            int rightSum = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (input.Length == 1)
                {
                    Console.WriteLine("0");
                    return;
                }

                //turn left
                leftSum = 0; // we making it 0 cause we nee to chek always the new sum of both
                for (int left = i ; left > 0; left--)
                {
                    int next = left - 1;
                    if (left > 0)
                    {
                        leftSum += input[next];
                    }
                }
                //turn right
                rightSum = 0;
                for (int right = i; right < input.Length; right++)
                {
                    int next = right + 1;
                    if (right < input.Length - 1)
                    {
                        rightSum += input[next];
                    }
                }

                if (leftSum == rightSum)
                {
                    Console.WriteLine(i);
                    return;
                }
            }
            Console.WriteLine("no");
        }
    }
}
