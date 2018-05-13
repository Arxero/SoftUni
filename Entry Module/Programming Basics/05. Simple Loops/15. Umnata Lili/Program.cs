using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Umnata_Lili
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            double washingMachine = double.Parse(Console.ReadLine());
            int toysNumber = int.Parse(Console.ReadLine());

            int toys = 0;
            double brotherMoney = 0;
            double birthdayMoney = 0;
            double birthdayMoneySum = 0;

            for (int i = 0; i < N; i++)
            {
                
                if (i % 2 == 0)
                {
                    //odd birthdays, she gets toys
                    toys++;
                }
                else
                {
                    // even birthdays, she gets money
                    birthdayMoney = birthdayMoney + 10;
                    brotherMoney++;
                    birthdayMoneySum = birthdayMoneySum + birthdayMoney;

                }
            }
            double toysProfit = toys * toysNumber;
            double calculations = birthdayMoneySum + toysProfit - brotherMoney;
            double leftMoney = calculations - washingMachine;
            if (calculations >= washingMachine)
            {
                Console.WriteLine($"Yes! {leftMoney:f2}");
            }
            else
            {
                Console.WriteLine($"No! {Math.Abs(leftMoney):f2}");
            }
        }
    }
}
