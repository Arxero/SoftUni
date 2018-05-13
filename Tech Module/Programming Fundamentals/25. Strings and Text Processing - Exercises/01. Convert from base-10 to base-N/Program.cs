using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _01.Convert_from_base_10_to_base_N
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger[] input = Console.ReadLine().Split(' ').Select(BigInteger.Parse).ToArray();

            BigInteger numberBaseToBeConverted = input[0];
            BigInteger num = input[1];

            List<BigInteger> result = new List<BigInteger>();

            while (num > 0)
            {
                BigInteger remainder = num % numberBaseToBeConverted;
                result.Add(remainder);
                num = num / numberBaseToBeConverted;
            }
            result.Reverse();
            Console.WriteLine(string.Join("", result));
        }
    }
}
