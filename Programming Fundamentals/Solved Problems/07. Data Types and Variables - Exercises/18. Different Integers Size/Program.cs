using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.Different_Integers_Size
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            try
            {
                long n = long.Parse(text);

                Console.WriteLine($"{n} can fit in: ");

                //sbyte
                if (n >= -128 && n <= 127)
                {
                    Console.WriteLine($"* sbyte");
                }
                //byte
                if (n >= 0 && n <= 255)
                {
                    Console.WriteLine($"* byte");
                }
                //short
                if (n >= -32768 && n <= 32767)
                {
                    Console.WriteLine($"* short");
                }
                //ushort
                if (n >= 0 && n <= 65535)
                {
                    Console.WriteLine($"* ushort");
                }
                //int
                if (n >= -2147483648 && n <= 2147483647)
                {
                    Console.WriteLine($"* int");
                }
                //uint
                if (n >= 0 && n <= 4294967295)
                {
                    Console.WriteLine($"* uint");
                }
                //long
                if (n >= -9223372036854775808 && n <= 9223372036854775807)
                {
                    Console.WriteLine($"* long");
                }
            }
            catch (Exception)
            {
                Console.WriteLine($"{text} can't fit in any type");
            }
        }
    }
}
