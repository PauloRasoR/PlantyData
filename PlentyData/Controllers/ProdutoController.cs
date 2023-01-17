﻿using Microsoft.AspNetCore.Mvc;
using PlentyData.Models;
using PlentyData.Models.ViewModels;
using PlentyData.Services;

namespace PlentyData.Controllers
{
    public class ProdutoController : Controller
    {
        private readonly ProdutoService _produtoService;
        private readonly EmpresaService _empresaService;
        private readonly UnidadeService _unidadeService;

        public ProdutoController(ProdutoService produtoService, EmpresaService empresaService, UnidadeService unidadeService)
        {
            _produtoService = produtoService;
            _empresaService = empresaService;
            _unidadeService = unidadeService;
        }
        public IActionResult Index()
        {
            var list = _produtoService.FindAll();
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
        public IActionResult Create(Produto produto)
        {
            _produtoService.Insert(produto);
            return RedirectToAction(nameof(Index));
        }
    }
}
