using System;
using System.Collections.Generic;
using System.Linq;

namespace IEnumerable
{
    class Program
    {
        static void Main(string[] args)
        {

            // Now lets create the customers
            var context = new CustomerContext("Data Source=localhost;Initial Catalog=PetShopDB;Integrated Security=True");

            // lets see how IEnumerable works
            IEnumerable<Customer> customers = context.Customers.Where(cust => cust.Id > 5);

            /// Query executed for output of IEnumerable          
            /// select *  FROM[tblCustomer] AS[t]
            // WHERE[t].[Id] > 5
            // It returned all customers who has id more than 5


            // When we change to say take top 3 then
            var topCustomers = customers.Take(3);
            
            //Query executed for output of IEnumerable
            /// select *  FROM[tblCustomer] AS[t]
            // WHERE[t].[Id] > 5
            // It returned top 3 customers who has id more than 5
            // This means the query executed is same but it filtered data from onmemory collection.


            //    foreach (var Customer in topCustomers)
            //{
            //    Console.WriteLine($"Name = {Customer.FullName} { Customer.Id}" );
            //}


            /// Now lets test IQueriable 
            /// 
            IQueryable<Customer> qCusts = context.Customers
                .Where(e => e.Id > 5);
            //  FROM [tblCustomer] AS [t]
            //WHERE[t].[Id] > 5
            // showing all the rows that are greater than 5

            var topQCustomers = qCusts.Take(3);
            // SELECT TOP(@__p_0) ....
            // FROM [tblCustomer] AS [t]
            // WHERE[t].[Id] > 5
            // It returned top 3 customers who has id more than 5

            // So in this case the query itsef changed to make it top 3 

            foreach (var Customer in topQCustomers)
            {
                Console.WriteLine($"Name = {Customer.FullName} { Customer.Id}");

            }
        }
    }    

}
