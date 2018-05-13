using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _24.Take_or_Skip_Rope
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int[] numbers = Regex.Matches(input, "[0-9]").Cast<Match>().Select(x => x.Value).Select(int.Parse).ToArray();
            input = Regex.Replace(input, "[0-9]", "");
            List<int> take = new List<int>();
            List<int> skip = new List<int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                if (i % 2 == 0)
                {
                    take.Add(numbers[i]);
                }
                else
                {
                    skip.Add(numbers[i]);
                }
            }
            string result = "";
            int skipTotal = 0;
            for (int i = 0; i < skip.Count; i++)
            {
                result += new string(input.Skip(skipTotal).Take(take[i]).ToArray());
                skipTotal += skip[i] + take[i];
            }
            Console.WriteLine(result);
        }
    }
}
