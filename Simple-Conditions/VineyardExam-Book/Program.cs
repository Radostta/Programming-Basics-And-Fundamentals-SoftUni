using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VineyardExam_Book
{
    class Program
    {
        static void Main(string[] args)
        {
            var vineyardArea = int.Parse(Console.ReadLine());
            var wineArea = vineyardArea * 0.40;
            var grapesPerSquare = double.Parse(Console.ReadLine());
            var wineWanted = int.Parse(Console.ReadLine());
            var workers = int.Parse(Console.ReadLine());

            var grapes = wineArea * grapesPerSquare;
            var wine = grapes / 2.5;
            var difference = Math.Abs(wineWanted - wine);
            var winePerWorker = difference / workers;

            if (wine >= wineWanted)
            {
                Console.WriteLine("Good harvest this year! Total wine: {0} liters.", Math.Floor(wine));
                Console.WriteLine("{0} liters left -> {1} liters per person.", Math.Ceiling(difference), Math.Ceiling(winePerWorker));
            }
            else if (wine < wineWanted)
            {
                Console.WriteLine("It will be a tough winter! More {0} liters wine needed.", Math.Floor(difference));
            }


           
        }
    }
}
