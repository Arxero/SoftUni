using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _27.Use_Your_Chains__Buddy
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string extractPattern = @"(?<=<p>).*?(?=<\/p>)";
            string replacingPattern = @"[^a-z0-9]+";
            var sb = new StringBuilder();

            MatchCollection extractPTags = Regex.Matches(input, extractPattern);

            foreach (Match match in extractPTags)
            {
                string replaced = match.ToString();
                replaced = Regex.Replace(replaced, replacingPattern, " ");

                for (int i = 0; i < replaced.Length; i++)
                {
                    char ch = replaced[i];
                    if (char.IsLower(replaced[i]))
                    {
                        if (replaced[i] < 110)
                        {
                            sb.Append((char)(ch + 13));
                        }
                        else if (replaced[i] >= 110)
                        {
                            sb.Append((char)(ch - 13));
                        }
                    }
                    else
                    {
                        sb.Append(replaced[i]);
                    }
                }
            }
            Console.WriteLine(sb.ToString().Trim());
        }
    }
}
