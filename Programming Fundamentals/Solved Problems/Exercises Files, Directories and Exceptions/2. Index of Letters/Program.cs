using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Index_of_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] array = new char[26];

            int i = 0;
            char ch = 'a';
            for (; i < array.Length; i++, ch++)
            {
                array[i] = ch;
            }

            string input = File.ReadAllText("input.txt");
            for (i = 0; i < input.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    if (input[i] == array[j])
                    {
                        File.AppendAllText("output.txt", input[i] + " -> " + j + Environment.NewLine);
                    }
                }
            }
        }
    }
}
