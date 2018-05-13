using System;
using System.Linq;
class Program
{
    static void Main()
    {
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            while (true)
            {
                string[] currentCommand = Console.ReadLine().Split(' ').ToArray();

                if (currentCommand[0] == "Even")
                {
                    for (int i = 0; i < input.Count; i++)
                    {
                        if (input[i] % 2 == 0)
                        {
                            Console.Write($"{input[i]} ");
                        }
                    }
                    Console.WriteLine();
                    break;
                }
                if (currentCommand[0] == "Odd")
                {
                    for (int i = 0; i < input.Count; i++)
                    {
                        if (input[i] % 2 != 0)
                        {
                            Console.Write($"{input[i]} ");
                        }
                    }
                    Console.WriteLine();
                    break;
                }
                if (currentCommand[0] == "Delete")
                {
                    for (int i = 0; i < input.Count; i++)
                    {
                        int number = int.Parse(currentCommand[1]);
                        if (number == input[i])
                        {
                            input.Remove(number);
                            i--;
                        }
                    }
                }
                if (currentCommand[0] == "Insert")
                {
                        int number = int.Parse(currentCommand[1]);
                        int position = int.Parse(currentCommand[2]);
                        input.Insert(position, number);
                }
            }
        }
    }
}