using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Stupid_Password_Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());

            for (int symbolOne = 1; symbolOne <= n; symbolOne++)
            {
                for (int symbolTwo = 1; symbolTwo <= n; symbolTwo++)
                {
                    for (int symbolThree = 97; symbolThree < 97 + l; symbolThree++)
                    {
                        for (int symbolFour = 97;  symbolFour < 97 + l;  symbolFour++)
                        {
                            for (int symbolFive = 1; symbolFive <= n; symbolFive++)
                            {
                                if (symbolFive > symbolOne && symbolFive > symbolTwo)
                                {
                                    Console.Write($"{symbolOne}{symbolTwo}{(char)symbolThree}{(char)symbolFour}{symbolFive} ");

                                }
                            }
                        }

                    }
                }
                
            }
            Console.WriteLine();
        }
    }
}
