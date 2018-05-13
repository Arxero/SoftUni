using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.Icarus
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int index = int.Parse(Console.ReadLine());
            string[] commands = Console.ReadLine().Split().ToArray();

            int damage = 1;

            while (commands[0] !="Supernova")
            {
                string direction = commands[0];
                int steps = int.Parse(commands[1]);

                if (direction == "left")
                {
                    for (int i = 0; i < steps; i++)
                    {

                        if (index <= 0)
                        {
                            index = input.Length;
                            damage++;
                        }
                        input[index - 1] -= damage;
                        index--;
                    }
                }

                else if (direction == "right")
                {
                    for (int i = 0; i < steps; i++)
                    {
                        
                        if (index >= input.Length - 1)
                        {
                            index = -1;
                            damage++;
                        }

                        input[index + 1] -= damage;
                        index++;
                    }
                }
                commands = Console.ReadLine().Split();
            }
            Console.WriteLine(string.Join(" ", input));
        }
    }
}
