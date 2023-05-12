using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFassignment.models
{
    internal class InvDbContext:DbContext
    {
        public InvDbContext()
        {

        }


        public InvDbContext(DbContextOptions<InvDbContext> options) : base(options) { }
        public DbSet<Inventory> Inventories { get; set; }

        public DbSet<Supplier> Sups { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"data source=DESKTOP-OSS9N8R\SQLEXPRESS;initial catalog=EmpDbsecond;integrated security=true;TrustServerCertificate=True");
        }

    }
}
