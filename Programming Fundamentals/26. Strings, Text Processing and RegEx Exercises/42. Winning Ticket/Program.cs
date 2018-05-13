using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _42.Winning_Ticket
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new[] { ",", " " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            string pattern = @"(\@{6,}|\${6,}|\^{6,}|\#{6,})";

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i].Length != 20)
                {
                    Console.WriteLine("invalid ticket");
                }
                else
                {
                    string left = input[i].Substring(0, 10);
                    Match ticketLeft = Regex.Match(left, pattern);

                    string right = input[i].Substring(10);
                    Match ticketRight = Regex.Match(right, pattern);

                    if (ticketLeft.Success && ticketRight.Success)
                    {
                        if (ticketLeft.Length == 10 && ticketRight.Length == 10)
                        {
                            Console.WriteLine($@"ticket ""{input[i]}"" - {ticketLeft.Value.Length}{ticketLeft.Value.First()} Jackpot!");
                        }
                        else
                        {
                            Console.WriteLine($@"ticket ""{input[i]}"" - {Math.Min(ticketLeft.Length, ticketRight.Length)}{ticketLeft.Value.First()}");
                        }
                    }
                    else
                    {
                        Console.WriteLine($@"ticket ""{input[i]}"" - no match");
                    }
                }
            }
        }
    }
}
