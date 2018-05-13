using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _39.Phoenix_Grid
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"((^|(?<=\s))([^\s_]{3})($|(?=\s)))|(^|(?<=\s))[^\s_]{3}(\.[^\s_]{3})*($|(?=\s))";

            while (input != "ReadMe")
            {
                Match phrase = Regex.Match(input, pattern);
                if (phrase.Success)
                {
                    string message = phrase.Value;
                    char[] messageToChar = phrase.Value.ToCharArray();
                    var reversedCollection = message.Reverse().ToArray();
                    string reversed = string.Join("", reversedCollection);

                    if (message == reversed)
                    {
                        Console.WriteLine("YES");
                    }
                    else
                    {
                        Console.WriteLine("NO");
                    }
                }
                else
                {
                    Console.WriteLine("NO");
                }
                input = Console.ReadLine();
            }
        }
    }
}
