using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _81.Energy_Loss
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine()); // 9:45
            int dancers = int.Parse(Console.ReadLine());

            double energy = 100;
            double energyLoss = 0;

            for (int i = 1; i <= days; i++)
            {
                int hours = int.Parse(Console.ReadLine());

                if (i % 2 == 0 && hours % 2 == 0)
                {
                    energy = dancers * 68;
                }
                else if (i % 2 != 0 && hours % 2 != 0)
                {
                    energy = dancers * 30;
                }
                else if (i % 2 != 0 && hours % 2 == 0)
                {
                    energy = dancers * 49;
                }
                else if (i % 2 == 0 && hours % 2 != 0)
                {
                    energy = dancers * 65;
                }
                energyLoss += energy;
            }
            double totalEnergy = 100 * dancers * days;
            double unusedEnergy = totalEnergy - energyLoss;
            double unusedEnergyDaily = unusedEnergy / dancers / days;
            if (unusedEnergyDaily <= 50)
            {
                Console.WriteLine($"They are wasted! Energy left: {unusedEnergyDaily:f2}");

            }
            else
            {
                Console.WriteLine($"They feel good! Energy left: {unusedEnergyDaily:f2}");
            }
        }
    }
}
