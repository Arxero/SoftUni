using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Sales_Report
{

    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Sale[] sales = new Sale[n];

            for (int i = 0; i < n; i++)
            {
                sales[i] = ReadSale(Console.ReadLine());
            }

            SortedDictionary<string, decimal> results = new SortedDictionary<string, decimal>();

            foreach (var sale in sales)
            {
                if (!results.ContainsKey(sale.Town))
                {
                    results.Add(sale.Town, sale.Price * sale.Quantity);
                }
                else
                {
                    results[sale.Town] += sale.Price * sale.Quantity;
                }
            }

            foreach (var result in results)
            {
                Console.WriteLine($"{result.Key} -> {result.Value:f2}");
            }
        }

        static Sale ReadSale(string input)
        {
            string[] tokens = input.Split(' ');
            return new Sale() {Town = tokens[0], Product = tokens[1], Price = decimal.Parse(tokens[2]), Quantity = decimal.Parse(tokens[3])};
        }

        class Sale
        {
            public string Town { get; set; }
            public string Product { get; set; }
            public decimal Price { get; set; }
            public decimal Quantity { get; set; }
        }

    }
}
