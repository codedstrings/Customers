using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customers.models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        public CustomerAddress? CustomerAddress { get; set; } //one to one
        public List<Order> Orders { get; set; } //one-to Many
       
        //cutomer-->orders-->products // Many-to-Many Relationship through CustomerProduct table
    }
}
