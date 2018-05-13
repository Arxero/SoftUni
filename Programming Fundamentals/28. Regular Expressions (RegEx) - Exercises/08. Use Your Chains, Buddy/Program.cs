using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _08.Use_Your_Chains__Buddy
{
    class Program
    {
        static void Main(string[] args)
        {
            //string input = @"<html><head><title></title></head><body><h1>hello</h1><p>znahny!@#%&&&&****</p><div><button>
//dsad</button></div><p>grkg^^^^%%%)))([]12</p></body></html>";
            string input = Console.ReadLine();
            string pattern = @"(<p>(.*?)<\/p>)";
            string patternReplacment = @"[^a-z0-9]+?";

            var regex = Regex.Matches(input, pattern);

            var patternIRL = "";
            foreach (Match item in regex)
            {
                patternIRL += item.Groups[2].ToString();
            }
            var replace = Regex.Replace(patternIRL, patternReplacment, " ");
            var removingWhities = Regex.Replace(replace, @"\s+|\n+", " ");

            StringBuilder sb = new StringBuilder(removingWhities.Length);

            foreach (var ch in removingWhities)
            {
                if (ch >= 'a' && ch <= 'm')
                {
                    sb.Append((char)(ch + 13));
                }
                else if (ch >= 'n' && ch <= 'z')
                {
                    sb.Append((char)(ch - 13));
                }
                else
                {
                    sb.Append(ch);
                }
            }
            string result = sb.ToString();
            Console.WriteLine(result);

        }
    }
}
