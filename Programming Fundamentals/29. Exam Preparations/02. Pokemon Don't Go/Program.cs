using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Pokemon_Don_t_Go
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var removedSum = new List<int>();

            while (input.Any())
            {
                int indexes = int.Parse(Console.ReadLine());
                int removedElement = 0;
                if (indexes < 0)
                {
                    //input.RemoveAt(0);
                    removedElement = input.First();
                    //int lastElement = input.Last();
                    //input.Insert(0, lastElement);
                    removedSum.Add(removedElement);
                    input[0] = input[input.Count - 1];

                }
                else if (indexes > input.Count - 1)
                {
                    int lastElement = input.Last();
                    //input.Remove(input.Last());
                    //int firstElement = input.First();
                    //input.Insert(input.Count - 1, firstElement);
                    input[input.Count - 1] = input[0];
                    removedElement = lastElement;
                    removedSum.Add(removedElement);
                }
                else
                {
                    removedElement = input[indexes];
                    removedSum.Add(removedElement);
                    input.RemoveAt(indexes);
                }

                for (int i = 0; i < input.Count; i++)
                {
                    if (input[i] <= removedElement)
                    {
                        input[i] += removedElement;
                    }
                    else if (input[i] >= removedElement)
                    {
                        input[i] -= removedElement;
                    }
                }
            }
            Console.WriteLine(removedSum.Sum());
        }
    }
}
