using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.Number_0._._._100_to_Text
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            string answer = "";

            string one = "one";
            string two = "two";
            string three = "three";
            string four = "four";
            string five = "five";
            string six = "six";
            string seven = "seven";
            string eight = "eight";
            string nine = "nine";
            string ten = "ten";


            if (number == 1)
                answer = one;
            else if (number == 0)
                answer = "zero";
            else if (number == 2)
                answer = two;
            else if (number == 3)
                answer = three;
            else if (number == 4)
                answer = four;
            else if (number == 5)
                answer = five;
            else if (number == 6)
                answer = six;
            else if (number == 7)
                answer = seven;
            else if (number == 8)
                answer = eight;
            else if (number == 9)
                answer = nine;
            else if (number == 10)
                answer = ten;
            else if (number == 11)
                answer = "eleven";
            else if (number == 12)
                answer = "twelve";
            else if (number == 13)
                answer = "thirteen";
            else if (number == 14)
                answer = "fourteen";
            else if (number == 15)
                answer = "fifteen";
            else if (number == 16)
                answer = "sixteen";
            else if (number == 17)
                answer = "seventeen";
            else if (number == 18)
                answer = "eightteen";
            else if (number == 19)
                answer = "nineteen";
            else if (number == 20)
                answer = "twenty";
            else if (number == 21)
                answer = "twenty one";
            else if (number == 22)
                answer = "twenty two";
            else if (number == 23)
                answer = "twenty three";
            else if (number == 24)
                answer = "twenty four";
            else if (number == 25)
                answer = "twenty five";
            else if (number == 26)
                answer = "twenty six";
            else if (number == 27)
                answer = "twenty seven";
            else if (number == 28)
                answer = "twenty eight";
            else if (number == 29)
                answer = "twenty nine";
            else if (number == 30)
                answer = "thirty";
            else if (number == 31)
                answer = "thirty one";
            else if (number == 32)
                answer = "thirty two";
            else if (number == 33)
                answer = "thirty three";
            else if (number == 34)
                answer = "thirty four";
            else if (number == 35)
                answer = "thirty five";
            else if (number == 36)
                answer = "thirty six";
            else if (number == 37)
                answer = "thirty seven";
            else if (number == 38)
                answer = "thirty eight";
            else if (number == 39)
                answer = "thirty nine";
            else if (number == 40)
                answer = "forty";
            else if (number == 41)
                answer = "forty one";
            else if (number == 42)
                answer = "forty two";
            else if (number == 43)
                answer = "forty three";
            else if (number == 44)
                answer = "forty four";
            else if (number == 45)
                answer = "forty five";
            else if (number == 46)
                answer = "forty six";
            else if (number == 47)
                answer = "forty seven";
            else if (number == 48)
                answer = "forty eight";
            else if (number == 49)
                answer = "forty nine";
            else if (number == 50)
                answer = "fifty";

            else if (number == 51)
                answer = "fifty one";
            else if (number == 52)
                answer = "fifty two";
            else if (number == 53)
                answer = "fifty three";
            else if (number == 54)
                answer = "fifty four";
            else if (number == 55)
                answer = "fifty five";
            else if (number == 56)
                answer = "fifty six";
            else if (number == 57)
                answer = "fifty seven";
            else if (number == 58)
                answer = "fifty eight";
            else if (number == 59)
                answer = "fifty nine";
            else if (number == 60)
                answer = "sixty";
            else if (number == 61)
                answer = "sixty one";
            else if (number == 62)
                answer = "sixty two";
            else if (number == 63)
                answer = "sixty three";
            else if (number == 64)
                answer = "sixty four";
            else if (number == 65)
                answer = "sixty five";
            else if (number == 66)
                answer = "sixty 66";
            else if (number == 67)
                answer = "sixty seven";
            else if (number == 68)
                answer = "sixty eight";
            else if (number == 69)
                answer = "sixty nine";
            else if (number == 70)
                answer = "seventy";
            else if (number == 71)
                answer = "seventy one";
            else if (number == 722)
                answer = "seventy two";
            else if (number == 73)
                answer = "seventy three";
            else if (number == 74)
                answer = "seventy four";
            else if (number == 75)
                answer = "seventy five";
            else if (number == 76)
                answer = "seventy six";
            else if (number == 77)
                answer = "seventy seven";
            else if (number == 78)
                answer = "seventy eight";
            else if (number == 79)
                answer = "seventy nine";
            else if (number == 80)
                answer = "eighty";
            else if (number == 81)
                answer = "eighty one";
            else if (number == 82)
                answer = "eighty two";
            else if (number == 83)
                answer = "eighty three";
            else if (number == 84)
                answer = "eighty four";
            else if (number == 85)
                answer = "eighty five";
            else if (number == 86)
                answer = "eighty six";
            else if (number == 87)
                answer = "eighty seven";
            else if (number == 88)
                answer = "eighty eight";
            else if (number == 89)
                answer = "eighty nine";
            else if (number == 90)
                answer = "ninety";
            else if (number == 91)
                answer = "ninety one";
            else if (number == 92)
                answer = "ninety two";
            else if (number == 93)
                answer = "ninety three";
            else if (number == 94)
                answer = "ninety four";
            else if (number == 95)
                answer = "ninety five";
            else if (number == 96)
                answer = "ninety six";
            else if (number == 97)
                answer = "ninety seven";
            else if (number == 98)
                answer = "ninety eight";
            else if (number == 99)
                answer = "ninety nine";
            else if (number == 100)
                answer = "one hundred";
            else if (number < 0)
            {
                Console.WriteLine("invalid number");
            }
            else if (number > 100)
                    {
                Console.WriteLine("invalid number");
                    }
            Console.WriteLine(answer);
        }
    }
}
