using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Hornet_Assault
{
    class Program
    {
        static void Main(string[] args)
        {
            var beehives = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(long.Parse).ToList();
            var hornets = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(long.Parse).ToList();

            long totalHornets = hornets.Sum();

            for (int i = 0; i < beehives.Count; i++) // assaulting one by one
            {
                if (beehives[i] >= totalHornets) // when hornets are not enough
                {
                    beehives[i] = beehives[i] - totalHornets;
                    hornets.RemoveAt(0);
                    totalHornets = hornets.Sum();
                }
                else if (totalHornets > beehives[i]) //when hornets are enough
                {
                    beehives[i] = 0;
                }
                if (hornets.Count == 0)
                {
                    break;
                }
            }

            if (beehives.Sum() > 0)
            {
                foreach (var item in beehives)
                {
                    if (item > 0)
                    {
                        Console.Write($"{item} ");
                    }
                }
                Console.WriteLine();
            }
            else
            {
                foreach (var item in hornets)
                {
                    if (item > 0)
                    {
                        Console.Write($"{item} ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
