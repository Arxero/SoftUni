using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27.Inventory_Matcher
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] products = Console.ReadLine().Split().ToArray();
            long[] quantity = Console.ReadLine().Split().Select(long.Parse).ToArray();
            decimal[] price = Console.ReadLine().Split().Select(decimal.Parse).ToArray();
            string product = Console.ReadLine();

            while (product !="done")
            {
                for (int i = 0; i < products.Length; i++)
                {
                    if (product == products[i])
                    {
                        int productIndex = Array.IndexOf(products, product);
                        Console.WriteLine($"{product} costs: {price[productIndex]}; Available quantity: {quantity[productIndex]}");
                    }
                }
                product = Console.ReadLine();
            }

        }
    }
}
