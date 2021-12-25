using ExameTeste.Data;
using ExameTeste.Models;
using System.Collections.Generic;
using System.Linq;

namespace ExameTeste.Services
{
    public class PessoaService
    {
        private readonly ExameTesteContext _context;

        public PessoaService(ExameTesteContext context)
        {
            _context = context;
        }

        public List<Pessoa> FindAll()
        {
            return _context.Pessoa.ToList();
        }
    }
}
