using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Sum_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int rotations = int.Parse(Console.ReadLine());

            int sum = 0;
            for (int i = 1; i <= rotations; i++)
            {  
                int currentNumber = int.Parse(Console.ReadLine());
                sum = sum + currentNumber; // sum += currentNumber
            }
            Console.WriteLine(sum);
        }
    }
}
