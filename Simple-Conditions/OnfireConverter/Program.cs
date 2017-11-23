using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnfireConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            var offerPrice = double.Parse(Console.ReadLine());
            var comPercent = double.Parse(Console.ReadLine());

            var percentWithZero = comPercent * 10 / 100;

            var priceToHotel = offerPrice * (1 - percentWithZero);

            Console.WriteLine(priceToHotel);

            
            //var comPercent = double.Parse(Console.ReadLine()) / 100.0;

            // var comLeva = offerPrice * (1.0 - comPercent);

            //Console.WriteLine(comLeva);

        }
    }
}
