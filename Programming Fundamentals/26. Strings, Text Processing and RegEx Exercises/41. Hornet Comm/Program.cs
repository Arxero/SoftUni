using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _41.Hornet_Comm
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string patternPM = @"^([0-9]+)\s?<->\s?([0-9a-zA-z]+)$";
            string patternBC = @"^([^0-9]+)\s?<->\s?([0-9a-zA-z]+)$";

            List<string> resultPM = new List<string>();
            List<string> resultBC = new List<string>();

            while (input != "Hornet is Green")
            {

                Match pm = Regex.Match(input, patternPM);
                if (pm.Success)
                {
                    char[] recipientCode = pm.Groups[1].Value.ToString().ToCharArray().Reverse().ToArray();
                    string message = pm.Groups[2].Value.ToString();
                    string reversedCode = string.Join("", recipientCode);
                    string combined = reversedCode + " -> " + message;
                    resultPM.Add(combined);
                }

                Match bc = Regex.Match(input, patternBC);
                if (bc.Success)
                {
                    string message = bc.Groups[1].Value.ToString();
                    char[] frequency = bc.Groups[2].Value.ToString().ToCharArray();
                    for (int i = 0; i < frequency.Length; i++)
                    {
                        if (char.IsUpper(frequency[i]))
                        {
                            frequency[i] = char.ToLower(frequency[i]);
                        }
                        else if (char.IsLower(frequency[i]))
                        {
                            frequency[i] = char.ToUpper(frequency[i]);
                        }
                    }
                    string joined = string.Join("", frequency);
                    string combined = joined + " -> " + message;
                    resultBC.Add(combined);
                }
                input = Console.ReadLine();
            }

            Console.WriteLine("Broadcasts:");
            if (resultBC.Count == 0)
            {
                Console.WriteLine("None");
            }
            else
            {
                foreach (var broadcast in resultBC)
                {
                    Console.WriteLine(broadcast);
                }
            }
            Console.WriteLine("Messages:");
            if (resultPM.Count == 0)
            {
                Console.WriteLine("None");
            }
            else
            {
                foreach (var message in resultPM)
                {
                    Console.WriteLine(message);
                }
            }
        }
    }
}
