using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Trapeziod_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            //Reading Element
            Console.Write("b1=");
            double b1 = double.Parse(Console.ReadLine());
            Console.Write("b2=");
            double b2 = double.Parse(Console.ReadLine());
            Console.Write("h=");
            double h = double.Parse(Console.ReadLine());

            //Calculating Element
            Console.WriteLine("Answer: {0}" , (b1 + b2) * h / 2);


        }
    }
}
