using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace HackerRank
{
    class Program
    {
        //while ((sinput = Console.ReadLine()) != null)
        
        static void Main(string[] args)
        {


           
            int n = Convert.ToInt32(Console.ReadLine().Trim());
            Recursion obj = new Recursion();
            int result = obj.factorial(n);

            Console.WriteLine(result);
            
        }       
       
    }

  

}
