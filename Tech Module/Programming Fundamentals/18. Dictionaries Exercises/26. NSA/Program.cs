using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26.NSA
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, Dictionary<string, long>> results = new Dictionary<string, Dictionary<string, long>>();

            while (input != "quit")
            {
                string[] splitter = input.Split(new[] { " -> " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                string country = splitter[0];
                string name = splitter[1];
                long days = long.Parse(splitter[2]);

                if (!results.ContainsKey(country))
                {
                    results.Add(country, new Dictionary<string, long>());
                    results[country].Add(name, days);
                }
                else
                {
                    if (!results[country].ContainsKey(name))
                    {
                        results[country].Add(name, days);
                    }
                    else
                    {
                        results[country][name] = days;
                    }
                }
                input = Console.ReadLine();
            }

            foreach (var result in results.OrderByDescending(x => x.Value.Count))
            {
                Console.WriteLine($"Country: {result.Key}");
                foreach (var spy in result.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"**{spy.Key} : {spy.Value}");
                }
            }
        }
    }
}
