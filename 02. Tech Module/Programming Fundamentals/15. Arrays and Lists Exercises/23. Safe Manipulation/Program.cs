using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23.Safe_Manipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split().ToArray();
            string[] commands = Console.ReadLine().Split().ToArray();

            while (commands[0] != "END")
            {
                try
                {
                    if (commands[0] == "Reverse")
                    {
                        Array.Reverse(input);
                    }

                    else if (commands[0] == "Distinct")
                    {
                        if (input.Length != input.Distinct().Count())
                        {
                            input = input.Distinct().ToArray();
                        }
                        else if (commands[0] != "Distinct")
                        {
                            Console.WriteLine("Invalid input!");
                        }

                    }
                    else if (commands[0] == "Replace")
                    {
                        input[int.Parse(commands[1])] = commands[2];
                    }

                    else
                    {
                        Console.WriteLine("Invalid input!");
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid input!");
                }

                commands = Console.ReadLine().Split();
            }
            Console.WriteLine(string.Join(", ", input));
        }
    }
}
