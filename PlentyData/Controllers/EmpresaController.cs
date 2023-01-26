using Microsoft.AspNetCore.Mvc;
using PlentyData.Models;
using PlentyData.Models.ViewModels;
using PlentyData.Services;
using PlentyData.Services.Exceptions;

namespace PlentyData.Controllers
{
    public class EmpresaController : Controller
    {
        private readonly EmpresaService _empresaService;

        public EmpresaController(EmpresaService empresaService)
        {
            _empresaService = empresaService;
        }
        public IActionResult Index()
        {
            var list = _empresaService.FindAll();
            return View(list);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Empresa empresa)
        {
            _empresaService.Insert(empresa);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var empresa = _empresaService.FindById(id.Value);
            if (empresa == null)
            {
                return NotFound();
            }

            EmpresaEditar viewModel = new EmpresaEditar { empresa = empresa };
            return View(viewModel);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, Empresa empresa)
        {
            if (id != empresa.Id)
            {
                return BadRequest();
            }
            try
            {
                _empresaService.Update(empresa);
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
