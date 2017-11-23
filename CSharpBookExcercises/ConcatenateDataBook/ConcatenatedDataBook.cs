using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcatenateDataBook
{
    class ConcatenatedDataBook
    {
        static void Main(string[] args)
        {
            var name = Console.ReadLine();
            var lastName = Console.ReadLine();
            var age = Console.ReadLine();
            var town = Console.ReadLine();

            //Console.WriteLine($"You are {name} {lastName}, a {age}-years old person from {town}.");

            Console.WriteLine("You are " + name + ' ' + lastName + ", a " + age + "-years old person from " + town + '.');

        }
    }
}
