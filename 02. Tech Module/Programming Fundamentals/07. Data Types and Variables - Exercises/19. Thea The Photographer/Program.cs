using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19.Thea_The_Photographer
{
    class Program
    {
        static void Main(string[] args)
        {
            long pictures = long.Parse(Console.ReadLine());
            long filterTime = long.Parse(Console.ReadLine());
            long percentage = long.Parse(Console.ReadLine());
            long uploadTime = long.Parse(Console.ReadLine());

            double filteredPictures = Math.Ceiling(pictures * (percentage / 100.0));
            double timeToFilter = pictures * filterTime * 1.0;
            double timeToUpload = filteredPictures * uploadTime * 1.0;
            double totalTime = timeToFilter + timeToUpload; //in seconds

            TimeSpan time = TimeSpan.FromSeconds(totalTime);
            string result = time.ToString("d\\:hh\\:mm\\:ss");
            Console.WriteLine(result);
        }
    }
}
