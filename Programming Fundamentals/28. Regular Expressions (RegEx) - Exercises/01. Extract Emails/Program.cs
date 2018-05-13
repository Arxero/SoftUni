using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _01.Extract_Emails
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"(?<=\s)[a-z]+\.*(-*)\w+\.*-*_*@\w+\.*-*\w*\.*\w+\.\w+";

            var regex = Regex.Matches(input, pattern);

            foreach (var email in regex)
            {
                Console.WriteLine(email);
            }
        }
    }
}
