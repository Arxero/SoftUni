using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23.Bills
{
    class Program
    {
        static void Main(string[] args)
        {
            double months = double.Parse(Console.ReadLine()); // 3:12

            double water = 20;
            double internet = 15;
            double electicityBills = 0;
            double others = 0;
            double othersPercentage = 0;
            double othersBills = 0;

            for (int i = 0; i < months; i++)
            {
                double electricity = double.Parse(Console.ReadLine());

                electicityBills = electicityBills + electricity;
                others = electricity + water + internet;
                othersBills = othersBills + others;
            }
            othersPercentage = othersBills + (othersBills * 0.20);

            Console.WriteLine($"Electricity: {electicityBills:f2} lv");
            Console.WriteLine($"Water: {water * months:f2} lv");
            Console.WriteLine($"Internet: {internet * months:f2} lv");
            Console.WriteLine($"Other: {othersPercentage:f2} lv");
            Console.WriteLine($"Average: {(electicityBills + (water * months) + (internet* months) + othersPercentage) / months:f2} lv");
        }
    }
}
