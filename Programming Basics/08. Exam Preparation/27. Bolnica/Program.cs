using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27.Bolnica
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); // 6:20

            int doctorsAbailable = 7;
            int treatedPatients = 0;
            int untreatedPatients = 0;
            int treatedInherit = 0;
            int untreatedInherit = 0;
            int treatedInherit2 = 0;
            int untreatedInherit2 = 0;

            for (int i = 1; i <= n; i++)
            {
                if (untreatedPatients > treatedPatients)
                {
                    doctorsAbailable++;
                }
                int patiants = int.Parse(Console.ReadLine());
                treatedPatients = doctorsAbailable;
                treatedInherit = treatedInherit + treatedPatients;
                treatedInherit2 = treatedInherit - treatedPatients;
                untreatedPatients = patiants - doctorsAbailable;
                untreatedInherit = untreatedInherit + untreatedPatients;
                //untreatedInherit2 = untreatedInherit - untreatedInherit;

            }
            Console.WriteLine(treatedInherit);
            Console.WriteLine(untreatedInherit);
        }
    }
}
