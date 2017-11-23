using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema_Book
{
    class Program
    {
        static void Main(string[] args)
        {
            var type = Console.ReadLine().ToLower();
            var c = int.Parse(Console.ReadLine());
            var r = int.Parse(Console.ReadLine());
            var seats = (double) c * r;
            var income = 0.0;

            switch (type)
            {
                case "premiere":
                    income = seats * 12.0; break;
                case "normal":
                    income = seats * 7.5; break;
                case "discount":
                    income = seats * 5.0; break;
            }
            Console.WriteLine($"{income:f2} leva");
        }
    }
}
