using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Math_Power
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());
            double answer = RaiseToPower(number, power);
            Console.WriteLine(answer);
        }

        static double RaiseToPower(double number, int power)
        {
            double result = 0d;
            result = Math.Pow(number, power);
                return result;
        }
    }
}
