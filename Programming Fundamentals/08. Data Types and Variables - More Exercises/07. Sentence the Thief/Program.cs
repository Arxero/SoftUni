using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Sentence_the_Thief
{
    class Program
    {
        static void Main(string[] args)
        {
            string numerialType = Console.ReadLine();
            byte idsCount = byte.Parse(Console.ReadLine());

            long thiefID = 0;
            decimal sentence = 0;

            for (int i = 0; i < idsCount; i++)
            {
                long id = long.Parse(Console.ReadLine());

                if (i == 0)
                {
                    thiefID = id;
                }
                else
                {
                    if (id >= thiefID && id <= sbyte.MaxValue && numerialType == "sbyte")
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
            if (thiefID < 0)
            {
                sentence = Math.Ceiling((decimal)thiefID / sbyte.MinValue);
            }
            else if (thiefID >= 0)
            {
                sentence = Math.Ceiling((decimal)thiefID / sbyte.MaxValue);
            }

            if (sentence > 1)
            {
                Console.WriteLine($"Prisoner with id {thiefID} is sentenced to {Math.Abs(sentence)} years");
            }
            else
            {
                Console.WriteLine($"Prisoner with id {thiefID} is sentenced to {Math.Abs(sentence)} year");
            }
        }
    }
}
