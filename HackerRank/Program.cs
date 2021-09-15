using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace HackerRank
{
    class Program
    {
        static void Main(string[] args)
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
            //MinMaxSum obj = new MinMaxSum();
            //string sInput = Console.ReadLine().ToString();
            //obj.ReverseString(sInput);

            Encryption obj = new Encryption();
            Console.WriteLine(obj.Base62Encrypt(7).ToString());

            Console.ReadLine();

        }

       
    }
}
