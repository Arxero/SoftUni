using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _23.Weather
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"(?<city>[A-Z]{2})(?<temperature>[0-9]+\.[0-9]+)(?<weather>[a-zA-Z]+)(?=\|)";
            Dictionary<string, Dictionary<double, string>> result = new Dictionary<string, Dictionary<double, string>>();


            while (input != "end")
            {
                MatchCollection forecasts = Regex.Matches(input, pattern);

                foreach (Match forecast in forecasts)
                {
                    string city = forecast.Groups["city"].Value;
                    double temerature = double.Parse(forecast.Groups["temperature"].Value);
                    string weather = forecast.Groups["weather"].Value;

                    
                }
                input = Console.ReadLine();
            }

        }
    }
}
