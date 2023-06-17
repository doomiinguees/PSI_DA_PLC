using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineGuest
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext() : base("CineGuest.ApplicationContext")
        {
            Database.SetInitializer(new ApplicationContextInitializer());
        }

        public DbSet<Cinema> Cinemas { get; set; }
        public DbSet<Sala> Salas { get; set; }
        public DbSet<Filme> Filmes { get; set; }
        public DbSet<Sessao> Sessoes { get; set; }
        public DbSet<Pessoa> Pessoas{ get; set; }
        public DbSet<Funcionario> Funcionarios { get; set; }
        public DbSet<Cliente> Clientes{ get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Bilhete> Bilhetes{ get; set; }
    }
}
