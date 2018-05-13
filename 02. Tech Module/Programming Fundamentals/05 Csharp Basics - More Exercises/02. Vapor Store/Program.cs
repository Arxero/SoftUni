using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Vapor_Store
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string gameTitle = Console.ReadLine();

            double money = budget;
            double gamePrice = 0;

            while (gameTitle != "Game Time")
            {
                switch (gameTitle)
                {
                    case "OutFall 4":
                    case "RoverWatch Origins Edition":
                        gamePrice = 39.99;
                        break;
                    case "CS: OG":
                        gamePrice = 15.99;
                        break;
                    case "Zplinter Zell":
                        gamePrice = 19.99;
                        break;
                    case "Honored 2":
                        gamePrice = 59.99;
                        break;
                    case "RoverWatch":
                        gamePrice = 29.99;
                        break;
                    default:
                        gamePrice = 0;
                        gameTitle = "Not Found";
                        break;
                }

                if (gamePrice == 0)
                {
                    Console.WriteLine(gameTitle);
                }
                else if (money < gamePrice)
                {
                    Console.WriteLine("Too Expensive");
                }
                else if (money >= gamePrice)
                {
                    money -= gamePrice;
                    Console.WriteLine($"Bought {gameTitle}");
                }
                if (money == 0)
                {
                    Console.WriteLine("Out of money!");
                    return;
                }
                gameTitle = Console.ReadLine();
            }
            double total = budget - money;
            double moneyLeft = money;

            Console.WriteLine($"Total spent: ${total:f2}. Remaining: ${moneyLeft:f2}");
        }
    }
}
