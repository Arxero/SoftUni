using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _41.Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<long> input = Console.ReadLine().Split().Select(long.Parse).ToList();
            string[] command = Console.ReadLine().Split().ToArray();

            while (command[0] != "print")
            {
                if (command[0] == "add")
                {
                    input.Insert(int.Parse(command[1]), int.Parse(command[2]));
                }
                else if (command[0] == "addMany")
                {
                    long[] nums = new long[command.Length - 2];
                    for (int i = 0; i < command.Length - 2; i++)
                    {
                        nums[i] = int.Parse(command[i + 2]);
                    }
                    input.InsertRange(int.Parse(command[1]), nums);
                }
                else if (command[0] == "contains")
                {

                    int index = input.IndexOf(int.Parse(command[1]));
                    Console.WriteLine(index);
                    //bool lamp = false;
                    //int n = 0;
                    //for (int i = 0; i < input.Count; i++)
                    //{
                    //    if (input[i] == int.Parse(command[1]))
                    //    {
                    //        n = i;
                    //        lamp = true;
                    //    }
                    //}
                    //if (lamp)
                    //{
                    //    Console.WriteLine(n);
                    //}
                    //else
                    //{
                    //    Console.WriteLine("-1");
                    //}
                }
                else if (command[0] == "remove")
                {
                    input.RemoveAt(int.Parse(command[1]));
                }
                else if (command[0] == "shift")
                {
                    //var take = input.Take(int.Parse(command[1])).ToList();
                    //var skip = input.Skip(int.Parse(command[1])).ToList();
                    //input.RemoveRange(0, input.Count);
                    //input.AddRange(skip);
                    //input.AddRange(take);


                    int positions = int.Parse(command[1]) % input.Count; // we define how many time the loop will loop
                    List<long> moved = new List<long>();
                    for (int i = 0; i < positions; i++)
                    {
                        moved.Add(input[0]);
                        input.RemoveAt(0);
                    }
                    input.AddRange(moved);

                }
                else if (command[0] == "sumPairs")
                {
                    //my way of doing it wrong
                    //List<long> summed = new List<long>();
                    //for (int i = 0; i < input.Count; i++)
                    //{
                    //    //input.count % 2 on even number returns 0 and on odd number retursn 1
                    //    input[i] += input[i + 1];
                    //    summed.Add(input[i]);
                    //    i++;
                    //    if (i == input.Count - 2)
                    //    {
                    //        summed.Add(input.Last());
                    //        break;
                    //    }
                    //}
                    //input.RemoveRange(0, input.Count);
                    //input.AddRange(summed);

                    for (int i = 0; i < input.Count - input.Count % 2; i += 2)
                    {
                        input[i] += input[i + 1];
                        input[i + 1] = -1;
                    }
                    input.RemoveAll(x => x == -1);
                }

                command = Console.ReadLine().Split().ToArray();
            }
            Console.WriteLine($"[{string.Join(", ", input)}]");
        }
    }
}
