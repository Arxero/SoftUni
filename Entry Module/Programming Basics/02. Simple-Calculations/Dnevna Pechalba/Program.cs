using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dnevna_Pechalba
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            double M = double.Parse(Console.ReadLine());
            double USD = double.Parse(Console.ReadLine());

            double monthly_salary = N * M;
            double yearly_salary = (monthly_salary * 12) + (monthly_salary * 2.5);
            double VAT = (yearly_salary * 0.25);
            double VAT_after = (yearly_salary - VAT) * USD;
            double final_solution = VAT_after / 365;
            Console.WriteLine("{0:F2}", final_solution);
            

        }
    }
}
