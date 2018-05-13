using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24.Football_League
{
    class Program
    {
        static void Main(string[] args)
        {
            double stadion = double.Parse(Console.ReadLine()); // 6:36
            int fans = int.Parse(Console.ReadLine());

            double sectorA = 0;
            double sectorB = 0;
            double sectorV = 0;
            double sectorG = 0;

            for (int i = 0; i < fans; i++)
            {
                string sector = Console.ReadLine().ToLower();

                switch (sector)
                {
                    case "a":
                        sectorA++;
                        break;
                    case "b":
                        sectorB++;
                        break;
                    case "v":
                        sectorV++;
                        break;
                    case "g":
                        sectorG++;
                        break;
                }
            }
            Console.WriteLine($"{sectorA / fans * 100:f2}%");
            Console.WriteLine($"{sectorB / fans * 100:f2}%");
            Console.WriteLine($"{sectorV / fans * 100:f2}%");
            Console.WriteLine($"{sectorG / fans * 100:f2}%");
            Console.WriteLine($"{fans / stadion * 100:f2}%");
        }
    }
}
