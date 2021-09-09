using System;
using System.IO;
namespace ReadAndWriteFiles
{
    class Program
    {
        static void Main(string[] args)
        {

            File.WriteAllText(@"C:\data.txt","Hello World");
            string content = File.ReadAllText(@"C:\data.txt");
            Console.WriteLine("Hello World!");
        }


    }
}
