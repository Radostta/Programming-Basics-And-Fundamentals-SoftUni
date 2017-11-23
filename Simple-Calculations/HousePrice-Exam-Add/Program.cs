using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousePrice_Exam_Add
{
    class Program
    {
        static void Main(string[] args)
        {
            double smallestRoomArea = double.Parse(Console.ReadLine());
            double kitchenArea = double.Parse(Console.ReadLine());
            double sqmPrice = double.Parse(Console.ReadLine());

            double bathroomArea = smallestRoomArea / 2;
            double secondRoomArea = smallestRoomArea * 0.10 + smallestRoomArea;
            double thirdRoomArea = secondRoomArea * 0.10 + secondRoomArea;
            double area = (smallestRoomArea + kitchenArea + bathroomArea + secondRoomArea + thirdRoomArea) * 0.05 + (smallestRoomArea + kitchenArea + bathroomArea + secondRoomArea + thirdRoomArea);

            Console.WriteLine($"{(area * sqmPrice):f2}");
        }
    }
}
