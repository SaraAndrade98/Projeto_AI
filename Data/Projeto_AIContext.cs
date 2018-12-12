using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Projeto_AI.Models
{
    public class Projeto_AIContext : DbContext
    {
        public Projeto_AIContext (DbContextOptions<Projeto_AIContext> options)
            : base(options)
        {
        }

        public DbSet<Projeto_AI.Models.DispositivoEletronico> DispositivoEletronico { get; set; }
    }
}
