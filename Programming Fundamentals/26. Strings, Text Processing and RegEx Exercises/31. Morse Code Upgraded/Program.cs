using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _31.Morse_Code_Upgraded
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split('|').ToArray();
            //string[] input = "10101010101010101".Split('|').ToArray();
            //string zerosPattern = @"(^|(?<=1))[0](?=1|$)";
            string zerosPattern = @"[0]";
            //string onesPattern = @"(^|(?<=0))[1](?=0|$)";
            string onesPattern = @"[1]";
            string zerosPatternConsecutive = @"[0]{2,}";
            string onesPatternConsecutive = @"[1]{2,}";
            List<char> result = new List<char>();

            for (int i = 0; i < input.Length; i++)
            {
                MatchCollection zeros = Regex.Matches(input[i], zerosPattern);
                int singleZerosCount = zeros.Count * 3;

                MatchCollection ones = Regex.Matches(input[i], onesPattern);
                int singleOnesCount = ones.Count * 5;

                //---------------------------------------------------------
                MatchCollection zerosMultiple = Regex.Matches(input[i], zerosPatternConsecutive);
                MatchCollection onesMultiple = Regex.Matches(input[i], onesPatternConsecutive);
                int multipleZerosCount = 0;
                int multipleOnesCount = 0;

                //checking if there are consecutive zeros
                if (zerosMultiple.Count > 0)
                {
                    string summedZeros = "";
                    foreach (Match zero in zerosMultiple)
                    {
                        summedZeros += zero.Value;
                    }
                    multipleZerosCount = summedZeros.Length;
                }
                //cheking if there are consecutive ones
                if (onesMultiple.Count > 0)
                {
                    string summedOnes = "";
                    foreach (Match one in onesMultiple)
                    {
                        summedOnes += one.Value;
                    }
                    multipleOnesCount = summedOnes.Length;
                }

                //sum everything
                int sum = singleOnesCount + singleZerosCount + multipleZerosCount + multipleOnesCount;
                
                //add to char list
                result.Add((char)sum);
            }
            Console.WriteLine(string.Join("", result));
        }
    }
}
