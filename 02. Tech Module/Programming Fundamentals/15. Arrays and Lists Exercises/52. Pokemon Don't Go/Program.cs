using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _52.Pokemon_Don_t_Go
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            List<int> removed = new List<int>();

            while (input.Any())
            {
                int element = int.Parse(Console.ReadLine());
                int value = 0;

                if (element < 0)
                {
                    value = input[0];
                    removed.Add(value);
                    input[0] = input.Last();

                }
                else if (element > input.Count - 1)
                {
                    value = input.Last();
                    removed.Add(value);
                    input[input.Count - 1] = input[0];
                }
                else
                {
                    value = input[element];
                    input.RemoveAt(element);
                    removed.Add(value);
                }

                for (int i = 0; i < input.Count; i++)
                {
                    if (input[i] <= value)
                    {
                        input[i] += value;
                    }
                    else if (input[i] > value)
                    {
                        input[i] -= value;
                    }
                }
            }
            Console.WriteLine(removed.Sum());
        }
    }
}
