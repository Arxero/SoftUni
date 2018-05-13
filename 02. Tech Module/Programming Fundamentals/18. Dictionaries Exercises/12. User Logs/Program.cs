using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.User_Logs
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, Dictionary<string, int>> results = new Dictionary<string, Dictionary<string, int>>();
            int count = 1;

            while (input != "end")
            {
                string[] splitter = input.Split(new[] { " ", "=" }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                string username = splitter[5];
                string ip = splitter[1];
                

                if (!results.ContainsKey(username))
                {
                    results.Add(username, new Dictionary<string, int>());
                    // that way we reach the second dictionary
                    results[username].Add(ip, count);
                }
                else
                {
                    if (!results[username].ContainsKey(ip))
                    {
                        results[username].Add(ip, count);
                    }
                    else
                    {
                        results[username][ip] += count;
                    }
                }
                input = Console.ReadLine();
            }
            foreach (var result in results.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{result.Key}:");

                string res = "";
                foreach (var ip in result.Value)
                {
                    res += $"{ip.Key} => {ip.Value}, ";
                }
                res = res.Remove(res.Length - 2);
                Console.WriteLine(res + '.');
            }
        }
    }
}
