using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_Preparation
{
    class Program
    {
        static void Main(string[] args)
        {
            //setting the initial values of spaceship
            char spaceShip = '^'; // how the spaceship will look like

            //seting initial values of the enemy
            Random enemyGenerator = new Random();
            char enemy = '*';
            int minGeneratedCol = 0;
            int maxGeneratedRow = Console.WindowHeight / 2;
            int rowOfEnemy = enemyGenerator.Next(0, Console.WindowHeight);
            int colOfEnemy = enemyGenerator.Next(0, Console.BufferHeight);
            
            
            //int accidaentValue = random.Next(0, 4);

            //ssetting widht and height
            int width = 35;
            int height = 30;
            Console.SetWindowSize(width, height); // to set the size of the window

            Console.BufferHeight = Console.WindowHeight; // to remove scrollbar
            Console.BufferWidth = Console.WindowWidth; // to remove scrollbar
            //setting cursror visability
            Console.CursorVisible = false;



            int rowOfSpaceShip = Console.WindowHeight - 1;
            int colOfSpaceShip = 0;
            Console.SetCursorPosition(colOfSpaceShip, rowOfSpaceShip); // to define where we will print
            Console.Write(spaceShip); // print the spaceship

            while (true)
            {
               ConsoleKeyInfo currentPressedKey = Console.ReadKey();
                if (currentPressedKey.Key == ConsoleKey.LeftArrow && colOfSpaceShip >= 1)
                {
                    //TODO: left move
                    colOfSpaceShip--;
                }
                else if (currentPressedKey.Key == ConsoleKey.RightArrow && colOfSpaceShip <= Console.WindowWidth - 2)
                {
                    //TODO: right move
                    colOfSpaceShip++;
                }
                else if (currentPressedKey.Key == ConsoleKey.Spacebar)
                {
                    //TODO shoot the enemy
                    int rowOFProjectile = rowOfSpaceShip - 1;
                    int colOfProjectFile = colOfSpaceship;
                    while (rowOfSpaceShip > 0)
                    {
                        rowOFProjectile--;
                    }
                }
                Console.Clear();
                Console.SetCursorPosition(colOfSpaceShip, rowOfSpaceShip);
                Console.Write(spaceShip);
            }
        }
    }
}
