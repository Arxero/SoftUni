using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _54.Endurance_Rally
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] name = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            List<decimal> input = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(decimal.Parse).ToList();
            List<int> checkpoint = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            for (int i = 0; i < name.Length; i++)
            {
                char[] nameSplit = name[i].ToString().ToCharArray();
                decimal fuel = nameSplit[0];
                int count = 0;

                for (int k = 0; k < input.Count; k++)
                {
                    count = k;
                    if (checkpoint.Contains(k))
                    {
                        fuel += input[k];
                    }
                    else
                    {
                        fuel -= input[k];
                        if (fuel <= 0)
                        {
                            break;
                        }
                    }
                }
                if (fuel > 0)
                {
                    Console.WriteLine($"{name[i]} - fuel left {fuel:f2}");
                }
                else
                {
                    Console.WriteLine($"{name[i]} - reached {count}");
                }
            }
        }
    }
}
