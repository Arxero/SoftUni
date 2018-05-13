using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Sieve_of_Eratosthenes
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            bool[] a = new bool[input + 1];

            //initially all set to true.
            for (int i = 2; i <= input; i++)
            {
                a[i] = true;    //set all numbers to true
            }

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == true)
                {
                    for (int j = 2; i * j < input; j++)
                    {
                        a[i * j] = false;
                    }
                }
            }
            for (int i = 2; i <= input; i++)
            {
                if (a[i] == true)
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine();

        }
    }
}
