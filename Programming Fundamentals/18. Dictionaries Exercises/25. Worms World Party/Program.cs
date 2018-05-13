using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25.Worms_World_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, Dictionary<string, long>> results = new Dictionary<string, Dictionary<string, long>>();
            List<string> worms = new List<string>();

            while (input != "quit")
            {
                string[] splitter = input.Split(new[] { " -> " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                string name = splitter[0];
                string team = splitter[1];
                long score = long.Parse(splitter[2]);

                if (!worms.Contains(name))
                {
                    if (!results.ContainsKey(team))
                    {
                        results.Add(team, new Dictionary<string, long>());
                        results[team].Add(name, score);
                    }
                    else
                    {
                        if (!results[team].ContainsKey(name))
                        {
                            results[team].Add(name, score);
                        }
                        else
                        {
                            results[team][name] = score;
                        }
                    }
                }

                worms.Add(name);
                input = Console.ReadLine();
            }

            long n = 1;
            foreach (var result in results.OrderByDescending(x => x.Value.Values.Sum()).ThenByDescending(x => x.Value.Values.Sum() / x.Value.Count))
            {
                Console.WriteLine($"{n++}. Team: {result.Key} - {result.Value.Values.Sum()}");

                foreach (var worm in result.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"###{worm.Key} : {worm.Value}");
                }
            }
        }
    }
}
