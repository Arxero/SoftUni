using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31.Append_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split(new[] { "|" }, StringSplitOptions.RemoveEmptyEntries).ToList();
            List<int> result = new List<int>();

            for (int i = input.Count - 1; i >= 0; i--)
            {
                int[] elements = input[i].Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                result.AddRange(elements);
            }
            Console.WriteLine(string.Join(" ", result));

        }
    }
}
