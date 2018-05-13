using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _18.Match_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(^|(?<=\s))-?([0-9]+)(\.?[0-9]+)?($|(?=\s))";
            string input = Console.ReadLine();
            List<string> result = new List<string>();

            MatchCollection numbers = Regex.Matches(input, pattern);

            foreach (Match number in numbers)
            {
                result.Add(number.Value);
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
