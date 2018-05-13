using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _43.Bomb_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> bombInfo = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            int bomb = bombInfo[0];
            int power = bombInfo[1];

            for (int i = 0; i < input.Count; i++)
            {
                //checking which position is the bomb
                if (input[i] == bomb)
                {
                    //on left
                    // we start from one because our power naturally greater than 0
                    for (int j = 1; j <= power; j++)
                    {
                        //always when it will go out of the array
                        if (i - j < 0)
                        {
                            break;
                        }
                        else
                        {
                            input[i - j] = 0;
                        }
                    }

                    //on right
                    for (int j = 1; j <= power; j++)
                    {
                        //always when it will go out of the array
                        if (i + j > input.Count - 1)
                        {
                            break;
                        }
                        else
                        {
                            input[i + j] = 0;
                        }
                    }
                    input[i] = 0;
                }
            }
            Console.WriteLine(input.Sum());
        }
    }
}
