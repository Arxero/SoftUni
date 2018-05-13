using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _26.Query_Mess
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"([^&?=\s]*)=([^&?=\s]*)";
            string spacePattern = @"((%20|\+)+)";

            while (input != "END")
            {
                MatchCollection matches = Regex.Matches(input, pattern);

                Dictionary<string, List<string>> results = new Dictionary<string, List<string>>();

                for (int i = 0; i < matches.Count; i++)
                {
                    string field = matches[i].Groups[1].Value;
                    field = Regex.Replace(field, spacePattern, " ").Trim();

                    string value = matches[i].Groups[2].Value;
                    value = Regex.Replace(value, spacePattern, " ").Trim();

                    if (!results.ContainsKey(field))
                    {
                        //here we are fiilling the list in dictionary
                        List<string> values = new List<string>();
                        values.Add(value);
                        // and here we are adding what the dictinary will contain 
                        results.Add(field, values);
                    }
                    else
                    {
                        results[field].Add(value);
                    }
                }
                input = Console.ReadLine();

                foreach (var result in results)
                {
                    Console.Write($"{result.Key}=[{string.Join(", ", result.Value)}]");
                }
                Console.WriteLine();
            }
            
        }
    }
}
