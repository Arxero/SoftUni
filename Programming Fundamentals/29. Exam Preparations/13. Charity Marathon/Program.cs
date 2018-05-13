using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Charity_Marathon
{
    class Program
    {
        static void Main(string[] args)
        {
            long lengthInDays = long.Parse(Console.ReadLine());
            long runners = long.Parse(Console.ReadLine());
            long laps = long.Parse(Console.ReadLine());
            long lapLength = long.Parse(Console.ReadLine());
            long trackCapacity = long.Parse(Console.ReadLine());
            decimal moneyPerKilometer = decimal.Parse(Console.ReadLine());

            trackCapacity = trackCapacity * lengthInDays;
            if (runners > trackCapacity)
            {
                runners = trackCapacity;
            }

            decimal totalMeters = runners * laps * lapLength;
            decimal totalKilmeteres = totalMeters / 1000;
            decimal moneyRaised = totalKilmeteres * moneyPerKilometer;
            Console.WriteLine($"Money raised: {moneyRaised:f2}");
        }
    }
}
