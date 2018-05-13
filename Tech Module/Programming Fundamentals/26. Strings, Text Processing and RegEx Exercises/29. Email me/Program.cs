using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _29.Email_me
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"([\w\.]+)@([\w\.]+)";

            MatchCollection emails = Regex.Matches(input, pattern);

            foreach (Match email in emails)
            {
                char[] before = email.Groups[1].Value.ToCharArray();
                char[] after = email.Groups[2].Value.ToCharArray();

                int beforeSum = 0;
                for (int i = 0; i < before.Length; i++)
                {
                    beforeSum += before[i];
                }
                int afterSum = 0;
                for (int i = 0; i < after.Length; i++)
                {
                    afterSum += after[i];
                }
                int result = afterSum - beforeSum;

                if (result <= 0)
                {
                    Console.WriteLine("Call her!");
                }
                else
                {
                    Console.WriteLine("She is not the one.");
                }
            }
        }
    }
}
