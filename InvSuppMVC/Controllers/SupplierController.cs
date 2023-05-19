using InvSuppMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace InvSuppMVC.Controllers
{
    public class SupplierController : Controller
    {
        InterfaceSupplier _repo;
        public SupplierController(InterfaceSupplier repo)
        {
            _repo = repo;
        }
        public IActionResult Index()
        {
            return View((_repo.GetSupplier()));
        }

        public IActionResult Create()
        {

            return View();
        }
        [HttpPost]
        public IActionResult Create(Supplier user)
        {
            _repo.Create(user);
            return RedirectToAction("Index");
        }
        //public IActionResult Details(int id)
        //{
        //    return View(Supplier.FirstOrDefault(x => x.SupplierId == id));

        //}
        public IActionResult Edit(int id)
        {
            Supplier obj = _repo.SuppliersById(id);
            return View(obj);

        }
        [HttpPost]
        public IActionResult Edit(int id, Supplier supplier)
        {
            _repo.Edit(id, supplier);
            return RedirectToAction("Index");
        }
        public IActionResult Details(int id)
        {
            Supplier obj = _repo.SuppliersById(id);
            return View(obj);
        }
    }
}
