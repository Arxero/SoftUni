using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Compare_Char_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] input = Console.ReadLine().Split().Select(char.Parse).ToArray();
            char[] input2 = Console.ReadLine().Split().Select(char.Parse).ToArray();
            int longest = Math.Max(input.Length, input2.Length);

            for (int i = 0; i < longest; i++)
            {
                //equal arrays
                if (input[i] == input2[i] && input.Length == input2.Length)
                {
                    Console.WriteLine(string.Join("", input));
                    Console.WriteLine(string.Join("", input2));
                    break;
                }

                else if (input[i] == input2[i] && input.Length > input2.Length)
                {
                    Console.WriteLine(string.Join("", input2));
                    Console.WriteLine(string.Join("", input));
                    break;
                }

                else if (input[i] == input2[i] && input.Length < input2.Length)
                {
                    Console.WriteLine(string.Join("", input));
                    Console.WriteLine(string.Join("", input2));
                    break;
                }

                // not eaqual
                if (input[i] != input2[i])
                {
                    if (input[i - i] < input2[i - i])
                    {
                        Console.WriteLine(string.Join("", input));
                        Console.WriteLine(string.Join("", input2));
                        break;
                    }
                    else if (input[i - i] > input2[i - i])
                    {
                        Console.WriteLine(string.Join("", input2));
                        Console.WriteLine(string.Join("", input));
                        break;
                    }
                }

            }
        }
    }
}
