using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Catch_the_Thief
{
    class Program
    {
        static void Main(string[] args)
        {
            string numerialType = Console.ReadLine();
            byte idsCount = byte.Parse(Console.ReadLine());

            long thiefID = 0;

            for (int i = 0; i < idsCount; i++)
            {
                long id = long.Parse(Console.ReadLine());

                if (i == 0)
                {
                    thiefID = id;
                }
                else
                {
                    if ( id >= thiefID && id <= sbyte.MaxValue && numerialType == "sbyte")
                    {
                        thiefID = id;
                    }
                    else if (id >= thiefID && id <= int.MaxValue && numerialType == "int")
                    {
                        thiefID = id;
                    }
                    else if (id >= thiefID && id <= long.MaxValue && numerialType == "long")
                    {
                        thiefID = id;
                    }
                }

            }
            Console.WriteLine(thiefID);
        }
    }
}
