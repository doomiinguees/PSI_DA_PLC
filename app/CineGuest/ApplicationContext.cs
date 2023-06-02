using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineGuest
{
    internal class ApplicationContext : DbContext
    {
        public DbSet <Cinema> Cinemas { get; set; }
        public DbSet <Sala> Salas { get; set; }
        public DbSet <Filme> Filmes { get; set; }
        public DbSet <Sessao> Sessoes { get; set; }
    }
}
