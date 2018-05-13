using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.Back_To_The_Past
{
    class Program
    {
        static void Main(string[] args)
        {
            double heritage = double.Parse(Console.ReadLine());
            int year = int.Parse(Console.ReadLine());
            int age = 18;

            for (int i = 1800; i <= year; i++)
            {
                if (i % 2 == 0)
                {heritage = heritage - 12000;}
                
                else
                {heritage = heritage - (12000 + (age * 50));}
                age++;
             }
            if (heritage >= 0)
            { Console.WriteLine($"Yes! He will live a carefree life and will have {heritage:f2} dollars left."); }

            else
            { Console.WriteLine($"He will need {Math.Abs(heritage):f2} dollars to survive."); }
        }
    }
}
