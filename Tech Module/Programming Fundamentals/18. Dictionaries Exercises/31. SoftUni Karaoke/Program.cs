using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31.SoftUni_Karaoke
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> participants = Console.ReadLine().Split(new[] { ", ",}, StringSplitOptions.RemoveEmptyEntries).ToList();
            List<string> songs = Console.ReadLine().Split(new[] { ", ",}, StringSplitOptions.RemoveEmptyEntries).ToList();
            string input = Console.ReadLine();

            Dictionary<string, Dictionary<string, int>> results = new Dictionary<string, Dictionary<string, int>>();

            while (input != "dawn")
            {
                string[] splitter = input.Split(new[] { ", ",}, StringSplitOptions.RemoveEmptyEntries).ToArray();
                string name = splitter[0];
                string song = splitter[1];
                string award = splitter[2];

                if (participants.Contains(name) && songs.Contains(song))
                {
                    if (!results.ContainsKey(name))
                    {
                        results.Add(name, new Dictionary<string, int>());
                        results[name].Add(award, 1);
                    }
                    else
                    {
                        if (!results[name].ContainsKey(award))
                        {

                            results[name].Add(award, 1);
                        }
                        else
                        {
                            results[name][award] += 1;
                        }
                    }

                }
                input = Console.ReadLine();
            }
            if (results.Any())
            {
                foreach (var result in results.OrderByDescending(x => x.Value.Values.Count).ThenBy(x => x.Key))
                {
                    Console.WriteLine($"{result.Key}: {result.Value.Values.Count} awards");
                    foreach (var award in result.Value.OrderBy(x => x.Key))
                    {
                        Console.WriteLine($"--{award.Key}");
                    }
                }
            }
            else
            {
                Console.WriteLine("No awards");
            }
            
        }
    }
}
