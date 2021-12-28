using ExameTeste.Data;
using ExameTeste.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using ExameTeste.Services.Exceptions;
using System.Threading.Tasks;
using System;

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
            return await _context.Pessoa.Include(obj => obj.FaixaEtaria).OrderByDescending(x => x.Age).ToListAsync();
        }

        public async Task InsertAsync(Pessoa obj)
        {
            var faixa = obj.Age;
            if (faixa < 10 && faixa > 0)
            {
                obj.FaixaEtariaId = 1;
            }
            else if (faixa >= 10 && faixa < 20)
            {
                obj.FaixaEtariaId = 2;
            }
            else if (faixa >= 20 && faixa < 30)
            {
                obj.FaixaEtariaId = 3;
            }
            else if (faixa >= 30 && faixa < 40)
            {
                obj.FaixaEtariaId = 4;
            }
            else if (faixa >= 40)
            {
                obj.FaixaEtariaId = 5;
            }
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
                obj.Active = false;
                _context.Pessoa.Update(obj);
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
                var faixa = obj.Age;
                if (faixa < 10 && faixa > 0)
                {
                    obj.FaixaEtariaId = 1;
                }
                else if (faixa >= 10 && faixa < 20)
                {
                    obj.FaixaEtariaId = 2;
                }
                else if (faixa >= 20 && faixa < 30)
                {
                    obj.FaixaEtariaId = 3;
                }
                else if (faixa >= 30 && faixa < 40)
                {
                    obj.FaixaEtariaId = 4;
                }
                else if (faixa >= 40)
                {
                    obj.FaixaEtariaId = 5;
                }
                _context.Update(obj);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException e)
            {
                throw new DbConcurrencyException(e.Message);
            }

        }
        public async Task<List<Pessoa>> FindByDateAsync(DateTime? minDate, DateTime? maxDate)
        {
            var result = from obj in _context.Pessoa select obj;
            if (minDate.HasValue)
            {
                result = result.Where(x => x.BirthDate >= minDate.Value);
            }
            if (maxDate.HasValue)
            {
                result = result.Where(x => x.BirthDate <= maxDate.Value);
            }
            return await result.Include(x => x.FaixaEtaria).OrderByDescending(x => x.Age).ToListAsync();
        }
        public async Task<List<Pessoa>> FindByAgeAsync(int? minAge, int? maxAge)
        {
            var result = from obj in _context.Pessoa select obj;
            if (minAge.HasValue)
            {
                result = result.Where(x => x.Age >= minAge.Value);
            }
            if (maxAge.HasValue)
            {
                result = result.Where(x => x.Age <= maxAge.Value);
            }
            return await result.Include(x => x.FaixaEtaria).OrderByDescending(x => x.Age).ToListAsync();
        }
        public async Task<List<Pessoa>> FindByNameAsync(string name)
        {
            var result = from obj in _context.Pessoa select obj;
            if (!string.IsNullOrEmpty(name))
            {
                result = result.Where(x => x.Name == name);
            }
            else
            {
                result = result.Where(x => x.Name != name);
            }
            return await result.Include(x => x.FaixaEtaria).OrderByDescending(x => x.Age).ToListAsync();
        }
        public async Task<List<Pessoa>> FindByFaixaEtariaAsync(int FaixaEtaria)
        {
            var result = from obj in _context.Pessoa select obj;
            switch (FaixaEtaria)

            {
                case 0:
                    result = result.Where(x => x.FaixaEtariaId == FaixaEtaria);
                    break;
                case 1:
                    result = result.Where(x => x.FaixaEtariaId == FaixaEtaria);
                    break;
                case 2:
                    result = result.Where(x => x.FaixaEtariaId == FaixaEtaria);
                    break;
                case 3:
                    result = result.Where(x => x.FaixaEtariaId == FaixaEtaria);
                    break;
                case 4:
                    result = result.Where(x => x.FaixaEtariaId == FaixaEtaria);
                    break;
                case 5:
                    result = result.Where(x => x.FaixaEtariaId == FaixaEtaria);
                    break;
            }
            return await result.Include(x => x.FaixaEtaria).OrderByDescending(x => x.Age).ToListAsync();
        }



    }
}
