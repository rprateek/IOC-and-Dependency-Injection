using System;

namespace GarbageCollector
{
    class Program
    {
        //Check garbage collection of objects in Debug --Performance Profiling and tick .net Object Allocation Tracking
        //What is Garbage collector Gen 0,1,2? 
        // String is an object
        //What do you mean by strings are immutable?
        //How does stringbuilder improve performance?
        


        static void Main(string[] args)
        {
          
            Console.WriteLine("Start");
            for (double i = 0; i < 1000000; i++)
            {

               // int i1 = 0;
                //int y1 = i1;
                Customer x = new Customer();
                x.name = "T" + 1;
            }
          

            Console.Read();


        }

    }

    public class Customer
    {
        public string name = "";

    }
}
