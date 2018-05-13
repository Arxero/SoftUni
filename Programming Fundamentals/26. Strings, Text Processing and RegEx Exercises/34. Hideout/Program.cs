using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _34.Hideout
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            while (true)
            {
                string[] clues = Console.ReadLine().Split(new[] { " "},StringSplitOptions.RemoveEmptyEntries).ToArray();

                string hideout = clues[0];
                int count = int.Parse(clues[1]);
                string pattern = @"\"+hideout+"{"+count+",}";
                Match match = Regex.Match(input, pattern);
                if (match.Success && match.Length >= count )
                {
                    int index = input.IndexOf(match.Value);
                    Console.WriteLine($"Hideout found at index {index} and it is with size {match.Length}!");
                    break;
                }
                
            }
        }
    }
}
