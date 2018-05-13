using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26.Heists
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string[] input2 = Console.ReadLine().Split().ToArray();

            int jewels = input[0];
            int gold = input[1];
            int totalEarningsPerHeist = 0;
            int totalExpenses = 0;

            while (input2[0] != "Jail")
            {
                string loot = input2[0];
                int expenses = int.Parse(input2[1]);

                int countOfJewels = 0;
                int countOfGold = 0;

                //looking for loot
                for (int i = 0; i < loot.Length; i++)
                {
                    if (loot[i] == '%')//jewels
                    {
                        countOfJewels++;
                    }
                    if (loot[i] == '$')//gold
                    {
                        countOfGold++;
                    }
                }
                //calculating total for the first heist

                totalEarningsPerHeist += (countOfJewels * jewels) + (countOfGold * gold);
                totalExpenses += expenses;


                input2 = Console.ReadLine().Split().ToArray();
            }
            int result = totalEarningsPerHeist - totalExpenses;
            if (result >= 0)
            {
                Console.WriteLine($"Heists will continue. Total earnings: {result}.");
            }
            else
            {
                Console.WriteLine($"Have to find another job. Lost: {Math.Abs(result)}.");
            }
        }
    }
}
