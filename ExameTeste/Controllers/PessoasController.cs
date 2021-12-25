using ExameTeste.Services;
using Microsoft.AspNetCore.Mvc;

namespace ExameTeste.Controllers
{
    public class PessoasController : Controller
    {
        private readonly PessoaService _pessoaService;
        public PessoasController (PessoaService pessoaService)
        {
            _pessoaService = pessoaService; 
        }
        public IActionResult Index()
        {
            var list = _pessoaService.FindAll();
            return View(list);
        }
    }
}
