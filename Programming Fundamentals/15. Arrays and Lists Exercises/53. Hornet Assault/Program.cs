using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _53.Hornet_Assault
{
    class Program
    {
        static void Main(string[] args)
        {
            List<long> input = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(long.Parse).ToList();
            List<long> input2 = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(long.Parse).ToList();

            for (int i = 0; i < input.Count; i++)
            {
                long hornets = input2.Sum();
                
                if (input[i] >= hornets)
                {
                    input2.RemoveAt(0);
                }
                input[i] -= hornets;

                if (input2.Count == 0)
                {
                    break;
                }

            }
            input.RemoveAll(x => x <= 0);
            if (input.Any())
            {
                Console.WriteLine(string.Join(" ", input));
            }
            else
            {
                Console.WriteLine(string.Join(" ", input2));
            }

        }
    }
}
