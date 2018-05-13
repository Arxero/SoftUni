using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _25.Anonymous_Vox
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            //string values = Console.ReadLine();
            string[] values = Console.ReadLine().Split(new[] { "{", "}" }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            Regex start = new Regex(@"^([a-zA-Z]+)");
            Regex end = new Regex(@"([a-zA-Z]+)$");
            string pattern1 = @"^([a-zA-Z]+)";
            string pattern2 = @"([a-zA-Z]+)$";

            Match matchStart = start.Match(input);
            Match matchEnd = end.Match(input);
            StringBuilder sb = new StringBuilder();

            if (matchStart.Success && matchEnd.Success)
            {
                var mystring = Regex.Replace(input, pattern1, "");
                var mystring2 = Regex.Replace(mystring, pattern2, "");
                mystring2 = values[0];
                sb.Append(matchStart);
                sb.Append(mystring2);
                sb.Append(matchEnd);
            }
            Console.WriteLine(sb);
            



        }
    }
}
