using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheaThePhotographer
{
    class Program
    {
        static void Main(string[] args)
        {
            double picturesCount = double.Parse(Console.ReadLine());
            double filterTimePerPicture = double.Parse(Console.ReadLine());
            double goodPicturesPercentage = double.Parse(Console.ReadLine());
            double uploadTimePerPicture = double.Parse(Console.ReadLine());

            double filterTime = picturesCount * filterTimePerPicture;
            double goodPictures = Math.Ceiling(picturesCount * goodPicturesPercentage / 100);
            double uploadTime = goodPictures * uploadTimePerPicture;
            double totalTimeInSeconds = filterTime + uploadTime;

            //var span = TimeSpan.FromSeconds(totalTimeInSeconds);
            //Console.WriteLine(span.ToString(@"d\:hh\:mm\:ss"));

            long days = (long)totalTimeInSeconds / 86400;
            long hours = (long)(totalTimeInSeconds - days * 86400) / 3600;
            long minutes = (long)(totalTimeInSeconds - days * 86400 - hours * 3600) / 60;
            long seconds = (long)totalTimeInSeconds - days * 86400 - hours * 3600 - minutes * 60;
            
            Console.WriteLine($"{days}:{hours:d2}:{minutes:d2}:{seconds:d2}");

        }
    }
}
