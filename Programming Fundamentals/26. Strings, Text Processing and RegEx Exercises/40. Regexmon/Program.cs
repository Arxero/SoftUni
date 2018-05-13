using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _40.Regexmon
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string patternDidimon = @"[^a-zA-Z-]+";
            string patternBojomon = @"[a-zA-Z]+-[a-zA-Z]+";

            while (true)
            {
                Match didimon = Regex.Match(input, patternDidimon);
                if (didimon.Success)
                {
                    Console.WriteLine(didimon.Value.ToString());
                }
                else
                {
                    break;
                }
                string didimonString = didimon.ToString();
                int indexDidi = input.IndexOf(didimonString);
                input = input.Remove(0, indexDidi + didimonString.Length);
                //input = input.Substring(indexDidi + didimonString.Length);

                Match bojomon = Regex.Match(input, patternBojomon);
                if (bojomon.Success)
                {
                    Console.WriteLine(bojomon.Value.ToString());
                }
                else
                {
                    break;
                }

                string bojomonString = bojomon.ToString();
                int indexBojo = input.IndexOf(bojomonString);
                //input = input.Substring(indexBojo + bojomonString.Length);
                input = input.Remove(0, indexBojo + bojomonString.Length);

            }
        }
    }
}
