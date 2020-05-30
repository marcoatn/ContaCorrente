using ContaCorrenteAPI.Modelos;
using ContaCorrenteAPI.Modelos.Dots;
using ContaCorrenteAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContaCorrenteAPI.Dados
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Conta> Conta { get; set; }
        public DbSet<Titular> Titular { get; set; }
        public DbSet<Transacao> Transacao { get; set; }
    }
}
