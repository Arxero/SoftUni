using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _51.Command_Interpreter
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).ToList();
            string[] command = Console.ReadLine().Split();

            while (command[0] != "end")
            {
                switch (command[0])
                {
                    case "reverse":

                        int start = int.Parse(command[2]);
                        int count = int.Parse(command[4]);
                        int end = start + count - 1;
                        if (start < 0 || start >= input.Count || count < 0 || end >= input.Count)
                        {
                            Console.WriteLine("Invalid input parameters.");
                        }
                        else
                        {
                            var taken = input.Skip(start).Take(count).Reverse().ToArray();
                            input.RemoveRange(start, count);
                            input.InsertRange(start, taken);
                        }
                        break;

                    case "sort":

                        int startSort = int.Parse(command[2]);
                        int countSort = int.Parse(command[4]);
                        int endSort = startSort + countSort - 1;
                        if (startSort < 0 || startSort >= input.Count || countSort < 0 || endSort >= input.Count)
                        {
                            Console.WriteLine("Invalid input parameters.");
                        }
                        else
                        {
                            var sorting = input.Skip(startSort).Take(countSort).ToArray();
                            Array.Sort(sorting);
                            input.RemoveRange(startSort, countSort);
                            input.InsertRange(startSort, sorting);
                        }
                        break;

                    case "rollLeft":
                        int countRollLeft = int.Parse(command[1]) % input.Count;

                        if (countRollLeft >= 0)
                        {
                            var takenRollLeft = input.Take(countRollLeft).ToArray();

                            input.RemoveRange(0, countRollLeft);
                            input.AddRange(takenRollLeft);
                        }
                        else
                        {
                            Console.WriteLine("Invalid input parameters.");
                        }
                        break;

                    case "rollRight":
                        int countRollRight = int.Parse(command[1]) % input.Count;

                        if (countRollRight >= 0)
                        {
                            var takenRollRight = input.Skip(input.Count - countRollRight).ToArray();

                            input.RemoveRange(input.Count - countRollRight, takenRollRight.Length);
                            input.InsertRange(0, takenRollRight);
                        }
                        else
                        {
                            Console.WriteLine("Invalid input parameters.");
                        }
                        break;
                }

                command = Console.ReadLine().Split();
            }
            Console.WriteLine($"[{string.Join(", ", input)}]");
        }
    }
}
