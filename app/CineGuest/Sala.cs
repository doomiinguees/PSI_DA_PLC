using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineGuest
{
    internal class Sala
    {
        [Key]
        public int id { get; set; }
        public string nome { get; set; }
        public int colunas { get; set; }
        public int linhas { get; set; }

        public Sala()
        {
            this.id = this.id + 1;
            this.nome = string.Empty;
            this.colunas = 0;
            this.linhas = 0;
        }

        public override string ToString()
        {
            return $"{nome} - {colunas} X {linhas}";
        }

    }
}
