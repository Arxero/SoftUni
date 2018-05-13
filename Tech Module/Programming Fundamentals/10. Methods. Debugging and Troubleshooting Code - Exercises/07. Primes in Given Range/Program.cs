using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Primes_in_Given_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            string numbers = String.Join(", ", GetPrimeNumberInRange(n1, n2).ToArray());
            Console.WriteLine(numbers);

        }
        static List<int> GetPrimeNumberInRange(int number, int number2)
        {
            var result = new List<int>();
            for (int i = number; i <= number2; i++)
            {
                bool isPrime = true;
                if (i < 2) isPrime = false;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    result.Add(i);
                }
            }
            return result;
        }
    }
}
