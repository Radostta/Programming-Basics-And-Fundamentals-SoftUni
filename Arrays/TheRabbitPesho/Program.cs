using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheRabbitPesho
{
    class Program
    {
        static void Main(string[] args)
        {
            //    ////The rabbit Pesho jumps 55 times around an array of n cells. Where will it land? :)
            //    ////Imagine the cells in a circle, first cell is with index 0
            //    ////we do not need an array for a solution

            int n = int.Parse(Console.ReadLine()); //cells count
            int jumps = int.Parse(Console.ReadLine());

            var landOn = jumps % n;
            Console.WriteLine(landOn);

            //    ////If each time in every cell the rabbit is gathering coins, we will need an array to keep the value of the coins


        }
    }
}
