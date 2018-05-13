using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Population_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, Dictionary<string, long>> results = new Dictionary<string, Dictionary<string, long>>();

            while (input != "report")
            {
                string[] splitter = input.Split(new[] { "|" }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                string country = splitter[1];
                string city = splitter[0];
                int population = int.Parse(splitter[2]);

                //if already the country exist
                if (!results.ContainsKey(country))
                {
                    results.Add(country, new Dictionary<string, long>());
                    results[country].Add(city, population);
                }
                else
                {
                    results[country].Add(city, population);

                }
                input = Console.ReadLine();
            }
            //Countries should be ordered by their total population in descending order
            var orderedCountries = results.OrderByDescending(x => x.Value.Values.Sum());

            foreach (var result in orderedCountries)
            {
                Console.WriteLine($"{result.Key} (total population: {result.Value.Values.Sum()})");
                foreach (var city in result.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"=>{city.Key}: {city.Value}");
                }
            }
        }
    }
}
