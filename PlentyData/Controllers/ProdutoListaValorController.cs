using Microsoft.AspNetCore.Mvc;
using PlentyData.Models;
using PlentyData.Services;

namespace PlentyData.Controllers
{
    public class ProdutoListaValorController : Controller
    {
        private readonly ProdutoListaValorService _produtoListaValorService;

        public ProdutoListaValorController(ProdutoListaValorService produtoListaValorService)
        {
            _produtoListaValorService = produtoListaValorService;
        }
        public IActionResult Index()
        {
            var list = _produtoListaValorService.FindAll();
            return View(list);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(ProdutoListaValor produtolistavalor)
        {
            _produtoListaValorService.Insert(produtolistavalor);
            return RedirectToAction(nameof(Index));
        }
    }
}
