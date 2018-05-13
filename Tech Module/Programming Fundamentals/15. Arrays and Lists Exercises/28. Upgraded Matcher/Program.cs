using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28.Upgraded_Matcher
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] products = Console.ReadLine().Split().ToArray();
            long[] quantity = Console.ReadLine().Split().Select(long.Parse).ToArray();
            decimal[] price = Console.ReadLine().Split().Select(decimal.Parse).ToArray();
            string[] productPlusOrder = Console.ReadLine().Split().ToArray();

            while (productPlusOrder[0] != "done")
            {
                long productIndex = Array.IndexOf(products, productPlusOrder[0]);
                long order = long.Parse(productPlusOrder[1]);
                decimal totalPrice = 0;
                long quantityChecker = 0;

                //find out what quantity we have of certain product 
                for (
                    long i = 0; i < quantity.Length; i++)
                {
                    if (i == productIndex)
                    {
                        quantityChecker = quantity[productIndex];
                    }
                }

                if (quantityChecker >= order)
                {
                    totalPrice = order * price[productIndex];
                    quantity[productIndex] -= order;
                    Console.WriteLine($"{products[productIndex]} x {order} costs {totalPrice:f2}");
                }
                else
                {
                    Console.WriteLine($"We do not have enough {products[productIndex]}");

                }
                productPlusOrder = Console.ReadLine().Split().ToArray();
            }
        }
    }
}
