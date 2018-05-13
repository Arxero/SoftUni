using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Powers_of_Two
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxNumber = int.Parse(Console.ReadLine());
            int novaPromenliva = 1;

            for (int currentNumber = 0;  currentNumber <= maxNumber;  currentNumber++)
            {
                Console.WriteLine(novaPromenliva);
                novaPromenliva *= 2;
            }
        }
    }
}
