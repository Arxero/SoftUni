using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Bonus_Score
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter score: ");
            int number = int.Parse(Console.ReadLine());

            double bonusPoints = 0;

            if (number <= 100)
            {
                bonusPoints = 5;
                //bonus points 5
            }
            else if (number > 1000)
            {
                bonusPoints = number * 0.1;
                //bonus points 10%
            }
            else if (number > 100)
            {
                bonusPoints = number * 0.2;
                //bonus points 20%
            }

            if (number % 2 == 0)
            {
                bonusPoints = bonusPoints + 1;
            }
            else if (number % 10 == 5)
            {
                bonusPoints = bonusPoints + 2;
            }
                Console.WriteLine("Bonus score: " + bonusPoints);
                Console.WriteLine($"Total score: {bonusPoints + number}");
        }
    }
}
