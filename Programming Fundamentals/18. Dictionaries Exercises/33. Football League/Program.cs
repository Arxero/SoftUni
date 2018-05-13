using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _33.Football_League
{
    class Program
    {
        static void Main(string[] args)
        {
            string key = Console.ReadLine();
            string input = Console.ReadLine();
            key = Regex.Escape(key);
            string pattern = $@"{key}(.*?){key}";

            Dictionary<string, int> results = new Dictionary<string, int>();
            Dictionary<string, int> goals = new Dictionary<string, int>();

            while (input != "final")
            {
                string[] splitter = input.Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                Match match1 = Regex.Match(splitter[0], pattern);
                Match match2 = Regex.Match(splitter[1], pattern);
                char[] wordOne = match1.Groups[1].Value.Reverse().ToArray();
                char[] wordTwo = match2.Groups[1].Value.Reverse().ToArray();
                int[] resultSplitter = splitter[2].Split(':').Select(int.Parse).ToArray();

                string teamA = string.Join("", wordOne).ToUpper();
                string teamB = string.Join("", wordTwo).ToUpper();
                int scoreA = resultSplitter[0];
                int scoreB = resultSplitter[1];
                int pointsA = 0;
                int pointsB = 0;

                //find out the who win
                if (scoreA > scoreB)
                {
                    pointsA = 3;
                }
                else if (scoreA < scoreB)
                {
                    pointsB = 3;
                }
                else
                {
                    pointsA = 1;
                    pointsB = 1;
                }

                //filling the table dictionary
                if (!results.ContainsKey(teamA))
                {
                    results.Add(teamA, pointsA);
                }
                else
                {
                    results[teamA] += pointsA;
                }

                if (!results.ContainsKey(teamB))
                {
                    results.Add(teamB, pointsB);
                }
                else
                {
                    results[teamB] += pointsB;
                }


                //filling up the most scored goals dictionary
                if (!goals.ContainsKey(teamA))
                {
                    goals.Add(teamA, scoreA);
                }
                else
                {
                    goals[teamA] += scoreA;
                }

                if (!goals.ContainsKey(teamB))
                {
                    goals.Add(teamB, scoreB);
                }
                else
                {
                    goals[teamB] += scoreB;
                }


                input = Console.ReadLine();
            }

            int place = 1;
            Console.WriteLine("League standings:");
            foreach (var result in results.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{place++}. {result.Key} {result.Value}");
            }

            Console.WriteLine("Top 3 scored goals:");
            int breaker = 0;
            foreach (var goal in goals.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"- {goal.Key} -> {goal.Value}");
                breaker++;
                if (breaker == 3)
                {
                    break;
                }
            }
        }
    }
}
