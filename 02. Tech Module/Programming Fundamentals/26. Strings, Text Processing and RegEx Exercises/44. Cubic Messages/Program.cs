using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _44.Cubic_Messages
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            //string input = "1234test4321";

            while (input != "Over!")
            {
                //int number = int.Parse(Console.ReadLine());
                int number = int.Parse(Console.ReadLine());
                string pattern = @"^[0-9]+([a-zA-Z]{"+number+"})[^a-zA-Z]*$";
                Match message = Regex.Match(input, pattern);

                char[] messageArr = message.Groups[1].ToString().ToArray();

                if (message.Success)
                {
                    int[] nums = Regex.Matches(input, "[0-9]").Cast<Match>().Select(m => m.Value).ToArray().Select(int.Parse).ToArray();
                    char[] elements = new char[nums.Length];

                    for (int i = 0; i < nums.Length; i++)
                    {
                        if (nums[i] > messageArr.Length - 1)
                        {
                            elements[i] = ' ';
                        }
                        else
                        {
                            elements[i] = messageArr[nums[i]];
                        }
                    }
                    string result = string.Join("", elements);
                    Console.WriteLine($"{message.Groups[1]} == {result}");
                }
                input = Console.ReadLine();
            }
        }
    }
}
