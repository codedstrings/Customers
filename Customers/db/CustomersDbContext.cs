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
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string path = "Server=localhost\\SQLEXPRESS;Database=TestStudentDb;Trusted_Connection=True;Encrypt=false;TrustServerCertificate=true";
            optionsBuilder.UseSqlServer(path);
            base.OnConfiguring(optionsBuilder);
        }
    }
}
