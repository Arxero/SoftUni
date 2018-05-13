using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            string resource = Console.ReadLine();
            Dictionary<string, int> results = new Dictionary<string, int>();

            while (resource != "stop")
            {
                int quantity = int.Parse(Console.ReadLine());

                if (!results.ContainsKey(resource))
                {
                    results.Add(resource, quantity);
                }
                else
                {
                    results[resource] += quantity;
                }
                resource = Console.ReadLine();
            }

            foreach (var result in results)
            {
                Console.WriteLine($"{result.Key} -> {result.Value}");
            }
        }
    }
}
