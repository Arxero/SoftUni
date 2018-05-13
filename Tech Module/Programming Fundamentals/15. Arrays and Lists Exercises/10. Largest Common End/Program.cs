using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Largest_Common_End
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split().ToArray();
            string[] input2 = Console.ReadLine().Split().ToArray();
            int minLength = Math.Min(input.Length, input2.Length);
            int right = 0;
            int left = 0;

            for (int i = 0; i < minLength; i++)
            {
                if (input[i] == input2[i])
                {
                    right++;
                }
                // we are adding -i as well because it will check only last element always
                else if (input[input.Length - 1 - i] == input2[input2.Length - 1 - i])
                {
                    left++;
                }
            }
            Console.WriteLine(Math.Max(right, left));
        }
    }
}
