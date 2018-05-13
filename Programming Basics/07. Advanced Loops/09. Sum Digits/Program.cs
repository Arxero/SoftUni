using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Sum_Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int result = 0;

            do
            {
                int currentLastDigit = n % 10;
                n /= 10;
                result += currentLastDigit;
            } while (n > 0);
            Console.WriteLine(result);
        }
    }
}
