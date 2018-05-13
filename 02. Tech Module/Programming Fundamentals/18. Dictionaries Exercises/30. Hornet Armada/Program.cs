using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30.Hornet_Armada
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, long>> results = new Dictionary<string, Dictionary<string, long>>();
            Dictionary<string, long> activityDict = new Dictionary<string, long>();

            for (long i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(new[] { "=", "-", ">", ":", " " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                long activity = long.Parse(input[0]);
                string legion = input[1];
                string soldier = input[2];
                long count = long.Parse(input[3]);

                if (!results.ContainsKey(legion))
                {
                    results.Add(legion, new Dictionary<string, long>());
                    results[legion].Add(soldier, count);
                }
                else
                {
                    if (!results[legion].ContainsKey(soldier))
                    {
                        results[legion].Add(soldier, count);
                    }
                    else
                    {
                        results[legion][soldier] += count;
                    }
                }

                if (!activityDict.ContainsKey(legion))
                {
                    activityDict.Add(legion, activity);
                }
                else if (activityDict.ContainsKey(legion) && activity > activityDict[legion])
                {
                    activityDict[legion] = activity;
                }
            }

            string[] finalInput = Console.ReadLine().Split(new[] { "\\" }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            if (finalInput.Length == 2)
            {
                long activity = long.Parse(finalInput[0]);
                string soldier = finalInput[1];

                foreach (var result in results.Where(x => x.Value.ContainsKey(soldier)).Where(x => activityDict[x.Key] < activity).OrderByDescending(x => x.Value[soldier]))
                {
                    Console.WriteLine($"{result.Key} -> {result.Value[soldier]}");
                }

            }
            else
            {
                string soldier = finalInput[0];

                foreach (var activity in activityDict.Where(x => results[x.Key].ContainsKey(soldier)).OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"{activity.Value} : {activity.Key}");
                }
            }
        }
    }
}
