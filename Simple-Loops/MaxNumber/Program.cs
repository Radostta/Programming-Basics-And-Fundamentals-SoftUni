using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            //error:
            //var n = int.Parse(Console.ReadLine());

            //for (int i = 1; i < n - 1; i++)
            //{
            //    var num = int.Parse(Console.ReadLine());
            //    var max = int.Parse(Console.ReadLine());

            //    if (num > max)
            //    {
            //        max = num;
            //    }
            //}
            //Console.WriteLine(max);

            var n = int.Parse(Console.ReadLine());
            var max = int.MinValue;
            for (int i = 1; i <= n; i++)
            {
                var num = int.Parse(Console.ReadLine());
                if (num > max)
                {
                    max = num;
                }
            }
            Console.WriteLine(max);
        }
    }
}
