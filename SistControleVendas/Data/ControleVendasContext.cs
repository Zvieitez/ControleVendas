using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SistControleVendas.Models;

namespace SistControleVendas.Data
{
    public class ControleVendasContext : DbContext
    {
        public ControleVendasContext (DbContextOptions<ControleVendasContext> options)
            : base(options)
        {
        }

        public DbSet<SistControleVendas.Models.Cliente> Cliente { get; set; } = default!;
        public DbSet<SistControleVendas.Models.Colaborador> Colaborador { get; set; } = default!;
        public DbSet<SistControleVendas.Models.NivelAcesso> NivelAcesso { get; set; } = default!;
        public DbSet<SistControleVendas.Models.Venda> Venda { get; set; } = default!;
        public DbSet<SistControleVendas.Models.FormaPagto> FormaPagto { get; set; } = default!;
        public DbSet<SistControleVendas.Models.Login> Login { get; set; } = default!;
        public DbSet<SistControleVendas.Models.Produto> Produto { get; set; } = default!;
    }
}
