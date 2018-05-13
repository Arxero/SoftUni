using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.Hospital
{
    class Program
    {
        static void Main(string[] args)
        {
            int timeInterval = int.Parse(Console.ReadLine()); //8:22

            int doctors = 7;
            int treatedPatients = 0;
            int unTreatedPatients = 0;

            for (int i = 1; i <= timeInterval; i++)
            {
                int patients = int.Parse(Console.ReadLine());

                if ((i % 3 == 0) && (unTreatedPatients > treatedPatients))
                {
                    doctors++;
                }

                if (patients == doctors)
                {
                    treatedPatients = treatedPatients + doctors;
                }
                else if (patients > doctors)
                {
                    treatedPatients = treatedPatients + doctors;
                    patients = patients - doctors;
                    unTreatedPatients = unTreatedPatients + patients;
                }
                else
                {
                    treatedPatients = treatedPatients + patients;
                }
            }
            Console.WriteLine($"Treated patients: {treatedPatients}.");
            Console.WriteLine($"Untreated patients: {unTreatedPatients}.");

        }
    }
}
