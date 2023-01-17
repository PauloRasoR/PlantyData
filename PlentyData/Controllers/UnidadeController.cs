using Microsoft.AspNetCore.Mvc;
using PlentyData.Models;
using PlentyData.Services;

namespace PlentyData.Controllers
{
    public class UnidadeController : Controller
    {
        private readonly UnidadeService _unidadeService;

        public UnidadeController(UnidadeService unidadeService)
        {
            _unidadeService = unidadeService;
        }
        public IActionResult Index()
        {
            var list = _unidadeService.FindAll();
            return View(list);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Unidade unidade)
        {
            _unidadeService.Insert(unidade);
            return RedirectToAction(nameof(Index));
        }
    }
}
