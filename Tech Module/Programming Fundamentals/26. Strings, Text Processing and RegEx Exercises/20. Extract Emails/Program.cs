using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _20.Extract_Emails
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(?<=\s)([a-zA-Z0-9]+)(\.|-|_|)([[a-zA-Z0-9]+)((\.|-|_|)[a-zA-Z]+)?@(\w+\.?-?\w+)(\.?-?\w+)*\.\w+";
            string input = Console.ReadLine();

            MatchCollection emails = Regex.Matches(input, pattern);

            foreach (Match email in emails)
            {
                Console.WriteLine(email);
            }
        }
    }
}
