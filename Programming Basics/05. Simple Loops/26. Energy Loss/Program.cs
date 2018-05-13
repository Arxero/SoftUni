using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26.Energy_Loss
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine()); // 4:34
            int dancers = int.Parse(Console.ReadLine());

            double energy1 = 0;
            double energy2 = 0;
            double energy3 = 0;
            double energy4 = 0;
            double days2 = 0;

            for (int i = 0; i < days; i++)
            {
                int hours = int.Parse(Console.ReadLine());
                days2++;

                if ((days2 % 2 == 0 && hours % 2 == 0))
                {
                    //Четен ден и четни часове
                    energy1 = 68 * dancers;
                    
                    Console.WriteLine(energy1);
                }
                else if ((days2 % 2 != 0) && (hours % 2 == 0))
                {
                    energy3 = 49 * dancers;
                   
                    Console.WriteLine(energy3);
                }
                else if ((days2 % 2 == 0) && (hours % 2 != 0))
                {
                    energy4 = 65 * dancers;
                    Console.WriteLine(energy4);
                }
                else
                {
                    //Нечетен ден и нечетни часове – 10 * 30 
                    energy2 = 30 * dancers;
                    Console.WriteLine(energy2);
                }
            }
            double allEnergy = 100 * dancers * days;
            double summedEnergy = allEnergy - (energy1 + energy2 + energy3 + energy4);
            Console.WriteLine(summedEnergy);
            double unusedEnergy = summedEnergy / dancers / days;
            if (unusedEnergy < 50)
            {
                Console.WriteLine($"They are wasted! Energy left: {unusedEnergy:f2}");
            }
            else
            {
                Console.WriteLine($"“They feel good! Energy left: {unusedEnergy:f2}");
            }
            
        }
    }
}
