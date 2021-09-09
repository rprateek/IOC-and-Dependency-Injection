using System;

namespace Dynamic
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer x = new Customer();
            x.Name = "Pra";

            // We can use dynamic to check if the object has a function or not we can use dynamic
            // Dynamic won't give error during compile time but it will throw exception during run time.
            dynamic cust = new Customer();
            cust.Add(); // This will throw the exception during runtime but not during the compile time 

            // It is best practice to avoid using dynamic keyword, its better to figure out the errors during compile time. 
            // One use case of dynamic keyword is while playing around with excel columns. 

            Console.WriteLine("Hello World!");
        }
    }
    public class Customer
    {

        public string Name = "";

    }
}
