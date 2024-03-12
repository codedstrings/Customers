using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customers.models
{
    public class Order
    {
        public int OrderId { get; set; }
        public string OrderNumber { get; set; }
        public int OrderQuantity { get; set; }
        public List<Product> Products { get; set; } // Many-to-Many Relationship
    }
}
