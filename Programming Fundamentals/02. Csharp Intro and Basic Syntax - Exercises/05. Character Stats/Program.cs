using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Character_Stats
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int healthCurrent = int.Parse(Console.ReadLine());
            int healthMaximum = int.Parse(Console.ReadLine());
            int energyCurrent = int.Parse(Console.ReadLine());
            int energyMaximum = int.Parse(Console.ReadLine());

            int healthCalculation = healthMaximum - healthCurrent;
            int energyCalculation = energyMaximum - energyCurrent;

            Console.WriteLine($"Name: {name}");
            Console.WriteLine("Health: |{0}{1}|", new string ('|', healthCurrent), new string ('.', healthCalculation));
            Console.WriteLine("Energy: |{0}{1}|", new string ('|', energyCurrent), new string ('.', energyCalculation));
        }
    }
}
