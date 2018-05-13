using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            while (true)
            {
                var text = Console.ReadLine().Split(' ').ToArray();

                if (text[0] == "print")
                {
                        Console.WriteLine($"[{string.Join(", ", input)}]");
                    break;
                }
                if (text[0] == "add")
                {
                    int number = int.Parse(text[2]);
                    int position = int.Parse(text[1]);
                    input.Insert(position, number);
                }
                if (text[0] == "addMany")
                {

                    var number = text.Skip(2).Select(int.Parse).ToList();
                    int position = int.Parse(text[1]);
                    input.InsertRange(position, number);
                }
                if (text[0] == "contains")
                {
                    int number = int.Parse(text[1]);
                        if (input.Contains(number))
                        {
                            Console.WriteLine(input.IndexOf(number));
                        }
                        else
                        {
                            Console.WriteLine("-1");
                    }

                }
                if (text[0] == "remove")
                {
                    int positionOfNumberToBeRemoved = int.Parse(text[1]);
                    input.RemoveAt(positionOfNumberToBeRemoved);
                }
                if (text[0] == "shift")
                {
                    int position = int.Parse(text[1]);
                    position = position % input.Count;
                    var remminder = input.Take(position).ToList();
                    input.RemoveRange(0, position);
                    input.AddRange(remminder);
                }
                if (text[0] == "sumPairs")
                {
                    for (int i = 0; i < input.Count - 1; i++)
                    {
                            int sum = input[i] + input[i + 1];
                            input[i] = sum;
                            input.RemoveAt(i + 1);
                    }
                }





            }
        }
    }
}
