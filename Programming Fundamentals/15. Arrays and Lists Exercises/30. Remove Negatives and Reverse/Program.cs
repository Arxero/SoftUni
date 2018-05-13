using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30.Remove_Negatives_and_Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> result = new List<int>();

            for (int i = input.Count - 1; i >= 0; i--)
            {
                if (input[i] > 0)
                {
                    result.Add(input[i]);
                }
            }
            if (result.Any())
            {
                Console.WriteLine(string.Join(" ", result));
            }
            else
            {
                Console.WriteLine("empty");
            }
            
        }
    }
}
