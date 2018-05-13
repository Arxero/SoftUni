using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29.Pokemon_Evolution
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, Dictionary<List<string>, int>> results = new Dictionary<string, Dictionary<List<string>, int>>();

            while (input != "wubbalubbadubdub")
            {
                string[] splitter = input.Split(new[] { " -> " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                string name = splitter[0];

                if (splitter.Length > 1)
                {
                    string type = splitter[1];
                    int index = int.Parse(splitter[2]);

                    if (!results.ContainsKey(name))
                    {
                        List<string> value = new List<string>();
                        value.Add(type);
                        results.Add(name, new Dictionary<List<string>, int>());
                        results[name].Add(value, index);
                    }
                    else
                    {
                        List<string> value = new List<string>();
                        value.Add(type);
                        results[name].Add(value, index);
                    }
                }
                else
                {
                    if (results.ContainsKey(name))
                    {
                        foreach (var result in results.Where(x => x.Key == name))
                        {
                            Console.WriteLine($"# {result.Key}");
                            foreach (var evolution in result.Value)
                            {
                                Console.WriteLine($"{string.Join("", evolution.Key)} <-> {evolution.Value}");
                            }
                        }
                    }
                }
                input = Console.ReadLine();
            }
            foreach (var result in results)
            {
                Console.WriteLine($"# {result.Key}");
                foreach (var evolution in result.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"{string.Join("", evolution.Key)} <-> {evolution.Value}");
                }
            }
        }
    }
}
