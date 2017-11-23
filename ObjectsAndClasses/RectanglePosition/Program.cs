using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleArea
{
    class Program
    {
        class Rectangle
        {
            public int TopPoint { get; set; }
            public int LeftPoint { get; set; }
            public int Width { get; set; }
            public int Height { get; set; }

            //2nd way by defining another perimeter that only has "get":
            public int Area
            {
                get { return Width * Height; }
            }

            //1st way with a method:
            //public int CalcArea()
            //{
            //    return Width * Height;
            //}
        }

        static void Main(string[] args)
        {
            Rectangle r = new Rectangle { TopPoint = 10, LeftPoint = 7, Width = 42, Height = 11 };

            //Console.WriteLine(r.CalcArea()); -> printing using the method
            Console.WriteLine(r.Area); //prints 462
        }
    }    
}
