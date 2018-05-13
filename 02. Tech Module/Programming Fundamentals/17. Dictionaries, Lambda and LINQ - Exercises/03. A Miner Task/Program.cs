using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var resources = new Dictionary<string, int>();

            while (input != "stop")
            {  
                int quantity = int.Parse(Console.ReadLine());
                if (resources.ContainsKey(input))
                {
                    resources[input] += quantity;// if the key already exist, on his position we add new Value 
                }
                else
                {
                    resources.Add(input, quantity);// if the key does not exist we add it to the dictionarie
                }
                input = Console.ReadLine();
            }

            foreach (var item in resources)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
