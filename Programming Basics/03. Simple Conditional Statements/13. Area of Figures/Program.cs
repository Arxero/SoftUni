using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Area_of_Figures
{
    class Program
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();

            double area = 0;

            if (figure == "square")
            {
                double squareSide = double.Parse(Console.ReadLine());
                area = squareSide * squareSide;
            }
            else if (figure == "rectangle")
            {
                double rectangleSideA = double.Parse(Console.ReadLine());
                double rectangleSideB = double.Parse(Console.ReadLine());
                area = rectangleSideA * rectangleSideB;
            }
            else if (figure == "circle")
            {
                double circlePerimeter = double.Parse(Console.ReadLine());
                area = 3.14159 * circlePerimeter * circlePerimeter;
            }
            else if (figure == "triangle")
            {
                double triangleSideA = double.Parse(Console.ReadLine());
                double triangleSideB = double.Parse(Console.ReadLine());
                area = triangleSideA * triangleSideB / 2;
            }
            Console.WriteLine(Math.Round(area,3));
        }
    }
}
