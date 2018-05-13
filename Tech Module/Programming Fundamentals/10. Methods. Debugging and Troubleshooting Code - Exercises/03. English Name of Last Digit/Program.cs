using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.English_Name_of_Last_Digit
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            Console.WriteLine(GetNameFromLastDigit(Math.Abs(n)));
        }
        static string GetNameFromLastDigit(long n)
        {
            long lastDigit = n % 10;
            string lastDigitAsText = "";

            switch (lastDigit)
            {
                case 0:
                    lastDigitAsText = "zero";
                    break;
                case 1:
                    lastDigitAsText = "one";
                    break;
                case 2:
                    lastDigitAsText = "two";
                    break;
                case 3:
                    lastDigitAsText = "three";
                    break;
                case 4:
                    lastDigitAsText = "four";
                    break;
                case 5:
                    lastDigitAsText = "five";
                    break;
                case 6:
                    lastDigitAsText = "six";
                    break;
                case 7:
                    lastDigitAsText = "seven";
                    break;
                case 8:
                    lastDigitAsText = "eight";
                    break;
                case 9:
                    lastDigitAsText = "nine";
                    break;
            }
            return lastDigitAsText;
        }
    }
}
