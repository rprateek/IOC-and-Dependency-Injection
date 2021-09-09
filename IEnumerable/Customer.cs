using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IEnumerable
{  
    /// <summary>
    ///  Creating a customer entity and mapping it to the table that has exact same columns
    /// </summary>
        [Table("tblCustomer")]
        public class Customer
        {
            [Key]
            public int Id { get; set; }

            public string CustomerType { get; set; }
            public string FullName { get; set; }
            public string PhoneNumber { get; set; }
            public decimal BillAmount { get; set; }
            public DateTime BillDate { get; set; }
            public string Address { get; set; }

        }  
}
