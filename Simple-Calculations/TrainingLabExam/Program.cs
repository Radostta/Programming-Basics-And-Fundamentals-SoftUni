using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingLabExam
{
    class Program
    {
        static void Main(string[] args)
        {
            var l = double.Parse(Console.ReadLine());
            var w = double.Parse(Console.ReadLine());

            var length = l * 100;
            var width = w * 100;

            // var rows = (int)length / 120;
            // var cols = ((int)width - 100) / 70;

            var rows = Math.Truncate(length / 120);
            var cols = Math.Truncate((width - 100) / 70);

            var seats = rows * cols - 3;

            Console.WriteLine(seats);


        }
    }
}
