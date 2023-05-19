using InvSuppMVC.Context;
using InvSuppMVC.Models;

namespace InvSuppMVC.Repository
{
    public class InventoryRepository:InterfaceInventory
    {
        UserDbContext _db;
        public InventoryRepository(UserDbContext db)
        {
            _db = db;
        }

        public List<Inventory> GetInventory()
        {
            return _db.Inventories.ToList();
        }
        public Inventory InventoriesById(int id)
        {
            return _db.Inventories.FirstOrDefault(x => x.InventoryId == id);
        }
        public Inventory Create(Inventory inventory)
        {
            _db.Inventories.Add(inventory);
            _db.SaveChanges();
            return inventory;
        }
        public int Delete(int id)
        {
            Inventory obj = InventoriesById(id);
            if (obj != null)
            {
                _db.Inventories.Remove(obj);
                _db.SaveChanges();
                return 0;
            }
            else

                return 1;
        }
        public int Edit(int id, Inventory inventory)
        {
            Inventory obj = InventoriesById(id);
            if (obj != null)
            {
                foreach (Inventory temp in _db.Inventories)
                {
                    if (temp.InventoryId == id)
                    {
                        temp.Name = inventory.Name;
                        temp.Details = inventory.Details;
                        temp.QtyInStock = inventory.QtyInStock;
                        temp.LastUpdated = inventory.LastUpdated;
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
