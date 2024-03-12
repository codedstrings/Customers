using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customers.models
{
    public class CustomerAddress
    {
        public int Id { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public int PostalCode { get; set; }


        // Navigation props
        public int? CustomerId { get; set; }// FK

        public Customer? Customer { get; set; } //Navigation props to prevent negative values? 
    
    }
}
