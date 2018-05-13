using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _33.SoftUni_Camp
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); // 5:50

            int car = 0;
            int microbus = 0;
            int smallbuss = 0;
            int buss = 0;
            int train = 0;


            for (int i = 0; i < n; i++)
            {
                int people = int.Parse(Console.ReadLine());

                if (people <= 5)
                {
                    car += people;
                }
                else if (people >= 6 && people <= 12)
                {
                    microbus += people;
                }
                else if (people >= 13 && people <= 25)
                {
                    smallbuss += people;
                }
                else if (people >= 26 && people <= 40)
                {
                    buss += people;
                }
                else if (people >= 41)
                {
                    train += people;
                }
            }
            double allPeople = car + microbus + smallbuss + buss + train ;
            Console.WriteLine($"{car / allPeople * 100:f2}%");
            Console.WriteLine($"{microbus / allPeople * 100:f2}%");
            Console.WriteLine($"{smallbuss / allPeople * 100:f2}%");
            Console.WriteLine($"{buss / allPeople * 100:f2}%");
            Console.WriteLine($"{train / allPeople * 100:f2}%");
        }
    }
}
