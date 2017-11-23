using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadFullNameExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = ReadFullName();
            Console.WriteLine($"Hello, {name}!");
        }

        static string ReadFullName()
        {
            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            return firstName + " " + lastName;
        }
    }
}
