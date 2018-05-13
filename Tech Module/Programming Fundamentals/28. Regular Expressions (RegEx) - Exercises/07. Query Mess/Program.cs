using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _07.Query_Mess
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string pattern = @"([^&?]+)=([^&?]+)";
            string patternSpace = @"(%20|\+)+";

            while (input != "END")
            {
                var regex = Regex.Matches(input, pattern);
                var keyHolder = new Dictionary<string, List <string>>();

                for (int i = 0; i < regex.Count; i++)
                {
                    string key = regex[i].Groups[1].Value;
                    key = Regex.Replace(key, patternSpace, word => " ").Trim();
                    

                    string value = regex[i].Groups[2].Value;
                    value = Regex.Replace(value, patternSpace, word => " ").Trim();

                    if (!keyHolder.ContainsKey(key))
                    {
                        keyHolder[key] = new List<string>();
                    }

                    keyHolder[key].Add(value);
                }
                foreach (var item in keyHolder)
                {
                    Console.Write($"{item.Key}=[{string.Join(", ", item.Value)}]");
                }
                Console.WriteLine();

                input = Console.ReadLine();
            }
        }
    }
}
