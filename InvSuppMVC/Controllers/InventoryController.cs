using Microsoft.AspNetCore.Mvc;
using InvSuppMVC.Repository;
using InvSuppMVC.Models;

namespace InvSuppMVC.Controllers
{
    public class InventoryController : Controller
    {
        InterfaceInventory _repo;
        public InventoryController(InterfaceInventory repo) 
        {
            _repo = repo;
        }
        public IActionResult Index()
        {
            return View(_repo.GetInventory());
        }
        public IActionResult Create()
        {

            return View();
        }
        [HttpPost]
        public IActionResult Create(Inventory inventory)
        {
            _repo.Create(inventory);
            return RedirectToAction("Index");
        }
    }
}
