using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.Index_of_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] input = Console.ReadLine().ToCharArray();
            char[] alphabet = new char[26];
            int iReplacer = 0;

            //making an array of the alphabet
            for (int i = 97; i <= 122; i++)
            {
                alphabet[iReplacer] = (char)i;
                iReplacer++;
            }

            for (int i = 0; i < input.Length; i++)
            {
                    Console.WriteLine($"{input[i]} -> {Array.IndexOf(alphabet, input[i])}");
            }
        }
    }
}
