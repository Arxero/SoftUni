using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Fix_Emails
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, string> results = new Dictionary<string, string>();

            while (input != "stop")
            {
                string email = Console.ReadLine();

                if (!results.ContainsKey(input) && email.Last().ToString() != "s" && email.Last().ToString() != "k")
                {
                    results.Add(input, email);
                }
                input = Console.ReadLine();
            }

            foreach (var result in results)
            {
                Console.WriteLine($"{result.Key} -> {result.Value}");
            }
        }
    }
}
