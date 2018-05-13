using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Coding_101_Exam___26_March_2016___Zelenchukova_Borsa
{
    class Program
    {
        static void Main(string[] args)
        {
            double vegetablesPrice = double.Parse(Console.ReadLine()); // 5:20
            double fruitsPrice = double.Parse(Console.ReadLine());
            double totalVegetabels = double.Parse(Console.ReadLine());
            double totalFruits = double.Parse(Console.ReadLine());

            double calculation = ((vegetablesPrice * totalVegetabels) + (fruitsPrice * totalFruits)) / 1.94;
            Console.WriteLine($"{calculation}");
        }
    }
}
