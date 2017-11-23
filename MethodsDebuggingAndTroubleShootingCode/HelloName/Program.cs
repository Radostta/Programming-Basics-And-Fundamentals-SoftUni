using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloName
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GreetName());
        }

        static string GreetName()
        {
            string name = Console.ReadLine();
            return "Hello, " + name + "!";
        }
    }
}
