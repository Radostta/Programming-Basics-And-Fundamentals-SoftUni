using System;
using Nakov.IO; // seehttp://www.nakov.com/tags/cin

public class CinExampleNakov
{
    static void Main()
    {
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();

        Console.Write("Enter two integers x and y separated by whitespace: ");
        // cin >> x >> y;
        int x = Cin.NextInt();
        double y = Cin.NextDouble();

        Console.Write("Enter your age: ");
        int age = int.Parse(Console.ReadLine());

        Console.WriteLine("Name: {0}, Age: {1}", name, age);
        Console.WriteLine("x={0}, y={1}", x, y);

        Console.Write("Enter a positive integer number N: ");
        int n = Cin.NextInt();

        Console.Write("Enter N decimal numbers separated by a space: ");
        decimal[] numbers = new decimal[n];
        for (int i = 0; i < n; i++)
        {
            numbers[i] = Cin.NextDecimal();
        }

        Console.Write("The numbers in ascending order: ");
        Array.Sort(numbers);
        for (int i = 0; i < n; i++)
        {
            Console.Write(numbers[i]);
            Console.Write(' ');
        }
        Console.WriteLine();

        Console.WriteLine("Enter two strings seperated by a space: ");
        string firstStr = Cin.NextToken();
        string secondStr = Cin.NextToken();
        Console.WriteLine("First str={0}", firstStr);
        Console.WriteLine("Second str={0}", secondStr);

        //int n;
        //n = Cin.NextInt();

        //int[] numbers = new int[n];
        //for (int i = 0; i < n; i++)
        //{
        //    numbers[i] = Cin.NextInt();
        //}

        //for (int i = 0; i < n; i++)
        //{
        //    Console.Write(numbers[i] + " ");
        //}

        //The Nakov.IO.Cin library is also available as NuGet package:www.nuget.org/packages/Nakov.IO.Cin/. To install it to your project from Visual Studio, use the “Package Manager Console” and execute the following command:
        //Install - Package Nakov.IO.Cin
    }
}