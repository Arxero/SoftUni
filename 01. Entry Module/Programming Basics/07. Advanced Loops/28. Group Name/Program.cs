using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28.Group_Name
{
    class Program
    {
        static void Main(string[] args)
        {
            char uppercase = char.Parse(Console.ReadLine()); // 3:49
            char lowercase1 = char.Parse(Console.ReadLine());
            char lowercase2 = char.Parse(Console.ReadLine());
            char lowercase3 = char.Parse(Console.ReadLine());
            int num = int.Parse(Console.ReadLine());

            int counter = 0;

            for (char i = 'A'; i <= uppercase; i++)
            {
                for (char j = 'a'; j <= lowercase1; j++)
                {
                    for (char k = 'a'; k <= lowercase2; k++)
                    {
                        for (char l = 'a'; l <= lowercase3; l++)
                        {
                            for (int m = 0; m <= num; m++)
                            {
                                if (i == uppercase && j == lowercase1 && k == lowercase2 && l == lowercase3 && m == num)
                                {
                                    Console.WriteLine(counter);
                                }
                                counter++;
                            }
                        }
                    }
                }
            }
        }
    }
}
