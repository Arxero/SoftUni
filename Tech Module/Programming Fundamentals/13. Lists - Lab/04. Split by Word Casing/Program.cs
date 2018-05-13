using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Split_by_Word_Casing
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            List<string> split = input.Split(new char[] { ',', ';', ':', '.', '!', '(', ')', '"', '\'', '\\', '/', '[', ']', ' '}, StringSplitOptions.RemoveEmptyEntries).ToList();
            //var input = Console.ReadLine().Split(new char[] { ',', ';', ' ', '.', ':', '!', '(', ')', '"', '\'', '\\', '/', '[', ']' },StringSplitOptions.RemoveEmptyEntries).ToList();

            List<string> lowerCase = new List<string>();
            List<string> upperCase = new List<string>();
            List<string> mixedCase = new List<string>();
            int counter = 0;

            for (int i = 0; i < split.Count; i++)
            {
                if (split[i].All(char.IsLower))
                {
                    lowerCase.Add(split[i]);
                }
                else if (split[i].All(char.IsUpper))
                {
                    upperCase.Add(split[i]);
                }
                else
                {
                    mixedCase.Add(split[i]);
                }
            }
            Console.WriteLine($"Lower-case: { String.Join(", ", lowerCase)}");
            Console.WriteLine($"Mixed-case: { String.Join(", ", mixedCase)}");
            Console.WriteLine($"Upper-case: { String.Join(", ", upperCase)}");
        }
    }
}
