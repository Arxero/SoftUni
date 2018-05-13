using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Greater_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter tow integers: ");
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            if (firstNumber >= secondNumber)
            {
                Console.WriteLine("Greater number is: " + firstNumber);
            }
            else
            {
                Console.WriteLine("Greater number is: " + secondNumber);
            }
        }
    }
}
