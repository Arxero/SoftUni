using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _33.Split_by_Word_Casing
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split(new[] { ",", ";", ":", ".", "!", "(", ")", "\"", "'", "\\", "/", "[", "]", " "}, StringSplitOptions.RemoveEmptyEntries).ToList();

            List<string> lowercase = new List<string>();
            List<string> mixedcase = new List<string>();
            List<string> uppercase = new List<string>();

            //loop for every word
            for (int i = 0; i < input.Count; i++)
            {
                char[] splitter = input[i].ToCharArray();

                int countLower = 0;
                int countUpper = 0;
                //loop for every letter in in the word
                for (int k = 0; k < splitter.Length; k++)
                {
                    if (splitter[k] >= 97 && splitter[k] <= 122)
                    {
                        countLower++;
                    }
                    else if (splitter[k] >= 65 && splitter[k] <= 90)
                    {
                        countUpper++;
                    }
                }
                if (countLower == splitter.Length)
                {
                    lowercase.Add(input[i]);
                }
                else if (countUpper == splitter.Length)
                {
                    uppercase.Add(input[i]);
                }
                else
                {
                    mixedcase.Add(input[i]);
                }
            }
            Console.WriteLine($"Lower-case: {string.Join(", ", lowercase)}");
            Console.WriteLine($"Mixed-case: {string.Join(", ", mixedcase)}");
            Console.WriteLine($"Upper-case: {string.Join(", ", uppercase)}");
        }
    }
}
