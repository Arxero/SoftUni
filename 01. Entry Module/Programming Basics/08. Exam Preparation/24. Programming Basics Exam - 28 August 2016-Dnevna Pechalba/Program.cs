using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24.Programming_Basics_Exam___28_August_2016_Dnevna_Pechalba
{
    class Program
    {
        static void Main(string[] args)
        {
            int workdays = int.Parse(Console.ReadLine()); // 4 :17
            double earnedMoney = double.Parse(Console.ReadLine());
            double USDtoBGN = double.Parse(Console.ReadLine());

            double monthlySalary = workdays * earnedMoney;
            double yearlySalary = (monthlySalary * 12) + (monthlySalary * 2.5);
            double VAT = ((yearlySalary * 0.75) * USDtoBGN) / 365;
            Console.WriteLine($"{VAT:f2}");
        }
    }
}
