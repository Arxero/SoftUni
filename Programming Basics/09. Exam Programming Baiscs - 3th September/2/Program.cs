using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine()); // 9:27
            double grade = double.Parse(Console.ReadLine());
            double salary = double.Parse(Console.ReadLine());


            double social = salary * 0.35;
            double agradestipenida = grade * 25;
            if (money >= salary && grade < 5.50)
            {
                Console.WriteLine($"You cannot get a scholarship!");
            }
            else if (money <= salary && social > agradestipenida)
            {
                Console.WriteLine($"You get a Social scholarship {Math.Floor(social)} BGN");
            }
            else if (grade >= 5.50 && agradestipenida >= social)
            {
                Console.WriteLine($"You get a scholarship for excellent results {Math.Floor(agradestipenida)} BGN");
            }
            else if (money <= salary)
            {
                Console.WriteLine($"You get a Social scholarship {Math.Floor(social)} BGN");
            }
            else if (grade >= 5.50)
            {
                Console.WriteLine($"You get a scholarship for excellent results {Math.Floor(agradestipenida)} BGN");
            }
            else if (salary <= money && grade  < 4.5)
            {
                Console.WriteLine($"You get a Social scholarship {Math.Floor(social)} BGN");
            }

        }
    }
}
