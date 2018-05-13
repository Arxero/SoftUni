using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Number_in_Range__1._._._100_
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxNumber = int.Parse(Console.ReadLine());

            //bool isInRange = maxNumber >= 1 && maxNumber <= 100;

            while (maxNumber < 1 || maxNumber > 100)
            {
                Console.WriteLine("Invalid number!");
                maxNumber = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("The number is:{0}", maxNumber);

        }
    }
}
