using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxNumber = int.Parse(Console.ReadLine());

            for (int currentNumber = 0; currentNumber < maxNumber; currentNumber++)
            {
                Console.WriteLine(maxNumber - currentNumber);
            }
        }
    }
}