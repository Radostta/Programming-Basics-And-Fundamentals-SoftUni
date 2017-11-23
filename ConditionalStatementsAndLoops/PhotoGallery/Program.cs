using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoGallery
{
    class Program
    {
        static void Main(string[] args)
        {
            int photoNumber = int.Parse(Console.ReadLine());
            int day = int.Parse(Console.ReadLine());
            int month = int.Parse(Console.ReadLine());
            int year = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            double photoSize = double.Parse(Console.ReadLine());
            int photoWidth = int.Parse(Console.ReadLine());
            int photoHeight = int.Parse(Console.ReadLine());

            Console.WriteLine($"Name: DSC_{photoNumber:d4}.jpg");
            Console.WriteLine($"Date Taken: {day:d2}/{month:d2}/{year} {hours:d2}:{minutes:d2}");
            
            if (photoSize < 1000)
            {
                Console.WriteLine($"Size: {photoSize}B");
            }
            else if (photoSize < 1000000)
            {
                Console.WriteLine($"Size: {photoSize / 1000}KB");
            }
            else
            {
                Console.WriteLine($"Size: {photoSize / 1000000}MB");
            }

            string orientation = "square";
            if (photoWidth > photoHeight)
            {
                orientation = "landscape";
            }
            else if (photoWidth < photoHeight)
            {
                orientation = "portrait";
            }
            Console.WriteLine($"Resolution: {photoWidth}x{photoHeight} ({orientation})");

        }
    }
}
