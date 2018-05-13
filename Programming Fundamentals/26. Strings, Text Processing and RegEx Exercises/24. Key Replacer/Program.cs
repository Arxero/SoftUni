using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _24.Key_Replacer
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string inpu2 = Console.ReadLine();

            string startKeyPattern = @"^[a-zA-Z]+(?=\||\<|\\)";
            string endKeyPattern = @"(?<=\||\<|\\)[a-zA-Z]+$";

            Match startKey = Regex.Match(input, startKeyPattern);
            Match endKey = Regex.Match(input, endKeyPattern);

            string pattern = $@"(?<={startKey})[a-zA-Z]*?(?={endKey})";
            MatchCollection words = Regex.Matches(inpu2, pattern);
            string sum = "";

            foreach (Match word in words)
            {
                sum += word;
            }
            if (sum != "")
            {
                Console.WriteLine(sum);
            }
            else
            {
                Console.WriteLine("Empty result");
            }
        }
    }
}
