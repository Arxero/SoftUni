using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Palindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine()
                .Split(new char[] { ',', ' ', '.', '?', '!' }, StringSplitOptions
                .RemoveEmptyEntries)
                .OrderBy(t => t)
                .ToArray();

            var palindroms = new List<string>();

            for (int i = 0; i < text.Length; i++)
            {
                var reversed = new string(text[i].Reverse().ToArray());

                if (text[i] == reversed && !palindroms.Contains(text[i]))
                {
                    palindroms.Add(text[i]);
                }
            }
            Console.WriteLine(string.Join(", ", palindroms));
        }
    }
}
