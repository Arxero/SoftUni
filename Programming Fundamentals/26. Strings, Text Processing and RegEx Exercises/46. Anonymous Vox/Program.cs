using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _46.Anonymous_Vox
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] input2 = Console.ReadLine().Split(new[] { "{", "}" }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            string pattern = @"([a-zA-Z]+)(.+)\1";

            MatchCollection matches = Regex.Matches(input, pattern);

            for (int i = 0; i < matches.Count; i++)
            {
                string valuePlaceHolder = matches[i].Groups[2].Value;

                string old = input.Substring(0, input.IndexOf(valuePlaceHolder) + valuePlaceHolder.Length);
                string neew = old.Replace(valuePlaceHolder, input2[i]);

                input = neew + input.Substring(old.Length);
                //input = Regex.Replace(input, matches[i].Groups[2].Value, input2[i]);
            }
            Console.WriteLine(input);
        }
    }
}
