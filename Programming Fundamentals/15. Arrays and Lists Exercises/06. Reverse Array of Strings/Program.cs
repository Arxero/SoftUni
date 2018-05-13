using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Reverse_Array_of_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split().ToArray();
            string[] reversed = new string[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                string lastElement = input[input.Length - 1 - i];
                reversed[i] = lastElement;
                Console.Write(reversed[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
