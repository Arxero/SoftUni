using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Square_Frame
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            char plus = '+';
            char dash = '-';
            char pipe = '|';
            char whiteSpace = ' ' ;

            int universal = size - 2;
            //top
            Console.Write(plus);
            for (int currentCol = 0; currentCol < universal; currentCol++)
            {
                Console.Write("{0}{1}", whiteSpace, dash);
            }
            Console.WriteLine("{0}{1}", whiteSpace, plus);

            //middle
            for (int i = 0; i < universal; i++)
            {
                Console.Write(pipe);
                for (int currentCol = 0; currentCol < universal; currentCol++)
                {
                    Console.Write("{0}{1}", whiteSpace, dash);
                }
                Console.WriteLine("{0}{1}", whiteSpace, pipe);
            }


            //bottom
            Console.Write(plus);
            for (int currentCol = 0; currentCol < universal; currentCol++)
            {
                Console.Write("{0}{1}", whiteSpace, dash);
            }
            Console.WriteLine("{0}{1}", whiteSpace, plus);

        }
    }
}
