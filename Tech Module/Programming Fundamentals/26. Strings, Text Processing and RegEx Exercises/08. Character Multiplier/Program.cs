using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Character_Multiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            //string[] input = "Gosho Pesho".Split();

            char[] first = input[0].ToCharArray();
            char[] second = input[1].ToCharArray();
            int sum = 0;

            int minLength = Math.Min(first.Length, second.Length);
            int maxLength = Math.Max(first.Length, second.Length);

            //when they are equal
            for (int i = 0; i < minLength; i++)
            {
                sum += first[i] * second[i];
            }

            //when they are not equal
            if (first.Length == maxLength)
            {
                //here we start from the above cycle and we sum what is left
                for (int i = minLength; i < maxLength; i++)
                {
                    sum += first[i];
                }
            }
            else if (second.Length == maxLength)
            {
                for (int i = minLength; i < maxLength; i++)
                {
                    sum += second[i];
                }
            }
            Console.WriteLine(sum);
        }
    }
}
