using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LectionDemoExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    var s = Console.ReadLine();
                    var num = int.Parse(s);
                    checked
                    {
                        Console.WriteLine(num * 200000);
                    }
                    break;
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Number is too large. Try again: ");
                }
                catch (FormatException)
                {
                    Console.WriteLine("This is not a number. Try again: ");
                }
                catch
                {
                    Console.WriteLine("Could not finish assignment. Try again: ");
                }
            }
            
           

            
            //----------------
            
            //try
            //{
            //    var firstText = File.ReadAllText("first.txt");
            //    var secondText = File.ReadAllText("second.txt");
            //    File.WriteAllText("result.txt", firstText + Environment.NewLine + secondText);
            //    Console.WriteLine("Job done!");
            //}
            //catch (Exception ex) //it could be FileNotFound Exception or Format Exception specifically
            //{
            //    Console.WriteLine(ex.Message);
            //    Console.WriteLine("Could not finish the assignment");
            //}
            //finally
            //{
            //    Console.WriteLine("Good bye");
            //}
            
        }
    }
}
