using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceBetweenPoints
{
    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
        //The class Point defines what will be included in the object
    }

    class Program
    {
        static Point ReadPoint()
        {
            string[] pValues = Console.ReadLine().Split();
            Point p = new Point { X = int.Parse(pValues[0]), Y = int.Parse(pValues[1]) };
            return p;
        }

        static double CalcDistance(Point a, Point b)
        {
            int sideP = Math.Abs(a.X - b.X);
            int sideQ = Math.Abs(a.Y - b.Y);

            return Math.Sqrt(sideP * sideP + sideQ * sideQ);
            //Pitagor theorem for hypotenusis (the distance) = Math.Sqrt from hyp = p*p + q*q (p is the side btw the Xs, q - btw the Ys)
        }

        static void Main(string[] args)
        {
            Point p1 = ReadPoint();
            //string[] p1Values = Console.ReadLine().Split();
            //Point p1 = new Point();
            //p1.X = int.Parse(p1Values[0]);
            //p1.Y = int.Parse(p1Values[1]);

            Point p2 = ReadPoint();
            //string[] p2Values = Console.ReadLine().Split();
            //Point p2 = new Point { X = int.Parse(p2Values[0]), Y = int.Parse(p2Values[1]) };

            var distance = CalcDistance(p1, p2);
            Console.WriteLine($"{distance:f3}");

            //INFO:
            //Point p = new Point { X = 5, Y = 7};
            //Point p = new Point();
            //p.X = 5;
            //p.Y = 7;
            //Console.WriteLine($"Point({p.X}, {p.Y})");
        }
    }
}

