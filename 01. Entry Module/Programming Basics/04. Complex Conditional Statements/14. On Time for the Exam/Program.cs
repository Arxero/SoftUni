using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.On_Time_for_the_Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int examHour = int.Parse(Console.ReadLine());
            int examMinute = int.Parse(Console.ReadLine());
            int arriveHour = int.Parse(Console.ReadLine());
            int arriveMinute = int.Parse(Console.ReadLine());

            int hoursToMinutesExam = examHour * 60;
            int allMinutesExam = hoursToMinutesExam + examMinute;
            int hoursToMinutesArrive = arriveHour * 60;
            int allMinutesArrive = hoursToMinutesArrive + arriveMinute;

            if (allMinutesArrive > allMinutesExam)
            {
                int howLate = allMinutesArrive - allMinutesExam;
                Console.WriteLine("Late");
                int convertHours = howLate / 60;
                int convertMinutes = howLate % 60;
                if (convertHours != 0)
                {
                    Console.WriteLine($"{convertHours}:{convertMinutes:d2} hours after the start");
                }
                else if (convertHours == 0)
                {
                    if (convertMinutes <= 9)
                    {
                        Console.WriteLine($"{convertMinutes} minutes after the start");
                    }
                    else
                    {
                        Console.WriteLine($"{convertMinutes:d2} minutes after the start");
                    }
                }
            }
            else if (allMinutesExam > allMinutesArrive)
            {
                int howLate = allMinutesExam - allMinutesArrive;
                int convertHours = howLate / 60;
                int convertMinutes = howLate % 60;
                if (convertHours != 0)
                {
                    Console.WriteLine("Early");
                    Console.WriteLine($"{convertHours}:{convertMinutes:d2} hours before the start");
                }
                else if (convertHours == 0)
                {
                    if (convertMinutes > 30)
                    {
                        if (convertMinutes <= 9)
                        {
                            Console.WriteLine("Early");
                            Console.WriteLine($"{convertMinutes} minutes before the start");
                        }
                        else
                        {
                            Console.WriteLine("Early");
                            Console.WriteLine($"{convertMinutes:d2} minutes before the start");
                        }
                    }
                    if (convertMinutes <= 30)
                     {
                         if (convertMinutes <= 9)
                            {
                                Console.WriteLine("On time");
                                Console.WriteLine($"{convertMinutes} minutes before the start");
                            }
                            else
                            {
                                Console.WriteLine("On time");
                                Console.WriteLine($"{convertMinutes:d2} minutes before the start");
                            }
                        }
                    }
                }
                else if (allMinutesExam == allMinutesArrive)
                {
                    Console.WriteLine("On time");
                }
            }
        }
    }


