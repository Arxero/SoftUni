using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _38.Change_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();
            string[] command = Console.ReadLine().Split().ToArray();

            while (true)
            {
                //dealing with the commands
                if (command[0] == "Delete")
                {
                    input.RemoveAll(x => x == int.Parse(command[1]));
                }
                else if (command[0] == "Insert")
                {
                    input.Insert(int.Parse(command[2]), int.Parse(command[1]));
                }

                //dealing with odd or even case
                if (command[0] == "Even")
                {
                    input.RemoveAll(x => x % 2 != 0);
                    Console.WriteLine(string.Join(" ", input));
                    break;
                }
                else if (command[0] == "Odd")
                {
                    input.RemoveAll(x => x % 2 == 0);
                    Console.WriteLine(string.Join(" ", input));
                    break;
                }                

                command = Console.ReadLine().Split().ToArray();
            }
        }
    }
}
