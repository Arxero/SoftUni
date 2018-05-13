using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _76.Triugalnik
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); // 5:12

            int width = (4 * n) + 1;
            int height = (2 * n) + 1;

            //first
            Console.WriteLine("{0}", new string ('#', width));
            //second
            int dots = 1;
            int number = (width - 3) / 2;
            int empty = 1;
            for (int top = 0; top < n / 2; top++)
            {
                Console.WriteLine("{0}{1}{2}{1}{0}", new string('.', dots), new string('#', number), new string(' ', empty));
                dots++;
                number -= 2;
                empty += 2;
            }
            //mid
            Console.WriteLine("{0}{1}{2}(@){2}{1}{0}", new string ('.', dots), new string ('#', number), new string (' ', (empty - 3) / 2));
            //bellow
            int dotsBellow = dots + 1;
            int numberBellow = number - 2;
            int emptyBellow = empty + 2;
            int rowsBellow = ((height - (n / 2)) - n) - 2;
            for (int bellow = 0; bellow < rowsBellow; bellow++)
            {
                Console.WriteLine("{0}{1}{2}{1}{0}", new string('.', dotsBellow), new string('#', numberBellow), new string(' ', emptyBellow));
                dotsBellow++;
                numberBellow -= 2;
                emptyBellow += 2;
            }
            //bott
            int dotsBott = dotsBellow;
            int numberBott = width - (dotsBellow * 2);
            for (int bott = 0; bott < n; bott++)
            {
                Console.WriteLine("{0}{1}{0}", new string('.', dotsBott), new string('#', numberBott));
                dotsBott++;
                numberBott -= 2;
            }
        }
    }
}
