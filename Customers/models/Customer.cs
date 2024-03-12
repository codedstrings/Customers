using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customers.models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public CustomerAddress? CustomerAddress { get; set; } //one to one
        public List<Order> Orders { get; set; } //one-to Many
        public List<CustomerProduct> CustomerProducts { get; set; } // Many-to-Many Relationship
        //cutomer-->orders-->products // Many-to-Many Relationship through CustomerProduct table
    }
}
