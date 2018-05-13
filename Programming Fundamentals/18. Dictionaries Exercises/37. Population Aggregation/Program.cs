using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _37.Population_Aggregation
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, Dictionary<string, long>> results = new Dictionary<string, Dictionary<string, long>>();
            Dictionary<string, List<string>> cities = new Dictionary<string, List<string>>();

            while (input != "stop")
            {
                string[] splitter = input.Split(new[] { "\\" }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                string pattern = @"[^@|#|$|&|\\|0-9]";
                string[] match = Regex.Matches(splitter[0], pattern).Cast<Match>().Select(x => x.Value).ToArray();
                string[] match2 = Regex.Matches(splitter[1], pattern).Cast<Match>().Select(x => x.Value).ToArray();
                string wordOneCleaned = string.Join("", match);
                string wordTwoCleaned = string.Join("", match2);
                string country = "";
                string city = "";
                long population = long.Parse(splitter[2]);

                if (char.IsUpper(wordOneCleaned, 0))
                {
                    country = wordOneCleaned;
                    city = wordTwoCleaned;
                }
                else
                {
                    country = wordTwoCleaned;
                    city = wordOneCleaned;
                }

                if (!results.ContainsKey(country))
                {
                    results.Add(country, new Dictionary<string, long>());
                    results[country].Add(city, population);

                    //______________________________________
                    if (!cities.ContainsKey(country))
                    {
                        cities.Add(country, new List<string>());
                        cities[country].Add(city);
                    }
                    else
                    {
                        cities[country].Add(city);
                    }
                }
                else
                {
                    if (!results[country].ContainsKey(city))
                    {
                        results[country].Add(city, population);

                        //____________________________________________________
                        if (!cities.ContainsKey(country))
                        {
                            cities.Add(country, new List<string>());
                            cities[country].Add(city);
                        }
                        else
                        {
                            cities[country].Add(city);
                        }
                    }
                    else
                    {
                        results[country][city] = population;

                        //______________________________________________
                        if (!cities.ContainsKey(country))
                        {
                            cities.Add(country, new List<string>());
                            cities[country].Add(city);
                        }
                        else
                        {
                            cities[country].Add(city);
                        }

                    }
                }
                input = Console.ReadLine();
            }
            foreach (var city in cities.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{city.Key} -> {city.Value.Count}");
            }
            Dictionary<string, long> finalResults = new Dictionary<string, long>();

            foreach (var result in results)
            {
                foreach (var city in result.Value)
                {
                    finalResults.Add(city.Key, city.Value);
                }
            }
            long breaker = 0;
            foreach (var finalResult in finalResults.OrderByDescending(x => x.Value))
            {
                Console.WriteLine($"{finalResult.Key} -> {finalResult.Value}");
                breaker++;
                if (breaker == 3)
                {
                    break;
                }
            }
        }
    }
}
