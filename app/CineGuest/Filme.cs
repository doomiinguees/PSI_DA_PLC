using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineGuest
{
    internal class Filme
    {
        [Key]
        public int id { get; set; }
        public string Nome { get; set; }
        public TimeSpan Duracao { get; set; }
        public string Estado { get; set; }
        public string Categoria { get; set; }

        public Filme()
        {
            this.id = id + 1;
            this.Nome = null;
            this.Estado = "Desativado";
            this.Categoria = null;

        }

        public override string ToString()
        {
            return $"{Nome} | {Categoria} | {Duracao} | {Estado}";
        }
    }
}
