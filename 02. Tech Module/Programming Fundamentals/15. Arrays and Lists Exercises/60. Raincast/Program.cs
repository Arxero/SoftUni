using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _60.Raincast
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string patternType = @"Type:\s(Normal|Warning|Danger)";
            string patternSource = @"Source:\s([a-zA-Z0-9]+)";
            string patternForecast = @"Forecast:\s([^!|.|,|?]+)";
            List<string> results = new List<string>();
            string type = "";
            string source = "";
            string forecast = "";

            while (input != "Davai Emo")
            {
                Match typeMatch = Regex.Match(input, patternType);

                if (typeMatch.Success)
                {
                    type = typeMatch.Groups[1].Value;

                    input = Console.ReadLine();
                    Match sourceMatch = Regex.Match(input, patternSource);

                    while (!sourceMatch.Success)
                    {
                        input = Console.ReadLine();
                        sourceMatch = Regex.Match(input, patternSource);
                        source = sourceMatch.Groups[1].Value;
                    }
                    source = sourceMatch.Groups[1].Value;

                    input = Console.ReadLine();
                    Match forecastMatch = Regex.Match(input, patternForecast);

                    while (!forecastMatch.Success)
                    {
                        input = Console.ReadLine();
                        forecastMatch = Regex.Match(input, patternForecast);
                        forecast = forecastMatch.Groups[1].Value;
                    }
                    forecast = forecastMatch.Groups[1].Value;
                }

                if (type != "" && source != "" && forecast != "")
                {
                    string validForecast = $"({type}) {forecast} ~ {source}";
                    results.Add(validForecast);
                    type = "";
                    source = "";
                    forecast = "";
                }

                input = Console.ReadLine();
            }
            foreach (var item in results)
            {
                Console.WriteLine(item);
            }
        }
    }
}
