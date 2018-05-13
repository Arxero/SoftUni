using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _06.Valid_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string[] splited = input.Split(' ', '/', '\\', '(', ')').ToArray();

            string pattern = @"\b((?![0-9])[a-zA-Z0-9._]+){3,25}";
            var regex = Regex.Matches(input, pattern);

            List<string> valid = new List<string>();

            foreach (Match item in regex)
            {

                valid.Add(item.Value);
            }

            int totalSum = 0;
            string first = "";
            string second = "";
            for (int i = 0; i < valid.Count - 1; i++)
            {
                int sum = valid[i].Length + valid[i + 1].Length;
                if (sum > totalSum)
                {
                    totalSum = sum;
                    first = valid[i];
                    second = valid[i + 1];
                }
            }
            Console.WriteLine(first);
            Console.WriteLine(second);
        }
    }
}
