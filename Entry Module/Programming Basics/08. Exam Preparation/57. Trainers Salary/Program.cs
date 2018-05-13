using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _57.Trainers_Salary
{
    class Program
    {
        static void Main(string[] args)
        {
            int lectures = int.Parse(Console.ReadLine()); // 9:35
            double budget = double.Parse(Console.ReadLine());

            int jelev = 0;
            int royal = 0;
            int roli = 0;
            int trofon = 0;
            int sino = 0;
            int others = 0;

            for (int i = 0; i < lectures; i++)
            {
                string name = Console.ReadLine();

                switch (name)
                {
                    case "Jelev":
                        jelev++;
                        break;
                    case "RoYaL":
                        royal++;
                        break;
                    case "Roli":
                        roli++;
                        break;
                    case "Trofon":
                        trofon++;
                        break;
                    case "Sino":
                        sino++;
                        break;
                    default:
                        others++;
                        break;
                }
            }
            double moneyPerLecture = budget / lectures;
            Console.WriteLine($"Jelev salary: {jelev * moneyPerLecture:f2} lv");
            Console.WriteLine($"RoYaL salary: {royal * moneyPerLecture:f2} lv");
            Console.WriteLine($"Roli salary: {roli * moneyPerLecture:f2} lv");
            Console.WriteLine($"Trofon salary: {trofon * moneyPerLecture:f2} lv");
            Console.WriteLine($"Sino salary: {sino * moneyPerLecture:f2} lv");
            Console.WriteLine($"Others salary: {others * moneyPerLecture:f2} lv");

        }
    }
}
