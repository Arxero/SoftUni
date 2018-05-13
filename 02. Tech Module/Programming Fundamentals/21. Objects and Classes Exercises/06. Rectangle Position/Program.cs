using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Rectangle_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r1 = ReadRectangle();
            Rectangle r2 = ReadRectangle();

            if (r1.IsInside(r2))
            {
                Console.WriteLine("Inside");
            }
            else
            {
                Console.WriteLine("Not inside");
            }

        }

        public static Rectangle ReadRectangle()
        {
            int[] size = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Rectangle rectangle = new Rectangle() { Left = size.First(), Top = size.Skip(1).First(), Width = size.Skip(2).First(), Height = size.Skip(3).First() };
            return rectangle;
        }
    }

    class Rectangle
    {
        public int Top { get; set; }
        public int Left { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }

        public int Right { get { return Left + Width; } }
        public int Bottom { get { return Top + Height; } }

        public bool IsInside(Rectangle other)
        {
            bool isInLeft = Left >= other.Left;
            bool isInRight = Right <= other.Right;

            bool isInTop = Top >= other.Top;
            bool isInBottom = Bottom <= other.Bottom;

            bool isInHorizontal = isInLeft && isInRight;
            bool isInVertical = isInTop && isInBottom;
            return isInHorizontal && isInVertical;
        }

        
    }
}
