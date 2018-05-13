using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.Regexmon
{
    class Program
    {
        static void Main(string[] args)
        {
            //string input = "!!!aa-aa?_?";
            string input = Console.ReadLine();

            Regex didimonPattern = new Regex(@"[^A-Za-z-]+");
            Regex bojomonPattern = new Regex(@"[a-zA-Z]+-{1}[a-zA-Z]+");

            bool lamp = false;
            int counter = 0;

            while (lamp !=true)
            {
                if (counter % 2 == 0)
                {
                    Match match = didimonPattern.Match(input);
                    if (match.Success)
                    {
                        string removedMatch = match.Value.ToString();
                        Console.WriteLine(match.Value.ToString());
                        int removing = input.IndexOf(removedMatch);
                        input = input.Remove(0, removedMatch.Length + removing);
                    }
                    else
                    {
                        lamp = true;
                    }

                    counter++;
                }

                else if (counter % 2 != 0)
                {
                    Match match = bojomonPattern.Match(input);
                    if (match.Success)
                    {
                        string removedMatch = match.Value.ToString();
                        Console.WriteLine(match.Value.ToString());
                        int removing = input.IndexOf(removedMatch);
                        input = input.Remove(0, removedMatch.Length + removing);
                    }
                    else
                    {
                        lamp = true;
                    }

                    counter++;
                }

            }
        }
    }
}
