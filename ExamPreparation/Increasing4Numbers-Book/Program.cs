using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Increasing4Numbers_Book
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int count = 0;

            for (int first = a; first <= b; first++)
            {
                for (int second = first + 1; second <= b; second++)
                {
                    for (int third = second + 1; third <= b; third++)
                    {
                        for (int forth = third + 1; forth <= b; forth++)
                        {
                            Console.WriteLine(first);
                            Console.WriteLine(second);
                            Console.WriteLine(third);
                            Console.WriteLine(forth);
                            count++;
                        }
                    }
                }
            }
            if (count == 0) Console.WriteLine("No");
            

        }
    }
}
