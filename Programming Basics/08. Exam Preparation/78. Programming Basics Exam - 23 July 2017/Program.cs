using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _78.Programming_Basics_Exam___23_July_2017
{
    class Program
    {
        static void Main(string[] args)
        {
            double L = double.Parse(Console.ReadLine()); // 8:53
            double W = double.Parse(Console.ReadLine());
            double A = double.Parse(Console.ReadLine());

            double size = (L * 100) * (W * 100);
            double wardrobe = (A * 100) * (A * 100);
            double bench = size / 10;
            double freeSpace = size - wardrobe - bench;
            double dancers = Math.Floor(freeSpace / (40 + 7000));
            Console.WriteLine($"{dancers}");
        }
    }
}
