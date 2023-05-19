using InvSuppMVC.Models;

namespace InvSuppMVC
{
    public interface InterfaceSupplier
    {
        List<Supplier> GetSupplier();
        Supplier Create(Supplier user);
        Supplier SuppliersById(int id);
        int Delete(int id);
        int Edit(int id, Supplier user);
    }
}
