using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _35.SoftUni_Coffee_Supplies
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] delimeters = Console.ReadLine().Split(new[] {" "},StringSplitOptions.RemoveEmptyEntries).ToArray();
            string delimeterOne = delimeters[0];
            string delimeterTwo = delimeters[1];
            string input = Console.ReadLine();
            Dictionary<string, string> results = new Dictionary<string, string>();
            Dictionary<string, int> availability = new Dictionary<string, int>();


            while (input != "end of info")
            {
                if (input.Contains(delimeterOne))
                {
                    string[] splitter = input.Split(new[] { $"{delimeterOne}" }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                    string name = splitter[0];
                    string coffe = splitter[1];

                    if (!results.ContainsKey(name))
                    {
                        results.Add(name, coffe);
                    }

                }
                else
                {
                    string[] splitter = input.Split(new[] { $"{delimeterTwo}" }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                    string coffe = splitter[0];
                    int quantity = 0;
                    if (splitter.Length > 1)
                    {
                        quantity = int.Parse(splitter[1]);
                    }

                    if (!availability.ContainsKey(coffe))
                    {
                        availability.Add(coffe, quantity);
                    }
                    else
                    {
                        availability[coffe] += quantity;
                    }
                }
                input = Console.ReadLine();
            }

            foreach (var coffe in availability)
            {
                if (availability[coffe.Key] == 0)
                {
                    Console.WriteLine($"Out of {coffe.Key}");
                }
            }

            string inputMonitor = Console.ReadLine();

            while (inputMonitor != "end of week")
            {
                string[] splitter = inputMonitor.Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                string name = splitter[0];
                int drinkPower = int.Parse(splitter[1]);

                foreach (var coffe in availability.ToArray())
                {
                    if (results[name].Contains(coffe.Key))
                    {
                        availability[coffe.Key] -= drinkPower;
                        if (availability[coffe.Key] == 0)
                        {
                            Console.WriteLine($"Out of {coffe.Key}");
                        }                    
                    }
                }
                inputMonitor = Console.ReadLine();
            }
            Console.WriteLine("Coffee Left:");
            foreach (var coffe in availability.Where(x => x.Value > 0).OrderByDescending(x => x.Value))
            {
                Console.WriteLine($"{coffe.Key} {coffe.Value}");
            }
            Console.WriteLine("For:");
            foreach (var coffe in availability.Where(x => x.Value > 0).Where(x => results.Values.Contains(x.Key)).OrderBy(x => x.Key))
            {
                foreach (var name in results.Where(x => results[x.Key] == coffe.Key).OrderBy(x => x.Value).ThenByDescending(x => x.Key))
                {
                    Console.WriteLine($"{name.Key} {coffe.Key}");
                }
                
            }
        }
    }
}
