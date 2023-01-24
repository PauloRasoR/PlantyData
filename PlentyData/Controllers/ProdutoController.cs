using Microsoft.AspNetCore.Mvc;
using PlentyData.Models;
using PlentyData.Models.Enum;
using PlentyData.Models.ViewModels;
using PlentyData.Services;

namespace PlentyData.Controllers
{
    public class ProdutoController : Controller
    {
        private readonly ProdutoService _produtoService;
        private readonly UnidadeService _unidadeService;

        public ProdutoController(ProdutoService produtoService, UnidadeService unidadeService)
        {
            _produtoService = produtoService;
            _unidadeService = unidadeService;            
        }
        public IActionResult Index()
        {
            var list = _produtoService.FindAll();
            return View(list);
        }

        public IActionResult Create()
        {
            var unidade = _unidadeService.FindAll();            
            var viewModel = new ProdutoCadastro { Unidade = unidade };
            return View(viewModel);
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Produto produto)
        {
            _produtoService.Insert(produto);
            return RedirectToAction(nameof(Index));
        }
    }
}
