using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customers.models
{
   public class CustomerProduct
    {
            public int CustomerId { get; set; }
            public int ProductId { get; set; }
            public Customer Customer { get; set; } //linking Customer and product
            public Product Product { get; set; }
    }
}
