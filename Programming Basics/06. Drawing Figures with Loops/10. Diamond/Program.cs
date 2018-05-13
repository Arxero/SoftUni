using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Diamond
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int countAsterisk = 1;
            int dashes = (n - countAsterisk) / 2;

            if (n % 2 == 0)
            {
                countAsterisk = 2;
            }

            
            //first row
            
                for (int currentDash = 0; currentDash < dashes; currentDash++)
                {
                    Console.Write("-");
                }
                for (int currentAsterisk = 0; currentAsterisk < countAsterisk; currentAsterisk++)
                {
                    Console.Write("*");
                }
                for (int currentDash = 0; currentDash < dashes; currentDash++)
                {
                    Console.Write("-");
                }
                Console.WriteLine();



            //middle rows
            int allRows = n;
            if (n % 2 == 0)
            {
                allRows--;
            }
            
            
            int rowsTopPart = (allRows - 1) / 2;
            int countMiddleDashes = countAsterisk;

            for (int currentRow = 0; currentRow < rowsTopPart; currentRow++)
            {
                dashes--;
                for (int sideDashes = 0; sideDashes < dashes; sideDashes++)
                {
                    Console.Write("-");
                }
                Console.Write("*");
                for (int MiddleDashes = 0; MiddleDashes < countMiddleDashes; MiddleDashes++)
                {
                    Console.Write("-");
                }
                countMiddleDashes += 2;
                Console.Write("*");
                for (int sideDashes = 0; sideDashes < dashes; sideDashes++)
                {
                    Console.Write("-");
                }
                Console.WriteLine();

            }

            //middle second part

            int rowsOfBottomPart = rowsTopPart -1;
            countMiddleDashes -= 4;
            for (int currentRowi = 1; currentRowi <= rowsOfBottomPart; currentRowi++)
            {
                
                for (int sideDashes = 0; sideDashes < currentRowi; sideDashes++)
                {
                    Console.Write("-");
                }
                Console.Write("*");

                for (int middleDashes = 0; middleDashes < countMiddleDashes; middleDashes++)
                {
                    Console.Write("-");
                }
                Console.Write("*");
                for (int sideDashes = 0; sideDashes < currentRowi; sideDashes++)
                {
                    Console.Write("-");
                }
                countMiddleDashes -= 2;
                Console.WriteLine();
            }

              if (n > 2)
            {
                //last row
                for (int currentDash = 0; currentDash < (n - countAsterisk) / 2; currentDash++)
                {
                    Console.Write("-");
                }
                for (int currentAsterisk = 0; currentAsterisk < countAsterisk; currentAsterisk++)
                {
                    Console.Write("*");
                }
                for (int currentDash = 0; currentDash < (n - countAsterisk) / 2; currentDash++)
                {
                    Console.Write("-");
                }
                Console.WriteLine();
            }  
        }
    }
}
