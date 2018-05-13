using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.Stop_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine()); // 6:27
            int M = int.Parse(Console.ReadLine());
            int S = int.Parse(Console.ReadLine());


            for (int theNumbers = M; theNumbers >= N; theNumbers--)
            {

                if (theNumbers % 2 == 0 && theNumbers % 3 == 0)
                {
                    
                    if (theNumbers == S)
                    {
                        break;
                    }
                    Console.Write($"{theNumbers} ");

                }
                
            }
            Console.WriteLine();

        }
    }
}
