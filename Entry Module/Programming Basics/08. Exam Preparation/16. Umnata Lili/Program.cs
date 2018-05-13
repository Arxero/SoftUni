using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.Umnata_Lili
{
    class Program
    {
        static void Main(string[] args)
        {
            int yearOld = int.Parse(Console.ReadLine()); // 7:10
            double washingMaishinePrice = double.Parse(Console.ReadLine());
            int toyPRice = int.Parse(Console.ReadLine());

            double money = 0;
            double newMoney = 0;
            double stolenMoney = 0;
            double toy = 0;

            for (int i = 1; i <= yearOld; i++)
            {
                if (i % 2 == 0)
                {
                    money = money + 10;
                    newMoney = newMoney + money;
                    stolenMoney++;

                }
                else
                {
                    toy++;
                }
            }
            double moneyFromToys = (toy * toyPRice) - stolenMoney;
            double herMoney = newMoney + moneyFromToys;
            double isitEnough = herMoney - washingMaishinePrice;
            if (herMoney >= washingMaishinePrice)
            {
                Console.WriteLine($"Yes! {isitEnough:f2}");
            }
            else
            {
                Console.WriteLine($"No! {Math.Abs(isitEnough):f2}");
            }
        }
    }
}
