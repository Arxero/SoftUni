using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _28.Censorship
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            string input = Console.ReadLine();
            string pattern = $@"{word}";

            input = Regex.Replace(input, pattern, new string('*', word.Length));
            Console.WriteLine(input);
        }
    }
}
