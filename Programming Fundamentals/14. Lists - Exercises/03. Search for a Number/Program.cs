using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Search_for_a_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var manipulators = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            var getNumbers = input.Take(manipulators[0]).ToList();
            var deleteNumbers = getNumbers.Skip(manipulators[1]);
            if (deleteNumbers.Contains(manipulators[2]))
            {
                Console.WriteLine("YES!");
            }
            else
            {
                Console.WriteLine("NO!");
            }
        }
    }
}
