using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Draw_a_Filled_Square
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            topAndBott(n);
            midRows(n);
            topAndBott(n);
        }
        static void topAndBott(int n)
        {
            Console.WriteLine("{0}", new string('-', n * 2));
        }
        static void midRows(int n)
        {
            for (int rows = 0; rows < n - 2; rows++)
            {
                Console.Write("-");
                for (int i = 1; i < n; i++)
                {
                    Console.Write("\\/");
                }
                Console.WriteLine("-");
            }
        }
    }
}
