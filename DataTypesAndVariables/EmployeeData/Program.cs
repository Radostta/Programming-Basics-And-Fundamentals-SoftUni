using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeData
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            byte age = byte.Parse(Console.ReadLine());
            char gender = char.Parse(Console.ReadLine());
            long personalIdNumber = long.Parse(Console.ReadLine());
            int uniqueEmployeeNumber = int.Parse(Console.ReadLine());

            Console.WriteLine($"First name: {firstName}\nLast name: {lastName}");
            Console.WriteLine($"Age: {age}\nGender: {gender}");
            Console.WriteLine($"Personal ID: {personalIdNumber}");
            Console.WriteLine($"Unique Employee number: {uniqueEmployeeNumber}");
        }
    }
}
