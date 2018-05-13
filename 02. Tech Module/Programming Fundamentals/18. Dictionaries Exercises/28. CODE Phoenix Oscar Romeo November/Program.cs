using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28.CODE_Phoenix_Oscar_Romeo_November
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, List<string>> results = new Dictionary<string, List<string>>();

            while (input != "Blaze it!")
            {
                string[] splitter = input.Split(new[] { " -> " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                string creature = splitter[0];
                string squadMate = splitter[1];

                if (!results.ContainsKey(creature))
                {
                    results.Add(creature, new List<string>());
                    results[creature].Add(squadMate);
                }
                else
                {
                    if (!results[creature].Contains(squadMate) && squadMate != creature)
                    {
                        results[creature].Add(squadMate);
                    }
                }
                input = Console.ReadLine();
            }

            //when I needed to filter one dict acorrdign the  things  in the other
            Dictionary<string, List<string>> resultsFinal = new Dictionary<string, List<string>>();
            foreach (var creature in results)
            {
                resultsFinal.Add(creature.Key, new List<string>());
                foreach (var squadMate in creature.Value)
                {
                    if (results.ContainsKey(squadMate) && results[squadMate].Contains(creature.Key))
                    {
                    }
                    else
                    {
                        resultsFinal[creature.Key].Add(squadMate);
                    }
                }
            }

            foreach (var result in resultsFinal.OrderByDescending(x => x.Value.Count))
            {
                Console.WriteLine($"{result.Key} : {result.Value.Count}");
            }
        }
    }
}
