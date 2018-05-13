using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _22.Camera_View
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string text = Console.ReadLine();
            List<string> result = new List<string>();

            int skip = input[0];
            int take = input[1];

            string pattern = @"(?<=\|<\w{"+skip+"})(\\w{0,"+take+"})";

            MatchCollection views = Regex.Matches(text, pattern);

            foreach (Match view in views)
            {
                result.Add(view.Value);
            }
            Console.WriteLine(string.Join(", ", result));


        }
    }
}
