using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04.Weather
{
    class Program
    {
        static void Main(string[] args)
        {
            var cityTemperature = new Dictionary<string, double>();
            var cityWeather = new Dictionary<string, string>();
            string pattern = @"([A-Z]{2})([0-9]+.[0-9]+)([A-Za-z]+)\|";
            string input = Console.ReadLine();

            while (input !="end")
            {
                if (Regex.IsMatch(input, pattern))
                {
                    Match match = Regex.Match(input, pattern);

                    string city = match.Groups[1].Value;
                    double temperature = double.Parse(match.Groups[2].Value);
                    string weather = match.Groups[3].Value;

                    cityTemperature[city] = temperature;
                    cityWeather[city] = weather;
                }
                input = Console.ReadLine();
            }
            Dictionary<string, double> sortedCityTemperature = cityTemperature
                .OrderBy(c => c.Value)
                .ToDictionary(x => x.Key, x=> x.Value);

            foreach (var sortedCity in sortedCityTemperature)
            {
                Console.WriteLine($"{sortedCity.Key} => {sortedCity.Value:f2} => {cityWeather[sortedCity.Key]}");
            }
        }
    }
}
