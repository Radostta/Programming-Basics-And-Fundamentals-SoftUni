using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bricks_Book
{
    class Program
    {
        static void Main(string[] args)
        {
            double bricks = double.Parse(Console.ReadLine());
            double workers = double.Parse(Console.ReadLine());
            double cartVolume = double.Parse(Console.ReadLine());

            double workerLoad = workers * cartVolume;
            double courses = bricks / workerLoad;
            Console.WriteLine(Math.Ceiling(courses));

        }
    }
}
