using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            string months = Console.ReadLine().ToLower();
            int overnights = int.Parse(Console.ReadLine());

            double studio = 0;
            double doouble = 0;
            double suite = 0;
            double studioNight = 0;

            switch (months)
            {
                case "may":
                case "october":
                    studio = 50;
                    doouble = 65;
                    suite = 75;
                    if (overnights > 7)
                    {
                        studio = 50 - (50 * 0.05);
                    }
                    break;
                case "june":
                case "september":
                    studio = 60;
                    doouble = 72;
                    suite = 82;
                    if (overnights > 14)
                    {
                        doouble = 72 - ( 72 * 0.10);
                    }
                    break;
                case "july":
                case "august":
                case "december":
                    studio = 68;
                    doouble = 77;
                    suite = 89;
                    if (overnights > 14)
                    {
                        suite = 89 - (89 * 0.15);
                    }
                    break;
            }

            if (overnights > 7 && (months == "september" || months == "october"))
            {
                studioNight = 1;
            }


            double studioPrice = ((overnights - studioNight) * studio);
            double doublePrice = (overnights * doouble);
            double suitePrice = (overnights * suite);

            Console.WriteLine($"Studio: {studioPrice:f2} lv.");
            Console.WriteLine($"Double: {doublePrice:f2} lv.");
            Console.WriteLine($"Suite: {suitePrice:f2} lv.");

        }
    }
}
