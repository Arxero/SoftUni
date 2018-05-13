using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Logs_Aggregator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, int>> results = new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                string user = input[1];
                string ip = input[0];
                int duration = int.Parse(input[2]);

                if (!results.ContainsKey(user))
                {
                    results.Add(user, new Dictionary<string, int>());
                    results[user].Add(ip, duration);
                }
                else
                {
                    if (!results[user].ContainsKey(ip))
                    {
                        results[user].Add(ip, duration);
                    }
                    else
                    {
                        results[user][ip] += duration;
                    }
                    
                }
            }
            //represents the users
            foreach (var result in results.OrderBy(x => x.Key))
            {
                Console.Write($"{result.Key}: {result.Value.Values.Sum()} ");
                //represents the ips
                List<string> ips = new List<string>();
                foreach (var ip in result.Value.OrderBy(x => x.Key))
                {
                    ips.Add(ip.Key);
                }
                Console.Write($"[{string.Join(", ", ips)}]");
                Console.WriteLine();
            }
        }
    }
}
