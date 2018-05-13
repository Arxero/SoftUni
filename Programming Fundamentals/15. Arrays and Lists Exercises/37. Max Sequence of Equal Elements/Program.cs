using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _37.Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> result = new List<int>();

            int length = 1;
            int lengthKeeper = 0;
            int number = 0;

            for (int i = 0; i < input.Count - 1; i++)
            {
                if (input[i] == input[i + 1])
                {
                    length++;
                    if (length > lengthKeeper)
                    {
                        lengthKeeper = length;
                        number = input[i];
                        result.Add(number);
                    }
                    else
                    {
                        length = 1;
                    }


                }
            }
            for (int i = 0; i < lengthKeeper; i++)
            {
                Console.Write($"{number} ");
            }
            Console.WriteLine();
        }
    }
}
