using Microsoft.AspNetCore.Mvc;
using PlentyData.Models;
using PlentyData.Models.ViewModels;
using PlentyData.Services;

namespace PlentyData.Controllers
{
    public class ProdutoValorController : Controller
    {
        private readonly ProdutoValorService _produtoValorService;
        private readonly EmpresaService _empresaService;
        private readonly UnidadeService _unidadeService;

        public ProdutoValorController(ProdutoValorService produtoValorService, EmpresaService empresaService, UnidadeService unidadeService)
        {
            _produtoValorService = produtoValorService;
            _empresaService = empresaService;
        
        }
        public IActionResult Index()
        {
            var list = _produtoValorService.FindAll();
            return View(list);
        }

        public IActionResult Create()
        {
            var empresa = _empresaService.FindAll();
            var viewModel = new ProdutoCadastro { empresa = empresa }; 
            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(ProdutoValor produtoValor)
        {         
            _produtoValorService.Insert(produtoValor);
            return RedirectToAction(nameof(Index));
        }
    }
}
