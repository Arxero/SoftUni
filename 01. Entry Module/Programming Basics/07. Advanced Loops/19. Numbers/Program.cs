using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19.Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int numCopy = n;
            int getSecondNum = numCopy / 10;
            int getFirstNum = getSecondNum / 10;
            int realSecondNum = getSecondNum % 10;
            int getThirdNum = numCopy % 10;
            
            int theNumber = 0;

            

            for (int rows = 0; rows < getFirstNum + realSecondNum; rows++)
            {
                for (int col = 0; col < getFirstNum + getThirdNum; col++)
                {
                    if (n % 5 == 0)
                    {
                        n = n - getFirstNum;
                        Console.Write($"{n} ");
                    }
                    else if (n % 3 == 0)
                    {
                        n -= realSecondNum;
                        Console.Write($"{n} ");
                    }
                    else
                    {
                        n = n + getThirdNum;
                        Console.Write($"{n} ");
                    }
                    
                }
                Console.WriteLine();
            }
        }
    }
}
