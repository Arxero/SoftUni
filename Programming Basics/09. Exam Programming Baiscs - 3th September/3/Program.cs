using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            int photos = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            string order = Console.ReadLine();

            double price = 0;

            switch (type)
            {
                case "9X13":
                    if (photos >= 50)
                    {
                        price = 0.16 - (0.16 * 0.05);
                    }
                    else
                    {
                        price = 0.16;
                    }
                    break;
                case "10X15":
                    if (photos >= 80)
                    {
                        price = 0.16 - (0.16 * 0.03);
                    }
                    else
                    {
                        price = 0.16;
                    }
                    break;
                case "13X18":
                    if (photos >= 50 && photos <= 100)
                    {
                        price = 0.38 - (0.38 * 0.03);
                    }
                    else if (photos > 100)
                    {
                        price = 0.38 - (0.38 * 0.05);
                    }
                    else
                    {
                        price = 0.38;
                    }
                    break;
                case "20X30":
                    if (photos >= 10 && photos <= 50)
                    {
                        price = 2.90 - (2.90 * 0.07);
                    }
                    else if (photos > 50)
                    {
                        price = 2.90 - (2.90 * 0.09);
                    }
                    else
                    {
                        price = 2.90;
                    }
                    break;
            }
            double calcualtion = photos * price;
            if (order == "online")
            {
                calcualtion = calcualtion - (calcualtion * 0.02);
                Console.WriteLine($"{calcualtion:f2}BGN");
            }
            else
            {
                Console.WriteLine($"{calcualtion:f2}BGN");

            }
        }
    }
}
