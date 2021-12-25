using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ExameTeste.Models;

namespace ExameTeste.Data
{
    public class ExameTesteContext : DbContext
    {
        public ExameTesteContext (DbContextOptions<ExameTesteContext> options)
            : base(options)
        {
        }

        public DbSet<FaixaEtaria> FaixaEtaria { get; set; }
        public DbSet<Pessoa> Pessoa { get; set; }
    }
}
