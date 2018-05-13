using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23.Byte_Flip
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split().Reverse().Where(x => x.Length == 2).ToArray();

            for (int i = 0; i < input.Length; i++)
            {
                input[i] = new string(input[i].Reverse().ToArray());
                int numbers = int.Parse(input[i], System.Globalization.NumberStyles.HexNumber);
                Console.Write((char)numbers);
            }
            Console.WriteLine();
        }
    }
}
