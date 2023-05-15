using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDEmoCRUDKanika.Models
{
    internal class BatchDbContext:DbContext
    {
        public BatchDbContext()
        {

        }


        public BatchDbContext(DbContextOptions<BatchDbContext> options) : base(options) { }
        public DbSet<Batch> Batches { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"data source=DESKTOP-OSS9N8R\SQLEXPRESS;initial catalog=EmpDb;integrated security=true;TrustServerCertificate=True");
        }
    }
}
