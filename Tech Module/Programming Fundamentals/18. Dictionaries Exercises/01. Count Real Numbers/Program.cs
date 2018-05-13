using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Count_Real_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> input = Console.ReadLine().Split().Select(double.Parse).ToList();
            SortedDictionary<double, int> counts = new SortedDictionary<double, int>();


            for (int i = 0; i < input.Count; i++)
            {
                // if the dictionaty does not contain entered number as key
                if (!counts.ContainsKey(input[i]))
                {
                    counts[input[i]] = 1;
                }
                // if the dictionary contains the endtered number as key
                else if (counts.ContainsKey(input[i]))
                {
                    counts[input[i]]++;
                }
            }
            //here we print the result
            foreach (var count in counts)
            {
                //the key is the number we entered and the value is the count of appearance
                Console.WriteLine($"{count.Key} -> {count.Value}");
            }
        }
    }
}
