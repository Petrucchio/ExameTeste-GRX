using ExameTeste.Data;
using ExameTeste.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using ExameTeste.Services.Exceptions;
using System.Threading.Tasks;

namespace ExameTeste.Services
{
    public class PessoaService
    {
        private readonly ExameTesteContext _context;

        public PessoaService(ExameTesteContext context)
        {
            _context = context;
        }

        public async Task<List<Pessoa>> FindAllAsync()
        {
            return await _context.Pessoa.Include(obj => obj.FaixaEtaria).ToListAsync();
        }

        public async Task InsertAsync(Pessoa obj)
        {
            _context.Add(obj);
            await _context.SaveChangesAsync();
        }
        public async Task<Pessoa> FindByIdAsync(int id)
        {
            return await _context.Pessoa.Include(obj => obj.FaixaEtaria).FirstOrDefaultAsync(obj => obj.Id == id);
        }
        public async Task RemoveAsync(int id)
        {
            try
            {
                var obj = await _context.Pessoa.FindAsync(id);
                _context.Pessoa.Remove(obj);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException e)
            {
                throw new IntegrityException(e.Message);
            }
        }
        public async Task UpdateAsync(Pessoa obj)
        {
            bool hasAny = await _context.Pessoa.AnyAsync(x => x.Id == obj.Id);
            if (!hasAny)
            {
                throw new NotFoundException("Id not found");
            }
            try
            {
                _context.Update(obj);
                await _context.SaveChangesAsync();
            }
            catch(DbUpdateConcurrencyException e)
            {
                throw new DbConcurrencyException(e.Message);
            }
            
        }
    }
}
