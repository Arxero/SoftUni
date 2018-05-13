using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_100_200
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int firstNum = num / 10;
            int secondNum = num % 10;
            int bothNum = num;

            string firstWord = "";
            string secondWord = "";
            string bothWords = "";

            switch (secondNum)
            {
                case 0: secondWord = "zero"; break;
                case 1: secondWord = "one"; break;
                case 2: secondWord = "two"; break;
                case 3: secondWord = "three"; break;
                case 4: secondWord = "four"; break;
                case 5: secondWord = "five"; break;
                case 6: secondWord = "six"; break;
                case 7: secondWord = "seven"; break;
                case 8: secondWord = "eight"; break;
                case 9: secondWord = "nine"; break;
            }

            switch (firstNum)
            {
                case 2: firstWord = "twenty"; break;
                case 3: firstWord = "thirty"; break;
                case 4: firstWord = "forty"; break;
                case 5: firstWord = "fifty"; break;
                case 6: firstWord = "sixty"; break;
                case 7: firstWord = "seventy"; break;
                case 8: firstWord = "eighty"; break;
                case 9: firstWord = "ninety"; break;
            }

            switch (bothNum)
            {
                case 10: bothWords = "ten"; break;
                case 11: bothWords = "eleven"; break;
                case 12: bothWords = "twelve"; break;
                case 13: bothWords = "thirteen"; break;
                case 14: bothWords = "fourteen"; break;
                case 15: bothWords = "fifteen"; break;
                case 16: bothWords = "sixteen"; break;
                case 17: bothWords = "seventeen"; break;
                case 18: bothWords = "eighteen"; break;
                case 19: bothWords = "nineteen"; break;
            }
            if (num < 0)
            {
                Console.WriteLine("invalid number");
            }
            else if (num < 10)
            {
                Console.WriteLine($"{secondWord}");
            }
            else if (num < 20)
            {
                Console.WriteLine($"{bothWords}");
            }
            else if (num % 10 == 0 && num != 10 && num != 100)
            {
                Console.WriteLine($"{firstWord}");
            }
            else if (num < 100)
            {
                Console.WriteLine($"{firstWord} {secondWord}");
            }
            else if (num == 100)
            {
                Console.WriteLine("one hundred");
            }
            else
            {
                Console.WriteLine("invalid number");
            }

        }
    }
}