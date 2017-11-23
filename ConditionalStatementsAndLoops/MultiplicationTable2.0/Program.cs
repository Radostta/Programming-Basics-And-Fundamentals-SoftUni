using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplicationTable2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int multiplier = int.Parse(Console.ReadLine());

            if (multiplier > 10)
            {
                Console.WriteLine($"{num} X {multiplier} = {num * multiplier}");
            }
            else
            {
                Console.WriteLine($"{num} X {multiplier} = {num * multiplier}");
            }

            while (multiplier < 10)
            {
                multiplier++;
                Console.WriteLine($"{num} X {multiplier} = {num * multiplier}");                
            }

            
        }
    }
}
