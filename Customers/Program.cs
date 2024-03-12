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

            Order order1 = new Order();
            order1.OrderNumber = "O10";
            order1.OrderQuantity = 4;


            _dbContext.Customers.Add(customer1);
            _dbContext.SaveChanges();

        }
    }
}
