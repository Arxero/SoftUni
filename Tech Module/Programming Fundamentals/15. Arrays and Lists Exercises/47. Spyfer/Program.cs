using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _47.Spyfer
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<int> input = "3 2 8 0 1 1 4 3 6 2".Split(new[] {" "},StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            List<int> input = Console.ReadLine().Split(new[] {" "},StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            for (int i = 0; i < input.Count; i++)
            {
                //are in the bounds of the array?
                if (i - 1 >= 0 && i + 1 < input.Count)
                {
                    // what are the sum neigbours?
                    int sum = input[i - 1] + input[i + 1];
                    //are their sum is equal to number between them?
                    if (sum == input[i])
                    {
                        //remove next
                        input.RemoveAt(i + 1);
                        //remove previous
                        input.RemoveAt(i - 1);
                        //start from the beggining
                        i = 0;
                    }
                }
                // when the input is: 1 1 2 //
                //are in the first element and its values is same as next one?
                else if (i == 0 && input[i] == input[i + 1])
                {
                    input.RemoveAt(i + 1);
                    i = 0;
                }
                //when the input is: 2 1 1 //
                //are we in the last element and its valued is same as previous one
                else if (i == input.Count - 1 && input[i] == input[i - 1])
                {
                    input.RemoveAt(i - 1);
                    i = 0;
                }
            }
            Console.WriteLine(string.Join(" ", input));

        }
    }
}
