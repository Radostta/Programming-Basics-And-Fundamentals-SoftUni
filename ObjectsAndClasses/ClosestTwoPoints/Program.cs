using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClosestTwoPoints
{
    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
    }

    class Program
    {

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Point> points = new List<Point>();

            for (int i = 0; i < n; i++)
            {
                Point p = ReadPoint();
                points.Add(p);
            }

            double minDistance = double.MaxValue;
            Point closest1 = null;
            Point closest2 = null;

            for (int p1Ind = 0; p1Ind < points.Count; p1Ind++)
            {
                for (int p2Ind = 0; p2Ind < points.Count; p2Ind++) //p2Inds = p1Ind + 1 -> instead of the IF statement
                {
                    if (p1Ind != p2Ind)
                    {
                        double currentDistance = CalcDistance(points[p1Ind], points[p2Ind]);
                        if (currentDistance < minDistance)
                        {
                            minDistance = currentDistance;
                            closest1 = points[p1Ind];
                            closest2 = points[p2Ind];
                        }
                    }
                }
            }

            Console.WriteLine($"{minDistance:f3}");
            Console.WriteLine($"({closest1.X}, {closest1.Y})");
            Console.WriteLine($"({closest2.X}, {closest2.Y})");


            ////For each point I need to check another point
            //foreach (var p1 in points)
            //{
            //    foreach (var p2 in points)
            //    {
            //        //making sure we skip p1 (the distance will be 0 btw p1 and p1):
            //        if (p1 != p2) //this will not compare their X and Ys, but will see if they are the same object (their references)
            //        {

            //        }
            //    }
            //}
        }

        private static double CalcDistance(Point a, Point b)
        {
            int sideP = Math.Abs(a.X - b.X);
            int sideQ = Math.Abs(a.Y - b.Y);

            return Math.Sqrt(sideP * sideP + sideQ * sideQ);
        }

        private static Point ReadPoint()
        {
            string[] p1Values = Console.ReadLine().Split();
            Point p1 = new Point();
            p1.X = int.Parse(p1Values[0]);
            p1.Y = int.Parse(p1Values[1]);
            return p1;
        }
    }
}
