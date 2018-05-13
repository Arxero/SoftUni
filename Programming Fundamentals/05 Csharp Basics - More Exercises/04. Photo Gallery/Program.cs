using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Photo_Gallery
{
    class Program
    {
        static void Main(string[] args)
        {
            int photoNumber = int.Parse(Console.ReadLine());
            int theDay = int.Parse(Console.ReadLine());
            int theMonth = int.Parse(Console.ReadLine());
            int theYear = int.Parse(Console.ReadLine());
            int hoursTaken = int.Parse(Console.ReadLine());
            int minutesTaken = int.Parse(Console.ReadLine());
            int photoSize = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());

            Console.WriteLine($"Name: DSC_{photoNumber:d4}.jpg");
            Console.WriteLine($"Date Taken: {theDay:d2}/{theMonth:d2}/{theYear:d4} {hoursTaken:d2}:{minutesTaken:d2}");

            double sizeBeforeCalculating = 0;
            string sizeName = "";
            if (photoSize < 1000)
            {
                sizeName = "B";
                sizeBeforeCalculating = photoSize;
                
            }
            else if (photoSize >= 1000 && photoSize < 1000000)
            {
                sizeName = "KB";
                sizeBeforeCalculating = photoSize / 1000.0;
            }
            else if (photoSize >= 1000000)
            {
                sizeName = "MB";
                sizeBeforeCalculating = Math.Round(photoSize / 1000000.0, 1);
            }
            Console.WriteLine($"Size: {sizeBeforeCalculating}{sizeName}");
            //Console.WriteLine($"Size: {photoSize / 1000000.0:f1}MB");

            string orientation = "";
            if (width > height)
            {
                orientation = "landscape";
            }
            else if (width < height)
            {
                orientation = "portrait";
            }
            else if (width == height)
            {
                orientation = "square";
            }
            Console.WriteLine($"Resolution: {width}x{height} ({orientation})");
        }
    }
}
