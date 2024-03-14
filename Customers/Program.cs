using Customers.db;
using Customers.Dto;
using Customers.models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Win32.SafeHandles;

namespace Customers
{
   
    public class Program
    {
        static List<CustomerDto> GetCustomerDetails()
        {
            CustomersDbContext _dbContext = new CustomersDbContext();
            List<Customer> customerList = _dbContext.Customers.ToList();
            List<CustomerDto> selectedCustomer = new List<CustomerDto>();
            //List<Customer>
            foreach (Customer item in customerList)
            {
                selectedCustomer.Add(new CustomerDto()
                {   Id = item.Id,
                    Name = item.Name
                });
            }
            return selectedCustomer;

        }
        static string GetFromUser(string display)
        {
           Console.Write(display);
           return Console.ReadLine();
        }

        static bool AddToDb()
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

            //return true for successful db insertion
            if (true)
            {
                return true; 
            }
            else
            {
                return false;
            }
        }
        static void Main(string[] args)
        {
            int choice = int.Parse(GetFromUser("1. Insert\n2. GetAll\n"));
            switch (choice)
            {
                case 1: 
                    var status = AddToDb();
                    if (status)
                    {
                        Console.WriteLine("Successful!");
                    }
                    else Console.WriteLine("Unsuccessful!");
                    break;

                case 2:
                    // Call the function to get customer details
                    List<CustomerDto> customerDetails = GetCustomerDetails();

                    // Print the details
                    foreach (var customerDetail in customerDetails)
                    {
                        Console.WriteLine($"Customer ID: {customerDetail.Id}, Name: {customerDetail.Name}");
                    }
                    break;

                default: break;
            }

        }
    }
}
