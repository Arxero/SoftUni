using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _05.Convert_from_base_10_to_base_N
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger[] input = Console.ReadLine().Split(' ').Select(BigInteger.Parse).ToArray();

            BigInteger numberBaseToBeConverted = input[0];
            BigInteger num = input[1];
            BigInteger remainder = 0;
            string result = "";

            while (num > 0)
            {
                remainder = num % numberBaseToBeConverted;
                num = num / numberBaseToBeConverted;
                result = result + remainder.ToString();
            }
            Console.WriteLine(string.Join("", result.Reverse()));
        }
    }
}
