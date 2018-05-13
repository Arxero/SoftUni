using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            
            int count = 1;
            int maxCount = 0;
            int start = 0;

            for (int i = 0; i < input.Length - 1; i++)
            {
                if (input[i] == input[i + 1])
                {
                    count++;
                    if (count > maxCount)
                    {
                        //keeping how long  is the sequence of equal
                        maxCount = count;
                        //find out what is the value of equal sequence
                        start = input[i];
                    }
                }
                else
                {
                    count = 1;
                }
            }
            //mkaing a new array for the result
            int[] result = new int[maxCount];

            //filling up the new array
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = start;
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
