using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _19.Replace_a_Tag
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"<a.*?href=(.*)>(.*?)<\/a>";
            string replacement = @"[URL href=$1]$2[/URL]";

            while (input != "end")
            {
                string replaced = Regex.Replace(input, pattern, replacement);
                Console.WriteLine(replaced);
                input = Console.ReadLine();
            }
        }
    }
}
