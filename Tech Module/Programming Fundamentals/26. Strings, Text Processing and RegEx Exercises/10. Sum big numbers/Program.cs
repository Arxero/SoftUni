using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _10.Sum_big_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger input = BigInteger.Parse(Console.ReadLine());
            BigInteger input2 = BigInteger.Parse(Console.ReadLine());
            Console.WriteLine(input + input2);
        }
    }
}
