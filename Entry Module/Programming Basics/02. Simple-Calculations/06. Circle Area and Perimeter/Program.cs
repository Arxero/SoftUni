using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Circle_Area_and_Perimeter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Your number=");
            double number = double.Parse(Console.ReadLine());

            double area = Math.PI * number * number;
            double perimeter = 2 * Math.PI * number;
            Console.WriteLine("Area {0}", area);
            Console.WriteLine("Perimeter {0}" , perimeter);

        }
    }
}
