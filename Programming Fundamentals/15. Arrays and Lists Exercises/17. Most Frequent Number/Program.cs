using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.Most_Frequent_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int count = 1;
            int maxCount = 0;
            int ocuranceValue = 0;
            int valueKeeper = 0;

            //checking if the number is only one
            if (input.Length == 1)
            {
                valueKeeper = input[0];
            }

            for (int i = 0; i < input.Length - 1; i++)
            {
                //ocuranceValue = input[i];
                for (int k = 1; k < input.Length - i; k++)
                {
                    if (input[i] == input[k + i])
                    {
                        count++;
                    }

                    if (count > maxCount)
                    {
                        maxCount = count;
                        valueKeeper = input[i];
                    }
                }
                count = 1;
            }
            Console.WriteLine(valueKeeper);
        }
    }
}
