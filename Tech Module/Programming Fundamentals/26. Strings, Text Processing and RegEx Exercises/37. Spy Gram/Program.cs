using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _37.Spy_Gram
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] key = Console.ReadLine().ToString().Select(t => int.Parse(t.ToString())).ToArray();
            string input = Console.ReadLine();

            string pattern = @"^TO:\s([A-Z]+);\sMESSAGE:\s(.+);$";
            List<string> result = new List<string>();
            List<string> pendingMessages = new List<string>();

            while (input != "END")
            {
                pendingMessages.Add(input);
                input = Console.ReadLine();
            }

            pendingMessages.Sort();

            for (int k = 0; k < pendingMessages.Count; k++)
            {
                Match matching = Regex.Match(pendingMessages[k], pattern);
                //string message = matching.Groups[1].Value;
                if (matching.Success)
                {
                    string message = matching.Value;
                    char[] messageChars = message.ToCharArray();

                    //making an array long enough with repeating elements
                    List<int> repeatedKeys = new List<int>();
                    for (int i = 0; i < messageChars.Length; i++)
                    {
                        repeatedKeys.AddRange(key);
                    }

                    for (int i = 0; i < messageChars.Length; i++)
                    {
                        int charToInt = messageChars[i] + repeatedKeys[i];
                        messageChars[i] = (char)charToInt;
                    }

                    Console.WriteLine(string.Join("", messageChars));
                }
            }
        }
    }
}
