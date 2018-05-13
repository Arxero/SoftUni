using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _44.Array_Modifier
{
    class Program
    {
        static void Main(string[] args)
        {
            List<long> input = Console.ReadLine().Split().Select(long.Parse).ToList();
            string[] command = Console.ReadLine().Split().ToArray();

            while (command[0] != "end")
            {
                int index1 = 0;
                int index2 = 0;

                if (command.Length > 1)
                {
                    index1 = int.Parse(command[1]);
                    index2 = int.Parse(command[2]);
                }

                switch (command[0])
                {
                    case "swap":
                        long taken1 = input[index1];
                        long taken2 = input[index2];
                        input[index1] = taken2;
                        input[index2] = taken1;
                        break;

                    case "multiply":
                        long takenOne = input[index1];
                        long takenTwo = input[index2];
                        long multiply = takenOne * takenTwo;
                        input[index1] = multiply;

                        break;
                    case "decrease":
                        for (int i = 0; i < input.Count; i++)
                        {
                            input[i] -= 1;
                        }
                        break;
                }

                command = Console.ReadLine().Split().ToArray();
            }
            Console.WriteLine(string.Join(", ", input));
        }
    }
}
