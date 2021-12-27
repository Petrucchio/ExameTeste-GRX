using ExameTeste.Models;
using System;
using System.Linq;

namespace ExameTeste.Data

{
    public class SeedingService
    {
        private ExameTesteContext _context;

        public SeedingService(ExameTesteContext context)
        {
            _context = context;
        }
        public void Seed()
        {
            if(_context.FaixaEtaria.Any() || _context.Pessoa.Any())
            {
                return; //banco de dados já foi populado
            }

            FaixaEtaria g1 = new FaixaEtaria(new int(),"0 a 9");
            FaixaEtaria g2 = new FaixaEtaria(new int(), "10 a 19");
            FaixaEtaria g3 = new FaixaEtaria(new int(), "20 a 29");
            FaixaEtaria g4 = new FaixaEtaria(new int(), "30 a 39");

            Pessoa pessoa1 = new Pessoa(new int (), "Bob Brow", 9, new DateTime(2012, 4, 21), true, g1);
            Pessoa pessoa2 = new Pessoa(new int(), "Hulia Harmony", 8, new DateTime(2013, 6, 12), true, g1);
            Pessoa pessoa3 = new Pessoa(new int(), "Oprah Ferraz", 22, new DateTime(2000, 4, 8), true, g3);
            Pessoa pessoa4 = new Pessoa(new int(), "Chris Evans", 32, new DateTime(1989, 8, 12), true, g4);
            Pessoa pessoa5 = new Pessoa(new int(), "Elaine Elisangela", 19, new DateTime(2003, 5, 15), true,g2);

            _context.FaixaEtaria.AddRange(g1, g2, g3, g4);
            _context.Pessoa.AddRange(pessoa1, pessoa2, pessoa3, pessoa4, pessoa5);
            _context.SaveChanges();
        }
    }
}
