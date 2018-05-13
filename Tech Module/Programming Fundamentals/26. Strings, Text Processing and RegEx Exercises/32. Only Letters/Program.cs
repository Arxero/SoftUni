using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _32.Only_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string numbersPattern = @"\d+";
            string letterAfterNumberPattern = @"(?<=[\d])([a-zA-Z])";

            MatchCollection numbers = Regex.Matches(input, numbersPattern);
            MatchCollection letters = Regex.Matches(input, letterAfterNumberPattern);
            int cycles = numbers.Count;

            if (numbers.Count != letters.Count)
            {
                cycles = letters.Count;
            }

            for (int i = 0; i < cycles; i++)
            {
                int index = input.IndexOf(numbers[i].ToString());
                input = input.Remove(index, numbers[i].Length);
                input = input.Insert(index, letters[i].ToString());
                
            }
            Console.WriteLine(input);
        }
    }
}
