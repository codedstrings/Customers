using Customers.db;
using Customers.Dto;
using Customers.Helper;
using Customers.models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Win32.SafeHandles;

namespace Customers
{
   
    public class Program
    {
        static void Main(string[] args)
        {
            int choice = ReadWrite.GetIntFromUser("1. Insert\n2. GetAll\n");
            switch (choice)
            {
                case 1: 
                    var status = CustomerDetails.AddToDb();
                    if (status)
                    {
                        Console.WriteLine("Successful!");
                    }
                    else Console.WriteLine("Unsuccessful!");
                    break;

                case 2:
                    // Call the function to get customer details
                    List<CustomerDto> customerDetails = CustomerDetails.GetCustomerDetails();

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
