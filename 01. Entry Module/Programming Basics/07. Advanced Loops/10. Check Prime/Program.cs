using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Check_Prime
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberToCheck = int.Parse(Console.ReadLine());

            bool isPrime = true;
            if (numberToCheck <= 1)
            {
                isPrime = false;
            }
            for (int currentDevisor = 2; currentDevisor < numberToCheck; currentDevisor++)
            {
                if (numberToCheck % currentDevisor == 0)
                {
                    //TODO: To notify taht the number is not prime.
                    isPrime = false;
                    break;
                }
            }
            if (isPrime)
            {
                Console.WriteLine("Prime");
            }
            else
            {
                Console.WriteLine("Not Prime");
            }

        }
    }
}
