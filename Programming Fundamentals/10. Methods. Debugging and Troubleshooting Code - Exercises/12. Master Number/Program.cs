using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Master_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            n = n % 100;
            Console.WriteLine(n);
            // to get the one before last digit
            n = n % 100;
            n = n / 10;
            //Console.WriteLine(n);
        }
        static int IsPalindrome(int n)
        {

            return n;
        }
    }
}
