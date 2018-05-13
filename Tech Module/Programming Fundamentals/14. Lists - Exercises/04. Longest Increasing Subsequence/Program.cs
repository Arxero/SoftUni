using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main()
    {
        var sequence = Console.ReadLine().Split().Select(int.Parse).ToList();


        int[] length = new int[sequence.Count];
        int[] prev = new int[sequence.Count];
        int maxLength = 0;
        int lastIndex = -1;

        for (int i = 0; i < sequence.Count; i++)
        {
            length[i] = 1;
            prev[i] = -1;

            for (int j = 0; j < i; j++)
            {
                //if 3 > 7 and 
                if (sequence[i] > sequence[j] && length[j] >= length[i])
                {
                    length[i] = 1 + length[j];
                    prev[i] = j;
                }
            }

            if (length[i] > maxLength)
            {
                maxLength = length[i];
                lastIndex = i;
            }
        }

        var longestSeq = new List<int>();
        for (int i = 0; i < maxLength; i++)
        {
            longestSeq.Add(sequence[lastIndex]);
            lastIndex = prev[lastIndex];
        }

        longestSeq.Reverse();

        Console.WriteLine("{0}", string.Join(" ", longestSeq));
    }

}