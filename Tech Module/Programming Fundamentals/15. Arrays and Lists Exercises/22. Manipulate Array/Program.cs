using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22.Manipulate_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split().ToArray();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] commands = Console.ReadLine().Split().ToArray();

                if (commands[0] == "Reverse")
                {
                    Array.Reverse(input);
                }
                if (commands[0] == "Distinct")
                {
                    input = input.Distinct().ToArray();
                }
                if (commands[0] == "Replace")
                {
                    input[int.Parse(commands[1])] = commands[2];
                }
            }
            Console.WriteLine(string.Join(", ", input));
        }
    }
}
