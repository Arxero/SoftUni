using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21.Supermarket_Database
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, Dictionary<double, int>> results = new Dictionary<string, Dictionary<double, int>>();
            List<double> grandToral = new List<double>();

            while (input != "stocked")
            {
                string[] splitter = input.Split().ToArray();
                string name = splitter[0];
                double price = double.Parse(splitter[1]);
                int quantity = int.Parse(splitter[2]);

                //do we have such product
                if (!results.ContainsKey(name))
                {
                    results.Add(name, new Dictionary<double, int>());
                    results[name].Add(price, quantity);
                }
                else
                {
                    //do we have such price with that particular product
                    if (!results[name].ContainsKey(price))
                    {
                        results[name].Add(price, quantity);
                    }
                    else
                    {
                        results[name][price] += quantity;
                    }
                }
                input = Console.ReadLine();
            }
            foreach (var result in results)
            {
                //getting the last entered price by product
                double lastPrice = result.Value.Last().Key;
                Console.Write($"{result.Key}: ");

                result.Key.Distinct();
                foreach (var price in result.Value)
                {
                    int quantitySum = result.Value.Values.Sum();
                    double calculation = lastPrice * quantitySum;
                    grandToral.Add(calculation);
                    Console.WriteLine($"${lastPrice:f2} * {quantitySum} = ${calculation:f2}");
                    break;
                }
            }
            Console.WriteLine(new string('-', 30));
            Console.WriteLine($"Grand Total: ${grandToral.Sum():f2}");
        }
    }
}
