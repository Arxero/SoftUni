using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _69.Football_League
{
    class Program
    {
        static void Main(string[] args)
        {
            double capacity = double.Parse(Console.ReadLine()); // 3:40   
            double fans = double.Parse(Console.ReadLine());

            double A = .0;
            double B = .0;
            double V = .0;
            double G = .0;

            for (int i = 1; i <= fans; i++)
            {
                string sector = Console.ReadLine();

                switch (sector)
                {
                    case "A":
                        A++;
                        break;
                    case "B":
                        B++;
                        break;
                    case "V":
                        V++;
                        break;
                    case "G":
                        G++;
                        break;
                }
            }
            Console.WriteLine($"{(A / fans) * 100:f2}%");
            Console.WriteLine($"{(B / fans) * 100:f2}%");
            Console.WriteLine($"{(V / fans) * 100:f2}%");
            Console.WriteLine($"{(G / fans) * 100:f2}%");
            Console.WriteLine($"{(fans / capacity) * 100.0:f2}%");

        }
    }
}
