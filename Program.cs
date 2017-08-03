using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25.Parichna_Nagrada
{
    class Program
    {
        static void Main(string[] args)
        {
            int part = int.Parse(Console.ReadLine()); // 6:47
            double money = double.Parse(Console.ReadLine());

            double pointsOdd = 0;
            double pointsEven = 0;
            double sumAllPoints = 0;

            for (int i = 0; i < part; i++)
            {
                int points = int.Parse(Console.ReadLine());

                if (i % 2 == 0)
                {
                    // odd
                    pointsOdd += points;
                }
                else
                {
                    //even
                    pointsEven += points * 2;
                }
            }
            sumAllPoints = pointsOdd + pointsEven;
            Console.WriteLine($"The project prize was {money * sumAllPoints:f2} lv.");
        }
    }
}
