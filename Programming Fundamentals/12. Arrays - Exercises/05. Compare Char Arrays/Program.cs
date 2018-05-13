using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Compare_Char_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] arr1 = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            char[] arr2 = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            int length = Math.Min(arr1.Length, arr2.Length);

            for (int i = 0; i < length; i++)
            {
                if (arr1[i] < arr2[i])
                {

                }
            }


        }
    }
}
