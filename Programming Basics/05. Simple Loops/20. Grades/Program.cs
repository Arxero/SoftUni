using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20.Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            int studentsNumber = int.Parse(Console.ReadLine()); // 12:13

            double aStudents = 0;
            double bStudents = 0;
            double cStudents = 0;
            double dStudents = 0;
            double sumAllGrades = 0;

            for (int i = 0; i < studentsNumber; i++)
            {
                double grade = double.Parse(Console.ReadLine());

                sumAllGrades += grade;

                if (grade < 3 )
                {
                    dStudents++;
                }
                else if (grade >= 3 && grade <= 3.99)
                {
                    cStudents++;
                }
                else if (grade >= 4 && grade <= 4.99)
                {
                    bStudents++;
                }
                else if (grade >=5)
                {
                    aStudents++;
                }
            }
            Console.WriteLine($"Top students: {aStudents / studentsNumber * 100:f2}%");
            Console.WriteLine($"Between 4.00 and 4.99: {bStudents / studentsNumber * 100:f2}%");
            Console.WriteLine($"Between 3.00 and 3.99: {cStudents / studentsNumber * 100:f2}%");
            Console.WriteLine($"Fail: {dStudents / studentsNumber * 100:f2}%");
            Console.WriteLine($"Average: {sumAllGrades / studentsNumber:f2}");
        }
    }
}
