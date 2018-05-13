using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Greater_of_Two_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            if (input == "int")
            {
                int first = int.Parse(Console.ReadLine());
                int second = int.Parse(Console.ReadLine());
                int max = GetMax(first, second);
                Console.WriteLine(max);
            }
            else if (input == "char")
            {
                char first = char.Parse(Console.ReadLine());
                char second = char.Parse(Console.ReadLine());
                int max = GetMax(first, second);
                Console.WriteLine((char)max);
            }
            else if (input == "string")
            {
                string first = Console.ReadLine();
                string second = Console.ReadLine();
                string max = GetMax(first, second);
                Console.WriteLine(max);
            }
        }

        static int GetMax(int first, int second)
        {
            int result = 0;

            if (first >= second)
            {
                result = first;
            }
            else if (second >= first)
            {
                result = second;
            }
            else if (first == second)
            {
                result = first;
            }
            return result;
        }

        static char GetMax(char first, char second)
        {
            int result = 0;

            if (first >= second)
            {
                result = first;
            }
            else if (second >= first)
            {
                result = second;
            }
            else if (first == second)
            {
                result = first;
            }
            return (char)result;
        }
        static string GetMax(string first, string second)
        {
            string result = "";
            if (first.CompareTo(second) >= 0)
            {
                result = first;
            }
            else if (second.CompareTo(first) >= 0)
            {
                result = second;
            }
            else if (first.CompareTo(second) == 0)
            {
                result = first;
            }
            return result;
        }
    }
}
