using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _05.Key_Replacer
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] key = Console.ReadLine().Split('|', '<', '\\').ToArray();
            string text = Console.ReadLine();

            var start = key[0];
            var end = key[2];

            string pattern = $@"(?<=({start})).+?(?<=({end}))";
            var regex = Regex.Matches(text, pattern);

            var result = new StringBuilder();
            foreach (Match item in regex)
            {

                result.Append(item);
                result.Replace(end, "");

            }
            if (result.Length == 0)
            {
                Console.WriteLine("Empty result");
            }
            else
            {
                Console.WriteLine(result);
            }
        }
    }
}
