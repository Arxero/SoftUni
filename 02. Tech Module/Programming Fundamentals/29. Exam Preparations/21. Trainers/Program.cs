using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21.Trainers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var dict = new Dictionary<string, double>()
            {
                { "Technical",0},
                { "Theoretical",0},
                { "Practical",0}
            };

            for (int i = 0; i < n; i++)
            {
                int distance = int.Parse(Console.ReadLine());
                double cargo = double.Parse(Console.ReadLine());
                string team = Console.ReadLine();

                double cargoInKillos = (cargo * 1000) * 1.5;
                double distanceInMeters = (distance * 1600) * 0.7 * 2.5;

                double participantEarnedMoney = cargoInKillos - distanceInMeters;
                dict[team] += participantEarnedMoney;
            }
            var order = dict.OrderByDescending(x => x.Value).First();
            Console.WriteLine($"The {order.Key} Trainers win with ${order.Value:f3}.");

        }
    }
}
