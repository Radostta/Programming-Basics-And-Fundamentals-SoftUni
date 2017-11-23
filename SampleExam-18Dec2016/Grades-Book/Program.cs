using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades_Book
{
    class Program
    {
        static void Main(string[] args)
        {
            int studentsCount = int.Parse(Console.ReadLine());
            double allGrades = 0.00;
            double fail = 0;
            double btw3and4 = 0;
            double btw4nd5 = 0;
            double top = 0;


            for (int currentStudent = 0; currentStudent < studentsCount; currentStudent++)
            {
                double grade = double.Parse(Console.ReadLine());
                allGrades += grade;
                if (grade >= 2.00 && grade <= 2.99) fail++;
                else if (grade >= 3.00 && grade <= 3.99) btw3and4++;
                else if (grade >= 4.00 && grade <= 4.99) btw4nd5++;
                else if (grade >= 5.00) top++;               
            }

            double average = allGrades / studentsCount;
            double topPercent = top / studentsCount * 100;
            double threeFourPercent = btw3and4 / studentsCount * 100;
            double fourFivePercent = btw4nd5 / studentsCount * 100;
            double failPercent = fail / studentsCount * 100;

            Console.WriteLine($"Top students: {topPercent:f2}%");
            Console.WriteLine($"Between 4.00 and 4.99: {fourFivePercent:f2}%");
            Console.WriteLine($"Between 3.00 and 3.99: {threeFourPercent:f2}%");
            Console.WriteLine($"Fail: {failPercent:f2}%");
            Console.WriteLine($"Average: {average:f2}");

        }
    }
}
