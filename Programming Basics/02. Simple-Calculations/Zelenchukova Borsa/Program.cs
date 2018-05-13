using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zelenchukova_Borsa
{
    class Program
    {
        static void Main(string[] args)
        {
            double vegetables = double.Parse(Console.ReadLine());
            double fruits = double.Parse(Console.ReadLine());
            int all_vegetables = int.Parse(Console.ReadLine());
            int all_fruits = int.Parse(Console.ReadLine());
            double solution_vegetables = vegetables * all_vegetables;
            double solution_fruits = fruits * all_fruits;
            double final_solution = (solution_vegetables + solution_fruits) / 1.94;
            Console.WriteLine("{0}", Math.Round(final_solution,2));
            //Console.WriteLine("{0}", Math.Round((solution_vegetables + solution_fruits) / 1.94),2);
        }
    }
}
