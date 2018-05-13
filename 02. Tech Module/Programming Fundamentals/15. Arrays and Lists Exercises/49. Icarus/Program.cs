using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _49.Icarus
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            int start = int.Parse(Console.ReadLine());
            string[] command = Console.ReadLine().Split().ToArray();

            int damage = 1;

            while (command[0] != "Supernova")
            {
                string direction = command[0];
                int steps = int.Parse(command[1]);

                if (command[0] == "left")
                {
                    //doing the steps/moves
                    for (int i = start - 1; steps != 0;)
                    {
                        if (i < 0)
                        {
                            damage++;
                            i = input.Count - 1;
                        }
                        input[i] -= damage;
                        steps--;
                        start = i;
                        i--;
                        
                    }

                }
                else if (command[0] == "right")
                {
                    for (int i = start + 1; steps != 0;)
                    {
                        if (i >= input.Count)
                        {
                            damage++;
                            i = 0;
                        }
                        input[i] -= damage;
                        steps--;
                        start = i;
                        i++;
                        
                    }
                }

                command = Console.ReadLine().Split().ToArray();
            }
            Console.WriteLine(string.Join(" ", input));
        }
    }
}
