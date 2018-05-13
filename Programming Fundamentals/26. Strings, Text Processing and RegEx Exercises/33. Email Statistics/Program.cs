using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _33.Email_Statistics
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            Dictionary<string, List<string>> result = new Dictionary<string, List<string>>();

            for (int i = 0; i < count; i++)
            {
                string input = Console.ReadLine();
                string pattern = @"^([a-zA-Z]{5,})@([a-z]{3,}\.(com|bg|org))$";
                Match emails = Regex.Match(input, pattern);

                string username = emails.Groups[1].Value;
                string domain = emails.Groups[2].Value;

                if (emails.Success)
                {
                    if (!result.ContainsKey(domain))
                    {
                        List<string> values = new List<string>();
                        values.Add(username);
                        result.Add(domain, values);
                    }
                    else
                    {
                        if (!result[domain].Contains(username))
                        {
                            result[domain].Add(username);
                        }
                    }
                }
            }
            foreach (var domainAndUsername in result.OrderByDescending(x => x.Value.Count))
            {
                Console.WriteLine($"{domainAndUsername.Key}:");
                foreach (var user in domainAndUsername.Value)
                {
                    Console.WriteLine($"### {user}");
                }
            }
        }
    }
}
