using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Text_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] bannedWords = Console.ReadLine().Split(new[] {", "},StringSplitOptions.RemoveEmptyEntries).ToArray();
            string input = Console.ReadLine();

            for (int i = 0; i < bannedWords.Length; i++)
            {
                int bannedWordLength = bannedWords[i].Length;
                if (input.Contains(bannedWords[i]))
                {
                    input = input.Replace(bannedWords[i], new string('*', bannedWordLength));
                }
            }
            Console.WriteLine(input);
        }
    }
}
