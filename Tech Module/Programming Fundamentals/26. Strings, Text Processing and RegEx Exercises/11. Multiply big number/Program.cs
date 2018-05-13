using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _11.Multiply_big_number
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger input = BigInteger.Parse(Console.ReadLine());
            BigInteger input2 = BigInteger.Parse(Console.ReadLine());
            Console.WriteLine(input * input2);
        }
    }
}
