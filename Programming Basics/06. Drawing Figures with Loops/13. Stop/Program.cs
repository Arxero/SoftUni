using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Stop
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); //5:24

            int width = n * 5;
            int dots = n + 1;
            int underscores = n * 2 + 1;
            int stop = (dots + underscores + dots - 9) / 2;
            int underscoresSecond = (2 * dots + underscores) - (dots + dots) - 2;

            //first row
            Console.WriteLine("{0}{1}{0}", new string('.', dots), new string('_', underscores));

            //second and bellow
            for (int firstPartRows = 0; firstPartRows < n; firstPartRows++)
            {
                Console.WriteLine(@"{0}//{1}\\{0}", new string('.', dots - 1), new string('_', underscoresSecond));
                dots--;
                underscoresSecond += 2;
            }
            //midd row
            Console.WriteLine(@"//{0}STOP!{0}\\", new string('_', stop));

            // bellow the stop
            for (int secondPartRows = 0; secondPartRows < n; secondPartRows++)
            {

                Console.WriteLine(@"{0}\\{1}//{0}", new string('.', dots + -1), new string('_', underscoresSecond));
                dots++;
                underscoresSecond -= 2;
            }
        }
    }
}
