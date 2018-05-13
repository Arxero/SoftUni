using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Prime_Checker
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            Console.WriteLine(GetPrimeNumber(n));
        }
        static bool GetPrimeNumber(long number)
        {
            if (number == 1) return false;
            if (number == 2) return true;
            if (number == 0) return false;

            for (long i = 2; i <= Math.Ceiling(Math.Sqrt(number)); ++i)
            {
                if (number % i == 0) return false;
            }

            return true;
        }
    }
}
