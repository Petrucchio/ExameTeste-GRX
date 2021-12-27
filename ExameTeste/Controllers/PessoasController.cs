using ExameTeste.Models;
using ExameTeste.Models.ViewModels;
using ExameTeste.Services;
using ExameTeste.Services.Exceptions;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;

namespace ExameTeste.Controllers
{
    public class PessoasController : Controller
    {
        private readonly PessoaService _pessoaService;
        private readonly FaixaEtariaService _faixaEtariaService;
        public PessoasController (PessoaService pessoaService, FaixaEtariaService faixaEtariaService)
        {
            _pessoaService = pessoaService; 
            _faixaEtariaService = faixaEtariaService;
        }
        public async Task<IActionResult> Index()
        {
            var list = await _pessoaService.FindAllAsync();
            return View(list);
        }
        public async Task<IActionResult> Create()
        {
            
            var faixaEtarias = await _faixaEtariaService.FindAllAsync();
            var viewModel = new PessoaFormViewModel { FaixaEtarias=faixaEtarias};
            return View(viewModel);  
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Pessoa pessoa)
        {
            if (!ModelState.IsValid)
            {
                var faixaEtarias = await _faixaEtariaService.FindAllAsync();
                var viewModel = new PessoaFormViewModel { pessoa = pessoa, FaixaEtarias = faixaEtarias };
                return View(viewModel);
            }
             await _pessoaService.InsertAsync(pessoa);
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Delete(int? id) 
        {
            if (id == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id não fornecido" });
            }
            var obj = await _pessoaService.FindByIdAsync(id.Value);
            if (obj == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id not found" });
            }
            return View(obj);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id) //implementar exclusão logica
        {
            try
            {
                await _pessoaService.RemoveAsync(id);
                return RedirectToAction(nameof(Index));
            }
            catch (IntegrityException e)
            {
                return RedirectToAction(nameof(Error), new { message = e.Message });
            }
        }
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id não fornecido" });
            }
            var obj = await _pessoaService.FindByIdAsync(id.Value);
            if (obj == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id not found" });
            }
            return View(obj);
        }
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id não fornecido" });
            }
            var obj = await _pessoaService.FindByIdAsync(id.Value);
            if(obj == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id not found" });
            }
            List<FaixaEtaria> faixaEtarias = await _faixaEtariaService.FindAllAsync();
            PessoaFormViewModel viewModel = new PessoaFormViewModel { pessoa = obj, FaixaEtarias = faixaEtarias };
            return View(viewModel);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Pessoa pessoa)
        {
            if (!ModelState.IsValid)
            {
                var faixaEtarias = await _faixaEtariaService.FindAllAsync();
                var viewModel = new PessoaFormViewModel { pessoa = pessoa, FaixaEtarias = faixaEtarias };
                return View(viewModel);
            }
            if (id != pessoa.Id)
            {
                return RedirectToAction(nameof(Error), new { message = "Id não correspondem" });
            }
            try 
            { 
            await _pessoaService.UpdateAsync(pessoa);
            return RedirectToAction(nameof(Index));
            } 
            catch (NotFoundException e)
            {
                return RedirectToAction(nameof(Error), new { message = e.Message });
            }
            catch (DbConcurrencyException e)
            {
                return RedirectToAction(nameof(Error), new { message = e.Message });
            }
        }
        public IActionResult Error(string message)
        {
            var viewModel = new ErrorViewModel
            {
                Message = message,
                RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier
            };
            return View(viewModel);
        }
    }
}
