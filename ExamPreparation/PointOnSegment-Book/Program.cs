using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOnSegment_Book
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int point = int.Parse(Console.ReadLine());
            bool isIn = false;

            int smaller = Math.Min(first, second);
            int bigger = Math.Max(first, second);

            if (point >= smaller && point <= bigger) isIn = true;
            int firstDistance = Math.Abs(first - point);
            int secondDistance = Math.Abs(second - point);
            int distance = Math.Min(firstDistance, secondDistance);

            if (isIn == true) Console.WriteLine("in");
            else Console.WriteLine("out");
            Console.WriteLine(distance);
        }
    }
}
