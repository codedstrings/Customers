using Customers.models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customers.db
{
    public class CustomersDbContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<CustomerAddress> CustomerAddress { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string path = "Server=localhost\\SQLEXPRESS;Database=CustomerDb;Trusted_Connection=True;Encrypt=false;TrustServerCertificate=true";
            optionsBuilder.UseSqlServer(path);
            base.OnConfiguring(optionsBuilder);
        }
    }
}
