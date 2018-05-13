using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _16.Match_Hexadecimal_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\b((?:0x)|[0-9A-F])+\b";
            string input = Console.ReadLine();
            List<string> result = new List<string>();

            MatchCollection matches = Regex.Matches(input, pattern);
            foreach (Match hexa in matches)
            {
                result.Add(hexa.Value);
            }
            Console.WriteLine(string.Join(" ",result));
        }
    }
}
