using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Palindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new[] { " ", ",", ".", "?", "!"}, StringSplitOptions.RemoveEmptyEntries).ToArray();

            List<string> result = new List<string>();

            for (int i = 0; i < input.Length; i++)
            {
                var reversed = input[i].Reverse().ToArray();
                string joined = string.Join("", reversed);

                if (input[i] == joined)
                {
                    result.Add(input[i]);
                }
            }
            result = result.Distinct().ToList();
            Console.WriteLine(string.Join(", ", result.OrderBy(x => x)));
        }
    }
}
