using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Melrah_Shake
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = Console.ReadLine();

            int first = input.IndexOf(pattern);
            int last = input.LastIndexOf(pattern);

            while (first >= 0 && last >= 0 && pattern.Length > 0)
            {
                input = input.Remove(last, pattern.Length);
                input = input.Remove(first, pattern.Length);

                pattern = pattern.Remove(pattern.Length / 2, 1);

                first = input.IndexOf(pattern);
                last = input.LastIndexOf(pattern);

                Console.WriteLine("Shaked it.");
            }
            Console.WriteLine("No shake.");
            Console.WriteLine(input);
        }
    }
}
