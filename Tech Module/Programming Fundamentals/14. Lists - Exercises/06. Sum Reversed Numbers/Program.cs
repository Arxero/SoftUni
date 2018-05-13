using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Sum_Reversed_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').ToList();
            List <int>  reversedNumbers= new List<int>();

            for (int i = 0; i < input.Count; i++)
            {
                string eachElement = input[i];
                char[] element = eachElement.ToCharArray();
                char[] reversed = element.Reverse().ToArray();
                reversedNumbers.Add(int.Parse(string.Join("", reversed)));
            }
            Console.WriteLine(reversedNumbers.Sum());

        }
    }
}
