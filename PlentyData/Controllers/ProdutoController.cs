using Microsoft.AspNetCore.Mvc;
using PlentyData.Services;

namespace PlentyData.Controllers
{
    public class ProdutoController : Controller
    {
        private readonly ProdutoService _produtoService;

        public ProdutoController(ProdutoService produtoService)
        {
            _produtoService = produtoService;
        }
        public IActionResult Index()
        {
            var list = _produtoService.FindAll();
            return View(list);
        }
    }
}
