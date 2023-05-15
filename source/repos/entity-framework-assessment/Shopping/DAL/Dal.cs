using Shopping.BusinessObject.models;
using Shopping.DAL.Context;
using System.Data;

namespace  Shopping.DAL
{
    public class Dal
    {
        ShoppingDbContext db = new ShoppingDbContext();
        List<Role> roles = null;

        void InitializeRoles()
        {
            if (roles == null)
            {
                roles = new List<Role>
                { new Role()
                {
                   RoleName = "Admin", DateCreated = DateTime.Now,
                    DateUpdated = null, IsActive = true },
                    new Role() { Name = "Supplier", DateCreated = DateTime.Now,
                        DateUpdated = null, IsActive = true },
                    new Role() { RoleName = "Customer", DateCreated = DateTime.Now,
                        DateUpdated = null, IsActive = true },
                    
                }
                };
            }
        }
        public int AddUser(User user)
        {
            db.Users.Add(user);
            SaveRecords();
            return 0;

        }

        void SaveRecords()
        {
            db.SaveChanges();
        }
        public Role GetRole()
        {
            return (db.Roles.FirstOrDefault(x => x.Name == "Customer"));
        }
    }
}