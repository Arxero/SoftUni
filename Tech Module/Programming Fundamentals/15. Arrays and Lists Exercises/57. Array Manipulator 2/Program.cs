using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _57.Array_Manipulator_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            string[] command = Console.ReadLine().Split();

            while (command[0] != "end")
            {
                int index = 0;


                switch (command[0])
                {
                    case "exchange":

                        index = int.Parse(command[1]);
                        if (index >= 0 && index <= input.Count - 1)
                        {
                            int[] taken = input.Take(index + 1).ToArray();
                            for (int i = 0; i < taken.Length; i++)
                            {
                                input.RemoveAt(0);
                            }
                            input.AddRange(taken);
                        }
                        else
                        {
                            Console.WriteLine("Invalid index");
                        }
                        break;

                    case "max":

                        if (command[1] == "even")
                        {
                            int[] taken = input.ToList().Where(x => x % 2 == 0).ToArray();
                            if (taken.Length != 0)
                            {
                                int takenMax = taken.Max();
                                int indexOfMaxEven = input.LastIndexOf(takenMax);
                                Console.WriteLine(indexOfMaxEven);
                            }
                            else
                            {
                                Console.WriteLine("No matches");
                            }
                            
                        }
                        else if (command[1] == "odd")
                        {
                            int[] taken = input.ToList().Where(x => x % 2 != 0).ToArray();
                            if (taken.Length != 0)
                            {
                                int takenMax = taken.Max();
                                int indexOfMaxOdd = input.LastIndexOf(takenMax);
                                Console.WriteLine(indexOfMaxOdd);
                            }
                            else
                            {
                                Console.WriteLine("No matches");
                            }
                        }
                        break;

                    case "min":

                        if (command[1] == "even")
                        {
                            int[] taken = input.ToList().Where(x => x % 2 == 0).ToArray();
                            if (taken.Length != 0)
                            {
                                int takenMin = taken.Min();
                                int indexOfMinEven = input.LastIndexOf(takenMin);
                                Console.WriteLine(indexOfMinEven);
                            }
                            else
                            {
                                Console.WriteLine("No matches");
                            }

                        }
                        else if (command[1] == "odd")
                        {
                            int[] taken = input.ToList().Where(x => x % 2 != 0).ToArray();
                            if (taken.Length != 0)
                            {
                                int takenMin = taken.Min();
                                int indexOfMinOdd = input.LastIndexOf(takenMin);
                                Console.WriteLine(indexOfMinOdd);
                            }
                            else
                            {
                                Console.WriteLine("No matches");
                            }
                        }
                        break;

                    case "first":
                        int count = int.Parse(command[1]);

                        if (command[2] == "even")
                        {
                            if (count > input.Count)
                            {
                                Console.WriteLine("Invalid count");
                            }
                            else
                            {
                                int[] taken = input.ToArray().Where(x => x % 2 == 0).ToArray();
                                var takeFirst = taken.Take(count).ToArray();
                                Console.WriteLine($"[{string.Join(", ", takeFirst)}]");
                                
                            }
                        }
                        else if (command[2] == "odd")
                        {
                            if (count > input.Count)
                            {
                                Console.WriteLine("Invalid count");
                            }
                            else
                            {
                                int[] taken = input.ToArray().Where(x => x % 2 != 0).ToArray();
                                var takeFirst = taken.Take(count).ToArray();
                                Console.WriteLine($"[{string.Join(", ", takeFirst)}]");
                            }
                        }
                        break;

                    case "last":

                        int countLast = int.Parse(command[1]);

                        if (command[2] == "even")
                        {
                            if (countLast > input.Count)
                            {
                                Console.WriteLine("Invalid count");
                            }
                            else
                            {
                                int[] taken = input.ToArray().Where(x => x % 2 == 0).ToArray();
                                var takeLast = taken.Skip(taken.Length - countLast).ToArray();
                                Console.WriteLine($"[{string.Join(", ", takeLast)}]");
                            }
                        }
                        else if (command[2] == "odd")
                        {
                            if (countLast > input.Count)
                            {
                                Console.WriteLine("Invalid count");
                            }
                            else
                            {
                                int[] taken = input.ToArray().Where(x => x % 2 != 0).ToArray();
                                var takeLast = taken.Skip(taken.Length - countLast).ToArray();
                                Console.WriteLine($"[{string.Join(", ", takeLast)}]");
                            }
                        }
                        break;
                }
                command = Console.ReadLine().Split();
            }
            Console.WriteLine($"[{string.Join(", ", input)}]");
        }
    }
}
