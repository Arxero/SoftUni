using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.Hotel_Room
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine().ToLower();
            int nights = int.Parse(Console.ReadLine());

            double studioPrice = 0;
            double apartmentPrice = 0;
            double priceDiscountStudio = 0;
            double priceDiscountApartment = 0;
            double studioCalculations = 0;
            double apartmentCalculations = 0;
            double finalStudioCalculations = 0;
            double finalApartmentCalculations = 0;

            if (month == "may" || month == "october")
            {
                studioPrice = 50;
                apartmentPrice = 65;
                if (nights > 7 && nights <= 14)
                {
                    //Apartment
                    apartmentCalculations = nights * apartmentPrice;
                    priceDiscountApartment = apartmentCalculations * 0;
                    finalApartmentCalculations = apartmentCalculations - priceDiscountApartment;
                    Console.WriteLine($"Apartment: {finalApartmentCalculations:f2} lv.");
                    //Studio
                    studioCalculations = nights * studioPrice;
                    priceDiscountStudio = studioCalculations * 0.05;
                    finalStudioCalculations = studioCalculations - priceDiscountStudio;
                    Console.WriteLine($"Studio: {finalStudioCalculations:f2} lv.");

                }
                else if (nights > 14)
                {
                    //Apartment
                    apartmentCalculations = nights * apartmentPrice;
                    priceDiscountApartment = apartmentCalculations * 0.1;
                    finalApartmentCalculations = apartmentCalculations - priceDiscountApartment;
                    Console.WriteLine($"Apartment: {finalApartmentCalculations:f2} lv.");
                    //Studio
                    studioCalculations = nights * studioPrice;
                    priceDiscountStudio = studioCalculations * 0.30;
                    finalStudioCalculations = studioCalculations - priceDiscountStudio;
                    Console.WriteLine($"Studio: {finalStudioCalculations:f2} lv.");
                }
                else
                {
                    //Apartment
                    apartmentCalculations = nights * apartmentPrice;
                    priceDiscountApartment = apartmentCalculations * 0;
                    finalApartmentCalculations = apartmentCalculations - priceDiscountApartment;
                    Console.WriteLine($"Apartment: {finalApartmentCalculations:f2} lv.");
                    //Studio
                    studioCalculations = nights * studioPrice;
                    priceDiscountStudio = studioCalculations * 0;
                    finalStudioCalculations = studioCalculations - priceDiscountStudio;
                    Console.WriteLine($"Studio: {finalStudioCalculations:f2} lv.");
                }
            }
            else if (month == "june" || month == "september")
            {
                studioPrice = 75.20;
                apartmentPrice = 68.70;
                if (nights > 7 && nights <= 14)
                {
                    //Apartment
                    apartmentCalculations = nights * apartmentPrice;
                    priceDiscountApartment = apartmentCalculations * 0;
                    finalApartmentCalculations = apartmentCalculations - priceDiscountApartment;
                    Console.WriteLine($"Apartment: {finalApartmentCalculations:f2} lv.");
                    //Studio
                    studioCalculations = nights * studioPrice;
                    priceDiscountStudio = studioCalculations * 0;
                    finalStudioCalculations = studioCalculations - priceDiscountStudio;
                    Console.WriteLine($"Studio: {finalStudioCalculations:f2} lv.");

                }
                else if (nights > 14)
                {
                    //Apartment
                    apartmentCalculations = nights * apartmentPrice;
                    priceDiscountApartment = apartmentCalculations * 0.1;
                    finalApartmentCalculations = apartmentCalculations - priceDiscountApartment;
                    Console.WriteLine($"Apartment: {finalApartmentCalculations:f2} lv.");
                    //Studio
                    studioCalculations = nights * studioPrice;
                    priceDiscountStudio = studioCalculations * 0.20;
                    finalStudioCalculations = studioCalculations - priceDiscountStudio;
                    Console.WriteLine($"Studio: {finalStudioCalculations:f2} lv.");
                }
                else
                {
                    //Apartment
                    apartmentCalculations = nights * apartmentPrice;
                    priceDiscountApartment = apartmentCalculations * 0;
                    finalApartmentCalculations = apartmentCalculations - priceDiscountApartment;
                    Console.WriteLine($"Apartment: {finalApartmentCalculations:f2} lv.");
                    //Studio
                    studioCalculations = nights * studioPrice;
                    priceDiscountStudio = studioCalculations * 0;
                    finalStudioCalculations = studioCalculations - priceDiscountStudio;
                    Console.WriteLine($"Studio: {finalStudioCalculations:f2} lv.");
                }
            }
            else if (month == "july" || month == "august")
            {
                studioPrice = 76;
                apartmentPrice = 77;
                if (nights > 7 && nights <= 14)
                {
                    //Apartment
                    apartmentCalculations = nights * apartmentPrice;
                    priceDiscountApartment = apartmentCalculations * 0;
                    finalApartmentCalculations = apartmentCalculations - priceDiscountApartment;
                    Console.WriteLine($"Apartment: {finalApartmentCalculations:f2} lv.");
                    //Studio
                    studioCalculations = nights * studioPrice;
                    priceDiscountStudio = studioCalculations * 0;
                    finalStudioCalculations = studioCalculations - priceDiscountStudio;
                    Console.WriteLine($"Studio: {finalStudioCalculations:f2} lv.");

                }
                else if (nights > 14)
                {
                    //Apartment
                    apartmentCalculations = nights * apartmentPrice;
                    priceDiscountApartment = apartmentCalculations * 0.1;
                    finalApartmentCalculations = apartmentCalculations - priceDiscountApartment;
                    Console.WriteLine($"Apartment: {finalApartmentCalculations:f2} lv.");
                    //Studio
                    studioCalculations = nights * studioPrice;
                    priceDiscountStudio = studioCalculations * 0;
                    finalStudioCalculations = studioCalculations - priceDiscountStudio;
                    Console.WriteLine($"Studio: {finalStudioCalculations:f2} lv.");
                }
                else
                {
                    //Apartment
                    apartmentCalculations = nights * apartmentPrice;
                    priceDiscountApartment = apartmentCalculations * 0;
                    finalApartmentCalculations = apartmentCalculations - priceDiscountApartment;
                    Console.WriteLine($"Apartment: {finalApartmentCalculations:f2} lv.");
                    //Studio
                    studioCalculations = nights * studioPrice;
                    priceDiscountStudio = studioCalculations * 0;
                    finalStudioCalculations = studioCalculations - priceDiscountStudio;
                    Console.WriteLine($"Studio: {finalStudioCalculations:f2} lv.");
                }
            }
        }
    }
}
