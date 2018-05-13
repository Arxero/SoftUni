using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16._1__Magic_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int magicNumber = int.Parse(Console.ReadLine());

            for (int cycles = 100000; cycles <= 999999; cycles++)
            {
                int result = 1;
                int n = cycles;
                do
                {
                    result = result * (n % 10);
                    n = n / 10;
                    
                } while (n > 0);
                if (result == magicNumber)
                {
                    Console.Write($"{cycles} ");
                }
            }

        }
    }
}
