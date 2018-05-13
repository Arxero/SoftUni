using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Letters_Change_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            //string[] input = "A12b s17G".Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            //alphabet recreation
            char[] alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
            List<double> result = new List<double>();

            for (int i = 0; i < input.Length; i++)
            {
                int letterPosition = 0;
                char[] word = input[i].ToUpper().ToCharArray();
                char letter = word[0];

                //get first letter position in the alphabet
                for (int k = 0; k < alphabet.Length; k++)
                {
                    if (letter == alphabet[k])
                    {
                        letterPosition = k + 1;
                        break;
                    }
                }

                char[] word2 = input[i].ToCharArray();

                //to get the number
                List<char> copyOfInput = new List<char>();
                copyOfInput.AddRange(word2);
                copyOfInput.Remove(copyOfInput.First());
                copyOfInput.Remove(copyOfInput.Last());
                double joined = double.Parse(string.Join("", copyOfInput));

                //for the first letter
                if (char.IsUpper(word2.First()))
                {
                    joined /= letterPosition * 1.0;
                }
                else if (char.IsLower(word2.First()))
                {
                    joined *= letterPosition;
                }
                //____________end calculation for first letter

                //get first letter position in the alphabet
                char letterSecond = word[word.Length - 1];
                for (int k = 0; k < alphabet.Length; k++)
                {
                    if (letterSecond == alphabet[k])
                    {
                        letterPosition = k + 1;
                        break;
                    }
                }

                //for the last letter
                if (char.IsUpper(word2.Last()))
                {
                    joined -= letterPosition;
                }
                else if (char.IsLower(word2.Last()))
                {
                    joined += letterPosition;
                }

                result.Add(joined);


            }
            Console.WriteLine($"{result.Sum():f2}");
        }
    }
}
