using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _21.Extract_Sentences_by_Keyword
{
    class Program
    {
        static void Main(string[] args)
        {
            string keyword = Console.ReadLine();
            
            string[] input = Console.ReadLine().Split(new string[] {".", "!", "?"},StringSplitOptions.None).ToArray();
            string pattern = $@"\b{keyword}\b";

            for (int i = 0; i < input.Length - 1; i++)
            {
                MatchCollection sentences = Regex.Matches(input[i], pattern);

                foreach (Match sentence in sentences)
                {
                    Console.WriteLine(input[i].TrimStart());
                }
            }
        }
    }
}
