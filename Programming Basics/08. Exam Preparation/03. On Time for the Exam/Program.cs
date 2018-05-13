using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.On_Time_for_the_Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int startHour = int.Parse(Console.ReadLine()); // 5:05
            int startMinute = int.Parse(Console.ReadLine());
            int commingHour = int.Parse(Console.ReadLine());
            int commingMinute = int.Parse(Console.ReadLine());

            //late
            if (startHour < commingHour && startMinute > commingMinute)
            {
                int lateMinute = commingMinute + startMinute;
                Console.WriteLine("Late");
                Console.WriteLine($"{lateMinute:d2} minutes after the start");
            }

            else if (commingHour > startHour)
            {
                //hour late
                Console.WriteLine("Late");
                int lateHour = commingHour - startHour;
                int lateMinute = commingMinute - startMinute;
                Console.WriteLine($"{lateHour}:{lateMinute:d2} hours after the start");
            }
            else if (commingMinute > startMinute)
            {
                int lateMinute = commingMinute - startMinute;
                Console.WriteLine("Late");
                Console.WriteLine($"{lateMinute:d2} minutes after the start");
            }
            // on time

            else if (startHour == commingHour && startMinute == commingMinute)
            {
                Console.WriteLine("On time");
            }
            else if (startHour > commingHour && startMinute < commingMinute)
            {
                int onTime = commingMinute - startMinute;
                Console.WriteLine("On time");
                Console.WriteLine($"{onTime} minutes before the start");
            }

            // early
            else if (startHour > commingHour)
            {
                int early = startHour - commingHour;
                Console.WriteLine("Early");
                Console.WriteLine($"{early} hours before the start");
            }




        }
    }
}
