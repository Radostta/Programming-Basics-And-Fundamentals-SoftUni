using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterEvenNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            while (true)
            {
                try
                {
                    n = int.Parse(Console.ReadLine());
                    if (n % 2 == 0)
                    {
                        break;
                    }
                    else
                    {
                        Console.Write("Invalid number! Enter even number: ");
                    }
                }
                catch
                {
                    Console.Write("This is not a number. Enter even number: ");                   
                }                
            }

            Console.WriteLine("The number is: " + n);
            
            
            
            
            //My solution:
            //int n = 0;
            //bool isEven = false;
            //while (true)
            //{
            //    try
            //    {
            //        n = int.Parse(Console.ReadLine());
            //        if (n % 2 == 0)
            //        {
            //            isEven = true;
            //            Console.WriteLine("Even number entered: " + n);
            //            break;
            //        }
            //        Console.Write("The number is not even. Enter even number: ");
            //    }
            //    catch
            //    {
            //        Console.Write("Invalid number! Enter even number: ");
            //    }                
            //}
                            
        }
    }
}
