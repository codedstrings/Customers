using Customers.db;
using Customers.models;
using Microsoft.Win32.SafeHandles;

namespace Customers
{
   
    public class Program
    {
        static string GetFromUser(string display)
        {
           Console.Write(display);
           return Console.ReadLine();
        }
        static void Main(string[] args)
        {
            CustomersDbContext _dbContext = new CustomersDbContext();

            Customer customer1 = new Customer();
            customer1.Name = GetFromUser("Name:");
            customer1.Age = int.Parse(GetFromUser("Age:"));
            customer1.CustomerAddress = new CustomerAddress()
            {
                City = GetFromUser("City: "),
                Street = GetFromUser("Street: "),
                PostalCode = int.Parse(GetFromUser("Postal Code: ")),
            };
            customer1.Orders = new List<Order>();
            int numberOfOrders = int.Parse(GetFromUser("Number of orders:"));

            // Loop to add orders
            for (int i = 1; i <= numberOfOrders; i++)
            {
                Console.WriteLine($"OrderNo.{i}");
                Order order = new Order
                {   
                    OrderNumber = GetFromUser("OrderCode: "),
                    OrderQuantity = int.Parse(GetFromUser("Quantity? ")),
                };

                // Add the order to the customer's Orders list
                customer1.Orders.Add(order);
               
            }
            _dbContext.Customers.Add(customer1);
            _dbContext.SaveChanges();

        }
    }
}
