using System;

namespace EnumsParamsDynamicRegex
{
    /// <summary>
    /// constant is the value that can remain constant that can be declared and assigned a value
    /// You cannot change the value of a constant
    /// If you have group of constants that you want to use 
    /// </summary>
    class Program
    {
        const double PI = 3.14;
        enum CustomErrors
        {
            FileNotFound=1001,
            SocketError=1002,
            Unknown = 1003
        }
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter a decimal:");
            //double d = Convert.ToDouble(Console.ReadLine());
            //if (d==PI)
            //{
            //    Console.WriteLine("This is value of pie");
            //}
            //else
            //{
            //    Console.WriteLine("This is nothing");
            //}

            // No if we have group of constants then we can use ENUMS
            //int errorvalue = 1001;

            //while using for enum we have to  convert it to custom errors ENUM

            CustomErrors errorvalue = (CustomErrors)1001;
            if (errorvalue == CustomErrors.FileNotFound)
            {
                // file not found
            }
            else if (errorvalue==CustomErrors.SocketError)
            {
                //socket exception
            }
            else if (errorvalue == CustomErrors.Unknown)
            {
                // unknown exception
            }


        }
    }
}
