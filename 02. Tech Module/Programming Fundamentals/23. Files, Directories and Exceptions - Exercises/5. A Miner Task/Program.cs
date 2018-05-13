using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader file = new StreamReader("input.txt");
            string input = file.ReadLine();
            
            var resources = new Dictionary<string, int>();

            while (input != "stop")
            {
                int quantity = int.Parse(file.ReadLine());
                if (resources.ContainsKey(input))
                {
                    resources[input] += quantity;// if the key already exist, on his position we add new Value 
                }
                else
                {
                    resources.Add(input, quantity);// if the key does not exist we add it to the dictionarie
                }
                input = file.ReadLine();
            }

            foreach (var item in resources)
            {
                File.AppendAllText("output.txt", $"{item.Key} -> {item.Value}" + Environment.NewLine);

            }
        }
    }
}
