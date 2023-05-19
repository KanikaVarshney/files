using InvSuppMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace InvSuppMVC.Context
{
    public class UserDbContext:DbContext
    {
        public UserDbContext()
        {

        }
        public UserDbContext(DbContextOptions<UserDbContext> options) : base(options) { }

        public DbSet<Inventory> Inventories { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        
    }
}
