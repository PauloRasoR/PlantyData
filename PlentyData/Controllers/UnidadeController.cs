using Microsoft.AspNetCore.Mvc;
using PlentyData.Models;
using PlentyData.Models.ViewModels;
using PlentyData.Services;
using PlentyData.Services.Exceptions;

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

        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var unidade = _unidadeService.FindById(id.Value);
            if (unidade == null)
            {
                return NotFound();
            }

            UnidadeEditar viewModel = new UnidadeEditar { unidade = unidade };
            return View(viewModel);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, Unidade unidade)
        {
            if (id != unidade.Id)
            {
                return BadRequest();
            }
            try
            {
                _unidadeService.Update(unidade);
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
