using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Fold_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int[] firstK = new int[input.Length / 4];
            int[] midK = new int[input.Length / 2];
            int[] secondK = new int[input.Length / 4];

            //getting the first K
            for (int i = 0; i < input.Length / 4; i++)
            {
                firstK[i] = input[i];
            }
            Array.Reverse(firstK);

            //getting the midpart
            for (int i = input.Length / 4; i < input.Length / 2 + (input.Length / 4); i++)
            {
                midK[i - input.Length / 4] = input[i];
            }

            //getting the second K
            for (int i = 0; i < input.Length / 4; i++)
            {
                secondK[i] = input[input.Length - 1 - i];
            }
            //no need of revers as of this above get it in backwards
            //Array.Reverse(secondK);

            //fiiling up secondK in the first for easy sum later
            int[] firstPlusSecondK = new int[midK.Length];
            for (int i = 0; i < firstK.Length; i++)
            {
                firstPlusSecondK[i] = firstK[i];
            }
            for (int i = 0; i < secondK.Length; i++)
            {
                firstPlusSecondK[i + input.Length / 4] = secondK[i];
            }

            //sum
            int[] sum = new int[midK.Length];
            for (int i = 0; i < midK.Length; i++)
            {
                sum[i] = firstPlusSecondK[i] + midK[i];
            }

            Console.WriteLine(string.Join(" ", sum));


        }

    }
}
