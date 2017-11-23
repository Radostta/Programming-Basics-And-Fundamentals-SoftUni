using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades_Exam_Add
{
    class Program
    {
        static void Main(string[] args)
        {
            int studentCount = int.Parse(Console.ReadLine());
            double fail = 0.00;
            double threeUp = 0.00;
            double fourUp = 0.00;
            double top = 0.00;
            double sumGrades = 0.00;

            for (int currentStudent = 0; currentStudent < studentCount; currentStudent++)
            {
                double studentGrade = double.Parse(Console.ReadLine());

                if (studentGrade >= 2.00 && studentGrade <= 2.99)
                {
                    fail++;
                    sumGrades += studentGrade;
                }
                else if (studentGrade >= 3.00 && studentGrade <= 3.99)
                {
                    threeUp++;
                    sumGrades += studentGrade;
                }
                else if (studentGrade >= 4.00 && studentGrade <= 4.99)
                {
                    fourUp++;
                    sumGrades += studentGrade;
                }
                else if (studentGrade >= 5.00)
                {
                    top++;
                    sumGrades += studentGrade;
                }
            }

            double topPercent = top / studentCount * 100.00;
            double fourUpPercent = fourUp / studentCount * 100.00;
            double threeUpPercent = threeUp / studentCount * 100.00;
            double failPercent = fail / studentCount * 100.00;
            double avrGrade = sumGrades / studentCount;

            Console.WriteLine($"Top students: {topPercent:f2}%");
            Console.WriteLine($"Between 4.00 and 4.99: {fourUpPercent:f2}%");
            Console.WriteLine($"Between 3.00 and 3.99: {threeUpPercent:f2}%");
            Console.WriteLine($"Fail: {failPercent:f2}%");
            Console.WriteLine($"Average: {avrGrade:f2}");

        }
    }
}
