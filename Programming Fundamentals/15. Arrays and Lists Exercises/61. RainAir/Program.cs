using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _61.RainAir
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, List<int>> results = new Dictionary<string, List<int>>();


            while (input != "I believe I can fly!")
            {
                string[] splitter = input.Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                string name = splitter[0];

                if (splitter[1] != "=")
                {
                    if (!results.ContainsKey(name))
                    {
                        List<int> value = new List<int>();
                        var a = splitter.Skip(1).ToList();
                        int[] ints = a.Select(int.Parse).ToArray();
                        value.AddRange(ints);

                        results.Add(name, value);
                    }
                    else
                    {
                        List<int> value = new List<int>();
                        var a = splitter.Skip(1).ToList();
                        int[] ints = a.Select(int.Parse).ToArray();
                        value.AddRange(ints);

                        results[name].AddRange(value);
                    }
                }
                else
                {
                    var a = results[splitter[2]].ToList();
                    results[splitter[0]] = a;
                }
                input = Console.ReadLine();
            }
            foreach (var result in results.OrderByDescending( x => x.Value.Count).ThenBy(x => x.Key))
            {
                Console.WriteLine($"#{result.Key} ::: {string.Join(", ", result.Value.OrderBy(x => x))}");

                
            }
        }
    }
}
