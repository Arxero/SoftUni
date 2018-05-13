using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Exam___6_March_2016_01.Training_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            double w = double.Parse(Console.ReadLine()); // 4:10
            double h = double.Parse(Console.ReadLine());

            double height = Math.Floor((h * 100 - 100) / 70);
            double width = Math.Floor((w * 100) / 120);
            double numSeats = height * width - 3;

            Console.WriteLine($"{numSeats}");

        }
    }
}
