using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _63.Bills
{
    class Program
    {
        static void Main(string[] args)
        {
            int months = int.Parse(Console.ReadLine()); // 11:40

            double electricityBill = 0;
            double water = 20;
            double internet = 15;
            double others = 0;
            double others2 = 0;

            for (int i = 0; i < months; i++)
            {
                double electricity = double.Parse(Console.ReadLine());
                electricityBill += electricity;
                others = (electricity + water + internet) + ((electricity + water + internet) * 0.20);
                others2 += others;

            }
            Console.WriteLine($"Electricity: {electricityBill:f2} lv");
            Console.WriteLine($"Water: {water * months:f2} lv");
            Console.WriteLine($"Internet: {internet * months:f2} lv");
            Console.WriteLine($"Other: {others2:f2} lv");
            Console.WriteLine($"Average: {(electricityBill + (water * months) + (internet * months) + others2) / months:f2} lv");

        }
    }
}
