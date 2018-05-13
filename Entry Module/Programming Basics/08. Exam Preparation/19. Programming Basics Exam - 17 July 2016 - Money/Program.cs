using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19.Programming_Basics_Exam___17_July_2016___Money
{
    class Program
    {
        static void Main(string[] args)
        {
            double bitcoins = double.Parse(Console.ReadLine()); // 3:45
            double chineseMoney = double.Parse(Console.ReadLine());
            double commission = double.Parse(Console.ReadLine());

            double bitcoinInLevs = bitcoins * 1168;
            double chineseMoneyInUSD = chineseMoney * 0.15;
            double chinneseMoneyInLevs = chineseMoneyInUSD * 1.76;
            double calculation = (bitcoinInLevs + chinneseMoneyInLevs) / 1.95;
            double commissionValue = calculation * commission / 100;
            double commissionSubstracted = calculation - commissionValue;
            Console.WriteLine($"{commissionSubstracted:f2}");

        }
    }
}
