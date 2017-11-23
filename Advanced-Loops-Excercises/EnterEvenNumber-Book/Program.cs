using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterEvenNumber_Book
{
    class Program
    {
        static void Main(string[] args)
        {            
            while (true)
            {
                try
                {
                    int n = int.Parse(Console.ReadLine());
                    if (n % 2 == 0)
                    {
                        Console.WriteLine("Even number is: " + n);
                        break;
                    }
                    Console.WriteLine("The number is not even.");
                }
                catch
                {
                    Console.WriteLine("This is not a number.");
                }                
            }

        }
    }
}
