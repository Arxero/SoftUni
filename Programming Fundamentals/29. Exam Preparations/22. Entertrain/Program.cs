using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22.Entertrain
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            string commands = Console.ReadLine();
            string result = "";

            while (commands != "3:1")
            {
                string[] splitter = commands.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                string moveOne = splitter[0];
                int startIndex = int.Parse(splitter[1]);
                int endIndex = int.Parse(splitter[2]);

                for (int i = 0; i < endIndex; i++)
                {
                    result = input[startIndex + i] + input[i + 1];
                }
                commands = Console.ReadLine();
            }
            Console.WriteLine(result);
        }
    }
}
