using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var min = int.MaxValue;

            for (int i = 1; i <= n; i++)
            {
                var num = int.Parse(Console.ReadLine());

                if (num < min)
                {
                    min = num;
                }
            }

            Console.WriteLine(min);
        }
    }
}
