﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleArea12DigitsPrecision
{
    class Program
    {
        static void Main(string[] args)
        {
            double radius = double.Parse(Console.ReadLine());
            double circleArea = Math.PI * radius * radius;
            Console.WriteLine($"{circleArea:f12}");
        }
    }
}
