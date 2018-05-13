using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Multiply_Evens_by_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(GetMultipleOfEvensAndOdds(n));
        }
        //even and odd
        private static int GetMultipleOfEvensAndOdds(int n)
        {
            int sumEvens = GetSumOfEvenDigits(n);
            int sumOdds = GetSumOfOddDigits(n);
            return sumEvens * sumOdds;
        }
        //odd numbers
        private static int GetSumOfOddDigits(int n)
        {
            int sum = 0;
            n = Math.Abs(n);
            while (n > 0)
            {
                int lastDigit = n % 10;
                if (lastDigit % 2 !=0)
                {
                    sum += lastDigit;
                }
                n = n / 10;
            }
            return sum;
        }
        //even numbers
        private static int GetSumOfEvenDigits(int n)
        {
            int sum = 0;
            n = Math.Abs(n);
            while (n > 0)
            {
                int lastDigit = n % 10;
                if (lastDigit % 2 == 0)
                {
                    sum += lastDigit;
                }
                n = n / 10;
            }
            return sum;
        }
    }
}
