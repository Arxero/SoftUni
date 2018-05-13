using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _56.Anonymous_Threat
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).ToList();
            string[] command = Console.ReadLine().Split().ToArray();

            List<string> result = new List<string>();

            while (command[0] != "3:1")
            {
                string comand = command[0];
                int start = int.Parse(command[1]);
                int end = int.Parse(command[2]);

                switch (comand)
                {
                    case "merge":
                        if (start < 0 || start > input.Count - 1)
                        {
                            start = 0;
                        }
                        if (end > input.Count - 1)
                        {
                            end = input.Count - 1;
                        }

                        for (int i = start; i < end; i++)
                        {
                            input[start] += input[start + 1];
                            input.Remove(input[start + 1]);
                        }
                        break;
                    case "divide":
                        int count = input[start].Count() / end;
                        string toBeDivided = input[start];
                        List<string> divided = new List<string>();

                        for (int i = 0; i < end; i++)
                        {
                            if (i == end - 1)
                            {
                                divided.Add(toBeDivided.Substring(i * count));
                            }
                            else
                            {
                                divided.Add(toBeDivided.Substring(i * count, count));
                            }
                        }
                        input.RemoveAt(start);
                        input.InsertRange(start, divided);
                        break;
                }
                command = Console.ReadLine().Split().ToArray();
            }
            Console.WriteLine(string.Join(" ", input));

        }
    }
}
