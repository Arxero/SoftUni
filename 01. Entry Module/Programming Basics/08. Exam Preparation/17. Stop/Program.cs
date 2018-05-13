using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.Stop
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); // 9:30

            int width = n * 5;
            int dots = n;

            //first row
            Console.WriteLine("{0}{1}{0}", new string ('.', n + 1), new string ('_', (width - dots) / 2 + 1));

            //second and bellow
            int dashes = (width - dots) / 2;

            for (int top = 0; top < n; top++)
            {
                Console.WriteLine(@"{0}//{1}\\{0}", new string('.', dots), new string('_', dashes - 1));
                dots--;
                dashes += 2;
            }

            //mid
            Console.WriteLine(@"//{0}STOP!{0}\\", new string ('_', (dashes - 5) / 2));

            //bellow mid
            Console.WriteLine(@"\\{0}//", new string('_', dashes - 1));
            //bott
            int dotsBott = 1;
            int dashesBott = dashes - 3;
            for (int bot = 0; bot < n - 1; bot++)
            {
                Console.WriteLine(@"{0}\\{1}//{0}", new string('.', dotsBott), new string('_', dashesBott));
                dotsBott++;
                dashesBott -= 2;

            }
        }
    }
}
