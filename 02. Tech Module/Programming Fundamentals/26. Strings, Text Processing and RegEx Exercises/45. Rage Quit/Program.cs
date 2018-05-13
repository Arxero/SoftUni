using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _45.Rage_Quit
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToUpper();
            string pattern = @"([^0-9]+?)(?=[0-9])([0-9]+)";

            StringBuilder result = new StringBuilder();
            MatchCollection rage = Regex.Matches(input, pattern);

            foreach (Match quit in rage)
            {
                int number = int.Parse(quit.Groups[2].Value);
                for (int i = 0; i < number; i++)
                {
                    result.Append(quit.Groups[1].Value.ToString());
                }
            }

            var uniqueSymbols = result.ToString().Distinct();
            Console.WriteLine($"Unique symbols used: {uniqueSymbols.Count()}");
            Console.WriteLine(result);
        }
    }
}
