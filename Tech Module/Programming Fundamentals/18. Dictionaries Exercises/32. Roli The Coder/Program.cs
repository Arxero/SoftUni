using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32.Roli_The_Coder
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<int, Dictionary<string, List<string>>> results = new Dictionary<int, Dictionary<string, List<string>>>();

            while (input != "Time for Code")
            {
                string[] splitter = input.Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                int id = int.Parse(splitter[0]);
                string eventName = splitter[1];

                char[] eventChecker = eventName.ToArray();

                if (eventChecker[0].ToString() == "#")
                {
                    char[] eventName2 = eventChecker.Skip(1).ToArray();
                    eventName = string.Join("", eventName2);

                    if (!results.ContainsKey(id))
                    {
                        results.Add(id, new Dictionary<string, List<string>>());
                        var participants = splitter.Skip(2).ToList().Distinct().ToList();
                        results[id].Add(eventName, participants);
                    }
                    else
                    {
                        if (results[id].ContainsKey(eventName))
                        {
                            var participants = splitter.Skip(2).ToList().Distinct().ToList();
                            results[id][eventName].AddRange(participants);
                            results[id][eventName] = results[id][eventName].Distinct().ToList();
                        }
                    }
                }
                input = Console.ReadLine();
            }
            foreach (var result in results.OrderByDescending(x => x.Value.Values.Sum(v => v.Count)).ThenBy(x => x.Key))
            {
                foreach (var name in result.Value)
                {
                    Console.WriteLine($"{name.Key} - {name.Value.Count}");

                    foreach (var participant in name.Value.OrderBy(x => x))
                    {
                        Console.WriteLine($"{participant}");
                    }
                }
            }
        }
    }
}
