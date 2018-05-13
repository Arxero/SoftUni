using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _12.Winning_Ticket
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new string[] { " ", "," }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            Regex pattern6 = new Regex(@"([@#$^]{6})");
            Regex pattern10 = new Regex(@"([@#$^]{10})");
            Regex pattern1Of6 = new Regex(@"([@#$^]{1})");


            for (int i = 0; i < input.Length; i++)
            {
                Match matchTicket6 = pattern6.Match(input[i]);
                Match matchTicket10 = pattern10.Match(input[i]);
                Match matchTicket1Of6 = pattern1Of6.Match(matchTicket6.ToString());
                Match matchTicket1Of10 = pattern1Of6.Match(matchTicket10.ToString());


                if (input[i].Length != 20)
                {
                    Console.WriteLine("invalid ticket");
                }
                else if (!(matchTicket6.Success || matchTicket10.Success))
                {
                    Console.WriteLine($"ticket {(char)34}{input[i]}{(char)34} - no match");
                }
                else if (matchTicket6.Success && !matchTicket10.Success)
                {
                    Console.WriteLine($"ticket {(char)34}{input[i]}{(char)34} - 6{matchTicket1Of6}");
                }
                else if (matchTicket10.Success)
                {
                    Console.WriteLine($"ticket {(char)34}{input[i]}{(char)34} - 10{matchTicket1Of10} Jackpot!");
                }
            }


        }
    }
}
