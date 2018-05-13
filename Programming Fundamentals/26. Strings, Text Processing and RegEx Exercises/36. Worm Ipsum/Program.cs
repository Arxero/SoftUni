using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _36.Worm_Ipsum
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"^[A-Z][^\.]+\.$";


            while (input != "Worm Ipsum")
            {
                MatchCollection sentences = Regex.Matches(input, pattern);

                if (sentences.Count == 1)
                {
                    string[] sentence = sentences[0].Value.Split(new[] { " ", "." }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                    string letter = "";
                    int appearanceCount = 0;
                    int appearanceCountMax = 0;

                    List<string> result = new List<string>();
                    //loop for every word in sentence
                    for (int i = 0; i < sentence.Length; i++)
                    {
                        char[] wordInChars = sentence[i].ToCharArray();

                        int mostOccurrence = -1;
                        char mostOccuringChar = ' ';
                        string hyphen = "";
                        foreach (var currentChar in wordInChars)
                        {
                            if (currentChar == ',')
                            {

                                hyphen = currentChar.ToString();
                                break;
                            }
                            int foundCharOccurance = 0;
                            foreach (var charToBeMatch in wordInChars)
                            {
                                if (currentChar == charToBeMatch)
                                {
                                    foundCharOccurance++;
                                }
                            }
                            if (mostOccurrence < foundCharOccurance)
                            {
                                mostOccurrence = foundCharOccurance;
                                mostOccuringChar = currentChar;
                            }
                        }
                        char a = mostOccuringChar;
                        if (mostOccurrence > 1)
                        {
                            if (hyphen == ",")
                            {
                                sentence[i] = new string(a, sentence[i].Length - 1) + hyphen;
                            }
                            else
                            {
                                sentence[i] = new string(a, sentence[i].Length);
                            }

                        }
                        result.Add(sentence[i]);
                    }
                    Console.WriteLine($"{string.Join(" ", result)}.");

                }

                input = Console.ReadLine();
            }
        }
    }
}
