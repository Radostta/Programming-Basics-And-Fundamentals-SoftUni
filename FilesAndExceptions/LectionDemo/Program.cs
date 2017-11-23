using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LectionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            ////DIRECTORIES:
            ////Creating a directory:
            //Directory.CreateDirectory("results");

            //Getting all files or directories from a directory:
            Console.WriteLine("Dirs:");
            string[] directories = Directory.GetDirectories(@"..\..\"); //in Linux and Mac the lines are /, in Windows both work
            string[] files = Directory.GetFiles(@"..\..\"); //in Linux and Mac the lines are /, in Windows both work

            foreach (var d in directories)
            {
                Console.WriteLine(d);
                foreach (var f in files)
                {
                    Console.WriteLine(f);
                }

            }

            Console.WriteLine();

            Console.WriteLine("Files:");
            foreach (var f in files)
            {
                Console.WriteLine(f);
            }
            
            //FILES:
            ////How to write all lines:
            ////string[] names = { "Pesho", "Gosho", "Kiro" };
            ////File.WriteAllLines("names.txt", names);
            ////Adding more text to names.txt:
            //File.AppendAllText("names.txt", "Niki\r\n");
            ////The file is in bin-debug - we can also open it with VS in the solution - show all files icon

            ////Checking the length of the file:
            //var fileinfo = new FileInfo("names.txt");
            //Console.WriteLine(fileinfo.Length); //output 56 - 56 bytes - we can check it in the properties of the file for comparison

            //var info = new FileInfo("names.txt");
            //Console.WriteLine($"File size: {info.Length} bytes");
            //Console.WriteLine($"Created at: {info.CreationTime}");
            //Console.WriteLine($"Path + name: {info.FullName}");
            //Console.WriteLine($"File extension: {info.Extension}");
            //Console.WriteLine($"Directory name: {info.DirectoryName}");

            ////Writing something (all text) in a file (standart encoding in .Net Framework - UTF8):

            //File.WriteAllText("hello.txt", "Здрасти, как си?\r\nOK");
            //string text = File.ReadAllText("hello.txt");
            //Console.WriteLine(text);
            //text = text + "\r\n\r\nОще един ред";
            //File.WriteAllText("new.txt", text);

            //Reading a file line by line

            //string[] lines = File.ReadAllLines("new.txt");
            //foreach (var line in lines)
            //{
            //    Console.WriteLine(line);
            //}

            //NB!
            //Do not give the whole path, as it is only usable at the given machine:
            //Instead you need to use the current directory!

            ////With specified encoding for Windows Explorer default encoding 1251:
            //string str = File.ReadAllText(@"C:\Users\rcvet\Desktop\Programming Fundamentals Sept2017\text.txt", Encoding.GetEncoding("windows-1251")); //output - the text in cyrilics
            //Console.WriteLine(str);

            //Without encoding - output - ?? ??? ???
            //string str = File.ReadAllText(@"C:\Users\rcvet\Desktop\Programming Fundamentals Sept2017\text.txt"); //read all text lines
            //Console.WriteLine(str);

            ////Decrypted.pptx
            //byte[] bytes = File.ReadAllBytes(@"C:\tmp\encrypted.pptx"); //View - file name extension - to show .pptx

            //for (int i = 0; i < bytes.Length; i++)
            //{
            //    bytes[i] = (byte)(bytes[i] - 1); //we are encrypting the file by taking each letter and replacing it with the next one
            //}

            //File.WriteAllBytes(@"C:\tmp\decrypted.pptx", bytes); //1st arg is the name and direct. of the file, 2nd arg -name of the array (bytes)

            //Console.WriteLine(bytes);

            //Encrypted.pptx:
            //byte[] bytes = File.ReadAllBytes(@"C:\Users\rcvet\Desktop\Programming Fundamentals Sept2017\10. Programming-Fundamentals-Files-Directories-and-Exceptions.pptx"); //View - file name extension - to show .pptx

            //for (int i = 0; i < bytes.Length; i++)
            //{
            //    bytes[i] = (byte)(bytes[i] + 1); //we are encrypting the file by taking each letter and replacing it with the next one
            //}

            //File.WriteAllBytes(@"C:\tmp\encrypted.pptx", bytes); //1st arg is the name and direct. of the file, 2nd arg -name of the array (bytes)

            //Console.WriteLine(bytes);

            //INFO:
            //System.IO = Input/Output

        }
    }
}
