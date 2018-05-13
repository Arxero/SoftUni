using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _06.Hornet_Comm
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            //string input = "123321 -> Foxtrot";

            List<string> messages = new List<string>();
            List<string> broadcasts = new List<string>();

            Regex privateMessage = new Regex(@"^([0-9]+)\s?<->\s?([0-9a-zA-z]+)$");
            Regex broadCast = new Regex(@"^([^0-9]+)\s?<->\s?([0-9a-zA-z]+)$");

            while (input != "Hornet is Green")
            {
                Match matchPM = privateMessage.Match(input);
                Match matchBC = broadCast.Match(input);
                //message
                if (matchPM.Success)
                {
                    var recipient = string.Join("", matchPM.Groups[1].Value.Reverse());
                    string message = matchPM.Groups[2].Value.ToString();
                    messages.Add(recipient + " -> " + message);
                }
                //broadcast
                if (matchBC.Success)
                {
                    var message = matchBC.Groups[1].Value;
                    var frequency = DecryptFrequency(matchBC.Groups[2].Value);
                    broadcasts.Add(frequency + " -> " + message);
                }

                input = Console.ReadLine();
            }

            Console.WriteLine("Broadcasts:");

            if (broadcasts.Count > 0)
            {
                Console.WriteLine(string.Join("\n", broadcasts));
            }
            else
            {
                Console.WriteLine("None");
            }

            Console.WriteLine("Messages:");

            if (messages.Count > 0)
            {
                Console.WriteLine(string.Join("\n", messages));
            }
            else
            {
                Console.WriteLine("None");
            }


        }
        private static string DecryptFrequency(string encryptedFrequency)
        {
            string decryptedFrequency = "";

            foreach (char currentChar in encryptedFrequency)
            {
                if (currentChar >= 65 && currentChar <= 90)
                {
                    decryptedFrequency += (char)(currentChar + 32);
                }
                else if (currentChar >= 97 && currentChar <= 122)
                {
                    decryptedFrequency += (char)(currentChar - 32);
                }
                else
                {
                    decryptedFrequency += currentChar;
                }
            }
            return decryptedFrequency;
        }
    }
}
