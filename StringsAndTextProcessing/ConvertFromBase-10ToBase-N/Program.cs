using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ConvertFromBase_10ToBase_N
{
    class Program
    {
        static void Main(string[] args)
        {
            var line = Console.ReadLine().Split(' ');
            int baseN = int.Parse(line[0]);
            BigInteger base10number = BigInteger.Parse(line[1]);

            string baseNnumber = "";
            BigInteger newNumber = 0;

            while (base10number != 0)
            {
                newNumber = base10number / baseN;
                BigInteger remainder = base10number % baseN;
                baseNnumber += remainder;

                base10number = newNumber;
            }

            var reversed = baseNnumber.ToCharArray().Reverse();

            var result = "";

            foreach (var item in reversed)
            {
                result += item;
            }

            Console.WriteLine(result);
        }        
    }
}
