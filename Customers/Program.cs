using Customers.db;
using Customers.models;

namespace Customers
{
    public class Program
    {
        static void Main(string[] args)
        {
            CustomersDbContext _dbContext = new CustomersDbContext();

            Customer customer1 = new Customer();
            customer1.Name = "Foo";
            customer1.CustomerAddress = new CustomerAddress()
            {
                City = "thrissur",
                Street = "Greenlane",
                PostalCode = 129221
            };


        }
    }
}
