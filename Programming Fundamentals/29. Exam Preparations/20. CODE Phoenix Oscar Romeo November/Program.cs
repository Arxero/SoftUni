using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20.CODE_Phoenix_Oscar_Romeo_November
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            var dict = new Dictionary<string, HashSet<string>>();

            while (input != "Blaze it!")
            {
                string[] splitter = input.Split(new[] { " -> " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                string creature = splitter[0];
                string squadMate = splitter[1];

                if (!dict.ContainsKey(creature))
                {
                    dict.Add(creature, new HashSet<string>());
                }
                if (creature != squadMate)
                {
                    dict[creature].Add(squadMate);
                }

                input = Console.ReadLine();
            }

            var result = new Dictionary<string, List<string>>();

            foreach (var item in dict)
            {
                result.Add(item.Key, new List<string>());

                foreach (var mate in item.Value)
                {
                    if (dict.ContainsKey(mate) && dict[mate].Contains(item.Key))
                    {
                        continue;
                    }
                    else
                    {
                        result[item.Key].Add(mate);
                    }
                }
            }

            foreach (var item in result.OrderByDescending(c => c.Value.Count))
            {
                Console.WriteLine($"{item.Key} : {item.Value.Count}");
            }
        }
    }
}
