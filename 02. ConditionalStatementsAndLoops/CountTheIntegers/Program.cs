using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountTheIntegers
{
    class Program
    {
        static void Main(string[] args)
        {        
            int counter = 0;

            while (true)
            {
                try
                {
                    var input = int.Parse(Console.ReadLine());
                    counter++;
                }
                catch
                {
                    Console.WriteLine(counter);
                    break;
                }
            }                        
        }
    }
}
