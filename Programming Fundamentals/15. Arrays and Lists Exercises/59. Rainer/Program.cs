using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _59.Rainer
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] input = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(long.Parse).ToArray();
            long[] gameField = input.Take(input.Length - 1).ToArray();
            long donalIndex = input.Last();
            int steps = 0;

            while (true)
            {
                for (int i = 0; i < gameField.Length; i++)
                {
                    gameField[i] -= 1;
                }

                //checking where donald is
                //if (gameField[donalIndex] == )
                //{

                //}

                for (int i = 0; i < gameField.Length; i++)
                {
                    if (donalIndex == i)
                    {

                    }
                    else
                    {
                        steps++;
                    }

                }

                donalIndex = long.Parse(Console.ReadLine());
            }
            Console.WriteLine(string.Join(" ", gameField));
            Console.WriteLine(steps);
        }
    }
}
