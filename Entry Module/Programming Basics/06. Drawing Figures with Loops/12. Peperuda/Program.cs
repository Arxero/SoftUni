using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Peperuda
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); //4:05

            int width = 2 * n -1;
            int height = 2 * (n - 2) + 1;
            int leftSide = n - 1;
            int rightSide = n - 1;
            int asterisk = n - 2;

            //firs row
            Console.WriteLine(@"{0}\ /{0}", new string('*', asterisk));
            for (int top = 0; top < (n - 2) / 2; top++)
            {
                Console.WriteLine(@"{0}\ /{0}", new string('-', asterisk));
                Console.WriteLine(@"{0}\ /{0}", new string('*', asterisk));
            }

            //middle @
            Console.WriteLine("{0}@", new string (' ', n - 1));

            // last row
            for (int top = 0; top < (n - 2) / 2; top++)
            {
                Console.WriteLine(@"{0}/ \{0}", new string('*', asterisk));
                Console.WriteLine(@"{0}/ \{0}", new string('-', asterisk));
            }
            Console.WriteLine(@"{0}/ \{0}", new string('*', asterisk));
        }
    }
}
