using ExameTeste.Data;
using ExameTeste.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ExameTeste.Services
{
    public class FaixaEtariaService
    {
        private readonly ExameTesteContext _context;

        public FaixaEtariaService(ExameTesteContext context)
        {
            _context = context;
        }
        public async Task<List<FaixaEtaria>> FindAllAsync()
        {
            return await _context.FaixaEtaria.ToListAsync();
        }
    }
}
