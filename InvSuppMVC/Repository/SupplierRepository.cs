using InvSuppMVC.Context;
using InvSuppMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace InvSuppMVC.Repository
{
    public class SupplierRepository:InterfaceSupplier
    {
        UserDbContext _db;
        public SupplierRepository(UserDbContext db)
        {
            _db = db;
        }

        public List<Supplier> GetSupplier()
        {
            return _db.Suppliers.ToList();
        }
        public Supplier SuppliersById(int id)
        {
            return _db.Suppliers.FirstOrDefault(x => x.SupplierId == id);
        }
        public Supplier Create(Supplier user)
        {
            _db.Suppliers.Add(user);
            _db.SaveChanges();
            return user;
        }
        
        public int Delete(int id)
        {
            Supplier obj = SuppliersById(id);
            if (obj != null)
            {
                _db.Suppliers.Remove(obj);
                _db.SaveChanges();
                return 0;
            }
            else

                return 1;
        }
        public int Edit(int id, Supplier user)
        {
            Supplier obj = SuppliersById(id);
            if (obj != null)
            {
                foreach (Supplier temp in _db.Suppliers)
                {
                    if (temp.SupplierId == id)
                    {
                        temp.SupplierName = user.SupplierName;
                        temp.Address = user.Address;
                        temp.ContactNo = user.ContactNo;
                        temp.Email = user.Email;
                        temp.CityOperatesIn = user.CityOperatesIn;
                    }
                }
                _db.SaveChanges();
                return 0;
            }
            else

                return 1;
        }
    }
}


