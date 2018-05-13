using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.SoftUni_Camp
{
    class Program
    {
        static void Main(string[] args)
        {
            double groupsNumber = double.Parse(Console.ReadLine()); //11:05

            double people = 0;
            double carPeople = 0;
            double microbusPeople = 0;
            double smallbusPeople = 0;
            double busPeople = 0;
            double trainPeople = 0;

            for (double i = 0; i < groupsNumber; i++)
            {
                double peopleNumber = double.Parse(Console.ReadLine());

                people += peopleNumber;
                

                if (peopleNumber <= 5)
                {
                    carPeople = carPeople + peopleNumber;
                }
                else if (peopleNumber > 5 && peopleNumber <= 12)
                {
                    microbusPeople = microbusPeople + peopleNumber;
                }
                else if (peopleNumber > 12 && peopleNumber <= 25)
                {
                    smallbusPeople = smallbusPeople + peopleNumber;
                }
                else if (peopleNumber >= 26 && peopleNumber <= 40)
                {
                    busPeople = busPeople + peopleNumber;
                }
                else if (peopleNumber >= 41 )
                {
                    trainPeople = trainPeople + peopleNumber;
                }
            }
            
            Console.WriteLine($"{carPeople / people * 100:f2}%");
            Console.WriteLine($"{microbusPeople / people * 100:f2}%");
            Console.WriteLine($"{smallbusPeople / people * 100:f2}%");
            Console.WriteLine($"{busPeople / people * 100:f2}%");
            Console.WriteLine($"{trainPeople / people * 100:f2}%");
        }
    }
}
