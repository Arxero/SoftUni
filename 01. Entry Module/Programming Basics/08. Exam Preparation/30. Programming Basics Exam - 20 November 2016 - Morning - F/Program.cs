using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30.Programming_Basics_Exam___20_November_2016___Morning___F
{
    class Program
    {
        static void Main(string[] args)
        {
            double skumriaPrice = double.Parse(Console.ReadLine()); // 4:41
            double cacaPrice = double.Parse(Console.ReadLine());
            double palamudKilos = double.Parse(Console.ReadLine());
            double safridKilos = double.Parse(Console.ReadLine());
            double midiKilos = double.Parse(Console.ReadLine());

            double palamudPrice = (skumriaPrice * 0.60) + skumriaPrice;
            double sumPalamud = palamudKilos * palamudPrice;
            double safridPrice = (cacaPrice * 0.80) + cacaPrice;
            double sumSafrid = safridKilos * safridPrice;
            double sumMidi = midiKilos * 7.50;
            double bill = sumPalamud + sumSafrid + sumMidi;


            Console.WriteLine($"{bill:f2}");



        }
    }
}
