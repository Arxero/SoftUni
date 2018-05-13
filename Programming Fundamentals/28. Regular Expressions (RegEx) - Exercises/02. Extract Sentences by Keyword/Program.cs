using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _02.Extract_Sentences_by_Keyword
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            string pattern = @"\b[^.!?]+\b" + word + @"\b.*?($|(?=[.!?]))";
            string input = Console.ReadLine();

            var regex = Regex.Matches(input, pattern);

            foreach (var sentence in regex)
            {
                Console.WriteLine(sentence);
            }
        }
    }
}
