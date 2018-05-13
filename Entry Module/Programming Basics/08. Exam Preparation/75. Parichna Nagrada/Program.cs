using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _75.Parichna_Nagrada
{
    class Program
    {
        static void Main(string[] args)
        {
            int parts = int.Parse(Console.ReadLine()); // 4:49
            double prize = double.Parse(Console.ReadLine());

            double result = 0;

            for (int i = 1; i <= parts; i++)
            {
                int points = int.Parse(Console.ReadLine());

                if (i % 2 == 0)
                {
                    points = points * 2;
                }
                result += points;
            }
            double total = result * prize;
            Console.WriteLine($"The project prize was {total:f2} lv.");
        }
    }
}
