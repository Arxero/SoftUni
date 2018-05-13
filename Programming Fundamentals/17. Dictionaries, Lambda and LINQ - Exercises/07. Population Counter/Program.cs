using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Population_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, long>> countries = new Dictionary<string, Dictionary<string, long>>();
            //_________country ->________city -> population
            string input = Console.ReadLine();

            while (input != "report")
            {
                var parameters = input.Split('|');
                string city = parameters[0];
                string country = parameters[1];
                long population = long.Parse(parameters[2]);

                if (!countries.ContainsKey(country))
                {
                    countries.Add(country, new Dictionary<string, long>());
                }
                if (!countries[country].ContainsKey(city))
                {
                    countries[country].Add(city, population);
                }
                input = Console.ReadLine();
            }
            var orderCountries = countries.OrderByDescending(x => x.Value.Values.Sum());

            foreach (var country in orderCountries)
            {
                Console.WriteLine($"{country.Key} (total population: {country.Value.Values.Sum()})");
                foreach (var city in country.Value.OrderByDescending(o => o.Value))
                {
                    Console.WriteLine($"=>{city.Key}: {city.Value}");
                }
            }
        }
    }
}
