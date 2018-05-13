using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Rectangle_of_N_x_N_Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                for (int rows = 0; rows < 10; rows++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            //different soluiton using new string 
            //int stars = int.Parse(Console.ReadLine());
            //for (int i = 0; i < stars; i++)
            //{
            //    Console.WriteLine(new string('*', stars));
            //}
        }
    }
}
