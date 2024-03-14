using Customers.db;
using Customers.Dto;
using Customers.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customers.Helper
{
    public static class CustomerDetails
    {
        public static List<CustomerDto> GetCustomerDetails()
        {
            CustomersDbContext _dbContext = new CustomersDbContext();
            List<Customer> customerList = _dbContext.Customers.ToList();
            List<CustomerDto> selectedCustomer = new List<CustomerDto>();
            //List<Customer>
            foreach (Customer item in customerList)
            {
                selectedCustomer.Add(new CustomerDto()
                {
                    Id = item.Id,
                    Name = item.Name
                });
            }
            return selectedCustomer;

        }

        public static bool AddToDb()
        {
            CustomersDbContext _dbContext = new CustomersDbContext();

            Customer customer1 = new Customer();
            customer1.Name = ReadWrite.GetStringFromUser("Name:");
            customer1.Age = ReadWrite.GetIntFromUser("Age:");
            customer1.CustomerAddress = new CustomerAddress()
            {
                City = ReadWrite.GetStringFromUser("City: "),
                Street = ReadWrite.GetStringFromUser("Street: "),
                PostalCode = ReadWrite.GetIntFromUser("Postal Code: "),
            };
            customer1.Orders = new List<Order>();
            int numberOfOrders = ReadWrite.GetIntFromUser("Number of orders:");

            // Loop to add orders
            for (int i = 1; i <= numberOfOrders; i++)
            {
                Console.WriteLine($"OrderNo.{i}");
                Order order = new Order
                {
                    OrderNumber = ReadWrite.GetStringFromUser("OrderCode: "),
                    OrderQuantity = ReadWrite.GetIntFromUser("Quantity? "),
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
    }
}
