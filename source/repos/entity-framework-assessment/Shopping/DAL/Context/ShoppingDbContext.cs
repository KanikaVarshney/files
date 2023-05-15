using Microsoft.EntityFrameworkCore;
using Shopping.BusinessObject.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping.DAL.Context
{
    internal class ShoppingDbContext:DbContext
    {
          public ShoppingDbContext()
        {

        }
        public ShoppingDbContext(DbContextOptions<ShoppingDbContext> options)
            : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=INW-920;
              Initial Catalog=shopping;Integrated Security=True;TrustServerCertificate=True");

        }
    }
}
