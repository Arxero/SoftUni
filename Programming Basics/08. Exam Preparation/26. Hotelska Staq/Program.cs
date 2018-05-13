using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26.Hotelska_Staq
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine().ToLower(); // 4:42
            int overnights = int.Parse(Console.ReadLine());

            double studio = 0;
            double apartment = 0;
            double discount = 0;
            double discountApartment = 0;

            switch (month)
            {
                case "may":
                    studio = 50;
                    apartment = 65;
                    break;
                case "october":
                    studio = 50;
                    apartment = 65;
                    break;
                case "june":
                    studio = 75.20;
                    apartment = 68.70;
                    break;
                case "september":
                    studio = 75.20;
                    apartment = 68.70;
                    break;
                case "july":
                    studio = 76;
                    apartment = 77;
                    break;
                case "august":
                    studio = 76;
                    apartment = 77;
                    break;
            }
            if ((overnights > 7 && overnights < 14) && (month == "may" || month == "october"))
            {
                discount = 0.05;
            }
            else if ((overnights > 14) && (month == "may" || month == "october"))
            {
                discount = 0.30;
                discountApartment = 0.10;
            }
            else if ((overnights > 14) && (month == "june" || month == "september"))
            {
                discount = 0.20;
                discountApartment = 0.10;
            }
            else if (overnights > 14 && !(month == "may" || month == "october") && !(month == "june" || month == "september"))
            {
                discountApartment = 0.10;
            }
            double apartmentPrice = apartment * overnights;
            double apartmentPriceDiscount = apartmentPrice * discountApartment;
            double finalApartment = apartmentPrice - apartmentPriceDiscount;
            double studioPrice = studio * overnights;
            double studioPriceDiscount = studioPrice * discount;
            double finalStudio = studioPrice - studioPriceDiscount;

            Console.WriteLine($"Apartment: {finalApartment:f2} lv.");
            Console.WriteLine($"Studio: {finalStudio:f2} lv.");

        }
    }
}
