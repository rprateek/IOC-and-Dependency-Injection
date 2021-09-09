using System;
using System.Collections.Generic;
using System.Linq;
namespace LINQ
{
    /// <summary>
    /// LINQ is a query you can write it on C# and fire it on different formats such as xml, collection, RDBMS. 
    /// Remember to import System.Linq
    /// Homework
    /// What is the importance of VAR keyword in LINQ?
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            List<Customer> custs = new List<Customer>();

            custs.Add(new Customer() { name = "Prateek", address = "Sydney" });
            custs.Add(new Customer() { name = "Tunga", address = "Tonga" });
            custs.Add(new Customer() { name = "Poonga", address = "Sydney" });
            custs.Add(new Customer() { name = "Lunga", address = "Sydney" });
            custs.Add(new Customer() { name = "Dinga", address = "Denmark" });
            //Now we have a Generic list of customers called custs 
            //If we want to filter out the customers that are from sydeny then we can do that by using LINQ


            var custFilterRecords = (from temp in custs 
                                     where temp.address == "Sydney"
                                     select temp).ToList<Customer>(); // Using LINQ to filter out the data
            //We can use various filters use joins and all using LINQ 

            foreach (var item in custFilterRecords)
            {
                Console.WriteLine(item.name + "Address: "  + item.address);
            }

            Console.ReadLine();
        }
    }
    public class Customer
    {
        public string name = "";
        public string address = "";

    }
}
