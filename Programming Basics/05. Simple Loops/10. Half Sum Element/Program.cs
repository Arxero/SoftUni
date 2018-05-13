using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Half_Sum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int cycles = int.Parse(Console.ReadLine());

            int maximum = 0;
            int sumAll = 0;

            for (int i = 0; i < cycles; i++)
            {
                int numberToRead = int.Parse(Console.ReadLine());
                if (numberToRead > maximum)
                {
                    maximum = numberToRead;
                }
                sumAll += numberToRead;
            }
            if ((sumAll - maximum) == maximum)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {maximum}");
            }
            else
            {
                int substracted = Math.Abs(sumAll - maximum * 2);
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {substracted}");
            }
        }
    }
}
