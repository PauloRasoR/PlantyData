using Microsoft.AspNetCore.Mvc;
using PlentyData.Models;
using PlentyData.Models.Enum;
using PlentyData.Models.ViewModels;
using PlentyData.Services;
using PlentyData.Services.Exceptions;
using System.Linq;

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


        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var prod = _produtoService.FindById(id.Value);
            if (prod == null)
            {
                return NotFound();
            }

            List<Unidade> unidades = _unidadeService.FindAll();
            ProdutoCadastro viewModel = new ProdutoCadastro { produto = prod, Unidade = unidades };
            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, Produto produto)
        {
            if ( id != produto.Id)
            {
                return BadRequest();
            }
            try
            {
                _produtoService.Update(produto);
                return RedirectToAction(nameof(Index));
            }
            catch (NotFoundException)
            {
                return NotFound();
            }
            catch (DbConcurrencyException)
            {
                return BadRequest();
            }
        }
    
    }
}
