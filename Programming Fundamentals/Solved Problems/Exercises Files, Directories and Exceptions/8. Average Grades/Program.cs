using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.AverageGrades
{
    class Test
    {
        static void Main()
        {
            StreamReader file = new StreamReader("input.txt");
            int n = int.Parse(file.ReadLine());
            Student[] students = new Student[n];
            for (int i = 0; i < n; i++)
            {
                string[] input = file.ReadLine().Split(' ');
                students[i] = new Student() { Name = input[0], Grades = new List<double>() };
                students[i].Grades.AddRange(input.Skip(1).Select(double.Parse));
            }
            foreach (var student in students.OrderBy(x => x.Name)
                                            .ThenByDescending(x => x.AverageGrade))
            {
                if (student.AverageGrade >= 5.00)
                {
                    string formatformat = string.Format("{0} -> {1:f2}", student.Name, student.AverageGrade);
                    File.AppendAllText("output.txt", formatformat + Environment.NewLine);
                }
            }
        }
    }

    class Student
    {
        public string Name { get; set; }
        public List<double> Grades { get; set; }

        public double AverageGrade
        {
            get
            {
                return this.Grades.Average();
            }
        }
    }
}