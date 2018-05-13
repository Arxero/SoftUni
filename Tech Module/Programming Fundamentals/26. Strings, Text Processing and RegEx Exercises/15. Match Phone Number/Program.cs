using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _15.Match_Phone_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"[+][359]+(\s|-)[2]\1[0-9]{3}\1[0-9]{4}\b";
            string input = Console.ReadLine();

            MatchCollection numbers = Regex.Matches(input, pattern);
            List<string> result = new List<string>();

            foreach (Match number in numbers)
            {
                result.Add(number.Value);
            }
            Console.WriteLine(string.Join(", ", result));
        }
    }
}
