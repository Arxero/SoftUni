using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Small_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            string productName = Console.ReadLine().ToLower();
            string town = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());
            

            string coffee = "coffee";
            string water = "water";
            string beer = "beer";
            string sweets = "sweets";
            string peanuts = "peanuts";

            string sofiaTown = "Sofia";
            string varnaTown = "Varna";
            string plovdivTown = "Plovdiv";

            double priceOfProduct = 0.5;

            if (town == sofiaTown)
            {
                // to check what is the product
                if (productName == coffee)
                {
                    priceOfProduct = 0.5;
                    double price = quantity * priceOfProduct;
                    Console.WriteLine(price);
                }
                else if (productName == water)
                {
                    priceOfProduct = 0.8;
                    double price = quantity * priceOfProduct;
                    Console.WriteLine(price);
                }
                else if (productName == beer)
                {
                    priceOfProduct = 1.20;
                    double price = quantity * priceOfProduct;
                    Console.WriteLine(price);
                }
                else if (productName == sweets)
                {
                    priceOfProduct = 1.45;
                    double price = quantity * priceOfProduct;
                    Console.WriteLine(price);
                }
                else if (productName == peanuts)
                {
                    priceOfProduct = 1.60;
                    double price = quantity * priceOfProduct;
                    Console.WriteLine(price);
                }
            }
            if (town == plovdivTown)
            {
                // to check what is the product
                if (productName == coffee)
                {
                    priceOfProduct = 0.40;
                    double price = quantity * priceOfProduct;
                    Console.WriteLine(price);
                }
                else if (productName == water)
                {
                    priceOfProduct = 0.7;
                    double price = quantity * priceOfProduct;
                    Console.WriteLine(price);
                }
                else if (productName == beer)
                {
                    priceOfProduct = 1.15;
                    double price = quantity * priceOfProduct;
                    Console.WriteLine(price);
                }
                else if (productName == sweets)
                {
                    priceOfProduct = 1.30;
                    double price = quantity * priceOfProduct;
                    Console.WriteLine(price);
                }
                else if (productName == peanuts)
                {
                    priceOfProduct = 1.50;
                    double price = quantity * priceOfProduct;
                    Console.WriteLine(price);
                }
            }
            if (town == varnaTown)
            {
                // to check what is the product
                if (productName == coffee)
                {
                    priceOfProduct = 0.45;
                    double price = quantity * priceOfProduct;
                    Console.WriteLine(price);
                }
                else if (productName == water)
                {
                    priceOfProduct = 0.7;
                    double price = quantity * priceOfProduct;
                    Console.WriteLine(price);
                }
                else if (productName == beer)
                {
                    priceOfProduct = 1.10;
                    double price = quantity * priceOfProduct;
                    Console.WriteLine(price);
                }
                else if (productName == sweets)
                {
                    priceOfProduct = 1.35;
                    double price = quantity * priceOfProduct;
                    Console.WriteLine(price);
                }
                else if (productName == peanuts)
                {
                    priceOfProduct = 1.55;
                    double price = quantity * priceOfProduct;
                    Console.WriteLine(price);
                }
            }
        }
    }
}
