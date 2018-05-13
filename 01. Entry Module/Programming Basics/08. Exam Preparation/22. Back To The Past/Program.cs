using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22.Back_To_The_Past
{
    class Program
    {
        static void Main(string[] args)
        {
            double heritageMoney = double.Parse(Console.ReadLine()); // 5:45
            int year = int.Parse(Console.ReadLine());

            double moneySpent = 0;
            double yearOld = 18;
            double moneyLeft = 0;
            double oddYeraSpendings = 0;

            for (int i = 1800; i <= year; i++)
            {
                oddYeraSpendings = 12000 + 50 * yearOld;
                yearOld++;
                
                if (i % 2 == 0)
                {
                    moneySpent = 12000;
                    //moneyLeft = moneyLeft2;
                    //moneyLeft = heritageMoney - moneySpent;
                }
                else
                {
                    moneySpent = oddYeraSpendings;
                    //moneyLeft2 = moneyLeft - oddYeraSpendings;
                    //moneyLeft = moneyLeft2;
                }
                moneyLeft = heritageMoney - moneySpent;
                heritageMoney = moneyLeft;

            }
            if (heritageMoney >= 0)
            {
                Console.WriteLine($"Yes! He will live a carefree life and will have {heritageMoney:f2} dollars left.");
            }
            else
            {
                Console.WriteLine($"He will need {Math.Abs(heritageMoney):f2} dollars to survive.");
            }
        }
    }
}
