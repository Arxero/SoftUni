using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Odd_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split().Select(x => x.ToLower()).ToArray();
            Dictionary<string, int> results = new Dictionary<string, int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (!results.ContainsKey(input[i]))
                {
                    results[input[i]] = 1;
                }
                else
                {
                    results[input[i]]++;
                }
            }
            List<string> finalResult = new List<string>();
            foreach (var result in results)
            {
                if (result.Value % 2 != 0)
                {
                    finalResult.Add(result.Key);
                }
            }
            Console.WriteLine($"{string.Join(", ", finalResult)}");
        }
    }
}
