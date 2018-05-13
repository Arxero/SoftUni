using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Logs_Aggregator
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            SortedDictionary<string, SortedDictionary<string, int>> logs = new SortedDictionary<string, SortedDictionary<string, int>>();
            //_______________user_____________________IP______duration

            for (int i = 0; i < input; i++)
            {
                var log = Console.ReadLine().Split(' ');
                string ip = log[0];
                string name = log[1];
                int duration = int.Parse(log[2]);

                if (!logs.ContainsKey(name))
                {
                    logs.Add(name, new SortedDictionary<string, int>());
                }
                if (!logs[name].ContainsKey(ip))
                {
                    logs[name][ip] = 0;
                }

                logs[name][ip] += duration;
            }

            foreach (var outerPair in logs)
            {
                var sum = outerPair.Value.Values.Sum();
                Console.Write($"{outerPair.Key}: {sum} ");
                Console.Write("[");
                Console.Write(string.Join(", ", outerPair.Value.Keys));
                Console.WriteLine("]");

            }
        }
    }
}
