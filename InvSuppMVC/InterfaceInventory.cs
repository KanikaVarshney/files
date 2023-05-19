using InvSuppMVC.Models;

namespace InvSuppMVC
{
    public interface InterfaceInventory
    {
        List<Inventory> GetInventory();
        Inventory Create(Inventory user);
        Inventory InventoriesById(int id);
        int Delete(int id);
        int Edit(int id, Inventory user);
    }
}
