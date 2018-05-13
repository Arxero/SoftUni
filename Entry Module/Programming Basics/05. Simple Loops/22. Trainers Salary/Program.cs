using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22.Trainers_Salary
{
    class Program
    {
        static void Main(string[] args)
        {
            int lectures = int.Parse(Console.ReadLine()); // 2:34
            double budget = double.Parse(Console.ReadLine());

            int roliLecture = 0;
            int trofonLecture = 0;
            int sinoLecture = 0;
            int jelevLecture = 0;
            int royalLecture = 0;
            int others = 0;
            double salary = 0;

            for (int i = 0; i < lectures; i++)
            {
                string name = Console.ReadLine().ToLower();

                switch (name)
                {
                    case "jelev":
                        jelevLecture++;
                        break;
                    case "royal":
                        royalLecture++;
                        break;
                    case "roli":
                        roliLecture++;
                        break;
                    case "sino":
                        sinoLecture++;
                        break;
                    case "trofon":
                        trofonLecture++;
                        break;
                    default:
                        others++;
                        break;
                }
            }
            Console.WriteLine($"Jelev salary: {jelevLecture * budget / lectures:f2} lv");
            Console.WriteLine($"RoYaL salary: {royalLecture * budget / lectures:f2} lv");
            Console.WriteLine($"Roli salary: {roliLecture * budget / lectures:f2} lv");
            Console.WriteLine($"Trofon salary: {trofonLecture * budget / lectures:f2} lv");
            Console.WriteLine($"Sino salary: {sinoLecture * budget / lectures:f2} lv");
            Console.WriteLine($"Others salary: {others * budget / lectures:f2} lv");

        }
    }
}
