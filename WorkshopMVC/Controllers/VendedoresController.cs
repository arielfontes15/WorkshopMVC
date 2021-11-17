using Microsoft.AspNetCore.Mvc;
using WorkshopMVC.Models;
using WorkshopMVC.Services;

namespace WorkshopMVC.Controllers
{
    public class VendedoresController : Controller
    {
        private readonly Service _service;

        public VendedoresController(Service service)
        {
            _service = service;
        }

        // GET: Vendedores
        public IActionResult Index()
        {
            var list = _service.FindAll();
            return View(list);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Vendedor vendedor)
        {
            _service.Insert(vendedor);
            return RedirectToAction(nameof(Index));
        }

    }
}

