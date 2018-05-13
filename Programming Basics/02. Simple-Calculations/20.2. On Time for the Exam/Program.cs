using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20.On_Time_for_the_Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int examHours = int.Parse(Console.ReadLine());
            int examMinutes = int.Parse(Console.ReadLine());
            int ariveHours = int.Parse(Console.ReadLine());
            int ariveMinutes = int.Parse(Console.ReadLine());

            var examTime = new TimeSpan(examHours, examMinutes, 0);
            var ariveTime = new TimeSpan(ariveHours, ariveMinutes, 0);

            if (ariveTime > examTime)
            {
                var delay = ariveTime - examTime;
                Console.WriteLine("Late");
                Console.WriteLine(delay.Hours != 0
                ? delay.ToString(@"h\:mm") + " hours after the start"
                : delay.Minutes + " minutes after the start");
            }

            else if (ariveTime < examTime - new TimeSpan(0, 30, 0))
            {
                var timeToWait = examTime - ariveTime;
                Console.WriteLine("Early");
                Console.WriteLine((timeToWait.Hours != 0)
                    ? timeToWait.ToString(@"h\:mm") + " hours before the start"
                    : timeToWait.Minutes + " minutes before the start");
            }
            else
            {
                var timeToWait = examTime - ariveTime;
                Console.WriteLine("On time");
                Console.WriteLine(timeToWait.Minutes + " minutes before the start");
            }

        }
    }
}
