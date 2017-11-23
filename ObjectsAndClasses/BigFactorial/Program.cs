using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace BigFactorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            BigInteger factorial = 1; //!n looking for the factorial
            for (int i = 2; i <= n; i++) 
            {
                factorial *= i;
            }

            Console.WriteLine(factorial);
            
                                                            
            //INFO
            //prop tab tab - snippet for adding properties to an object

            //BigInteger big = new BigInteger();
            //by pressing F12over the class we can see its details
        }
    }
}
