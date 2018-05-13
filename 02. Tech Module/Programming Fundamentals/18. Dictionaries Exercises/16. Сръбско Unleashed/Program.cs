using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _16.Сръбско_Unleashed
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, Dictionary<string, long>> results = new Dictionary<string, Dictionary<string, long>>();
            string pattern = @"((?:[a-zA-Z]+\s){1,3})@((?:[a-zA-Z]+\s){1,3})(\d+)\s(\d+)";

            while (input != "End")
            {
                Match match = Regex.Match(input, pattern);

                if (match.Success)
                {
                    string singer = match.Groups[1].Value.TrimEnd();
                    string venue = match.Groups[2].Value.TrimEnd();
                    long price = long.Parse(match.Groups[3].Value);
                    long count = long.Parse(match.Groups[4].Value);
                    long money = price * count;

                    if (!results.ContainsKey(venue))
                    {
                        results.Add(venue, new Dictionary<string, long>());
                        results[venue].Add(singer, money);
                    }
                    else
                    {
                        if (!results[venue].ContainsKey(singer))
                        {
                            results[venue].Add(singer, money);
                        }
                        else
                        {
                            results[venue][singer] += money;
                        }
                    }
                }
                input = Console.ReadLine();
            }
            foreach (var result in results)
            {
                Console.WriteLine($"{result.Key}");
                foreach (var singer in result.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"#  {singer.Key} -> {singer.Value}");
                }
            }
        }
    }
}
