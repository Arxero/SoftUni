using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _45.Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            int students = int.Parse(Console.ReadLine()); // 6:25

            double top = 0;
            double fourTo5 = 0;
            double threeTo4 = 0;
            double fail = 0;
            double average = 0;

            for (int i = 0; i < students; i++)
            {
                double grade = double.Parse(Console.ReadLine());
                if (grade >= 5)
                {
                    top++;
                }
                else if (grade >= 4 && grade <= 4.99)
                {
                    fourTo5++;
                }
                else if (grade >= 3 && grade <= 3.99)
                {
                    threeTo4++;
                }
                else if (grade < 3)
                {
                    fail++;
                }
                average = average + grade;
            }
            Console.WriteLine($"Top students: {top / students * 100:f2}%");
            Console.WriteLine($"Between 4.00 and 4.99: {fourTo5 / students * 100:f2}%");
            Console.WriteLine($"Between 3.00 and 3.99: {threeTo4 / students * 100:f2}%");
            Console.WriteLine($"Fail: {fail / students * 100:f2}%");
            Console.WriteLine($"Average: {average / students:f2}");
        }
    }
}
