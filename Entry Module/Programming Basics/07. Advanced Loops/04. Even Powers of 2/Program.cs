using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Even_Powers_of_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxNumber = int.Parse(Console.ReadLine());
            int num = 1;

            for (int currentNumber = 0; currentNumber <= maxNumber; currentNumber +=2)
            {
                Console.WriteLine(num);
                num *= 4;
            }
        }
    }
}
