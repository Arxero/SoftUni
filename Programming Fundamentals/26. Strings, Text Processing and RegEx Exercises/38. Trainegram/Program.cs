using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _38.Trainegram
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"^<\[[^a-zA-Z0-9]*]\.(\.\[[a-zA-Z0-9]*]\.)*$";

            while (input != "Traincode!")
            {
                Match train = Regex.Match(input, pattern);

                if (train.Success)
                {
                    Console.WriteLine(train);
                }

                input = Console.ReadLine();
            }
        }
    }
}
