using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _25.Valid_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new[] { " ", ",", "/", "\\", "(", ")" }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            string pattern = @"\b([A-Za-z]\w{2,24})\b";
            List<string> result = new List<string>();

            string joined = string.Join(" ", input);
            MatchCollection usernames = Regex.Matches(joined, pattern);

            foreach (Match username in usernames)
            {
                result.Add(username.Value);
            }
            int sumLength = 0;
            int sumLengthMax = 0;
            string wordOne = "";
            string wordTwo = "";
            for (int i = 0; i < result.Count - 1; i++)
            {
                sumLength = result[i].Length + result[i + 1].Length;
                if (sumLength > sumLengthMax)
                {
                    sumLengthMax = sumLength;
                    wordOne = result[i];
                    wordTwo = result[i + 1];

                }
            }
            Console.WriteLine(wordOne);
            Console.WriteLine(wordTwo);
        }
    }
}
